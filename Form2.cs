using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace MonteCarlo
{
    public partial class Form2 : Form
    {
        private const int TIME_INTERVAL = 100;
        private const int oy = 400;
        private const int ox = 35;
        private const int k = 15;

        private String modelstr;
        private String pausestr;
        private String contstr;
        private String stopstr;

        private MainForm parental;
        private Shape a, b;

        private int numPoints;
        private int curPoints;

        //попало в область 
        private double pntsInA;
        private double pntsInB;
        private double pntsInAandB;
        private double pntsInAorB;
        
        //расчетная вероятность
        private double psbltA;
        private double psbltB;
        private double psbltAandB;
        private double psbltAorB;

        //относительная погрешность
        private double errA;
        private double errB;
        private double errAandB;
        private double errAorB;

        //расчетная площадь
        private double sqrA;
        private double sqrB;
        private double sqrAandB;
        private double sqrAorB;

        private double sqrI, accPsbltA, accPsbltB, accPsbltAandB, accPsbltAorB;
        bool proc;
        bool dontupdatecells;
        Random rnd;
        public Form2(MainForm p)
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            this.Height = 770;
            this.parental = p;
            this.numPoints = p.numPoints;
            curPoints = 0;
            InitializeComponent();

            ResourceManager LocRM = new ResourceManager("MonteCarlo.Form2", typeof(Form2).Assembly);
            modelstr = LocRM.GetString("model");
            pausestr = LocRM.GetString("pause");
            contstr = LocRM.GetString("cont");
            stopstr = LocRM.GetString("stop");

            timer1.Interval = TIME_INTERVAL;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 400;
            trackBar1.Value = TIME_INTERVAL;
            a = p.areaA.getShape();
            b = p.areaB.getShape();
            rnd = new Random();

            sqrI = parental.areaI.getSquare();
            accPsbltA = parental.accPsbltA;
            accPsbltB = parental.accPsbltB;
            accPsbltAandB = parental.accPsbltAandB;
            accPsbltAorB = parental.accPsbltAorB;

            int m = p.areaI.width() > p.areaI.height() ? p.areaI.width() : p.areaI.height();
            btnStop.Enabled = false;
            dontupdatecells = checkBox1.Checked;
        }
        

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            parental.Show();
        }
        

        PointF getNewCoordnts(PointF p){
            return new PointF(p.X + ox, oy - p.Y);
        }
        
        PointF getNewCoordnts(double x, double y)
        {
            return new PointF((float)(x + ox), (float)(oy - y));
        }

        float getNewX(double x)
        {
            return (float)(x + ox);
        }

        float getNewY(double y)
        {
            return (float) (oy - y);
        }


        private void DrawCoordSystem(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black), getNewCoordnts(new PointF(0, 0)), getNewCoordnts(new PointF(0, 350)));
            g.DrawLine(new Pen(Color.Black), getNewCoordnts(new PointF(0, 0)), getNewCoordnts(new PointF(350, 0)));


            g.DrawLine(new Pen(Color.Black), getNewCoordnts(new PointF(0, 350)), getNewCoordnts(new PointF(-5, 340)));
            g.DrawLine(new Pen(Color.Black), getNewCoordnts(new PointF(0, 350)), getNewCoordnts(new PointF(5, 340)));
            g.DrawLine(new Pen(Color.Black), getNewCoordnts(new PointF(350, 0)), getNewCoordnts(new PointF(340, 5)));
            g.DrawLine(new Pen(Color.Black), getNewCoordnts(new PointF(350, 0)), getNewCoordnts(new PointF(340, -5)));

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            btnModel.Text = modelstr;
            btnStop.Enabled = false;
            proc = false;
            //отрисовать панель
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCoordSystem(drawPanel.CreateGraphics());
            DrawArea(drawPanel.CreateGraphics(), parental.areaI);
            DrawAreas();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dontupdatecells = checkBox1.Checked;
        }

        private void DrawAreas()
        {
            if (a.getSquare() > b.getSquare())
            {

                FillArea(drawPanel.CreateGraphics(), a, Color.Aquamarine);
                FillArea(drawPanel.CreateGraphics(), b, Color.Cyan);
            }
            else {
                FillArea(drawPanel.CreateGraphics(), b, Color.Cyan);
                FillArea(drawPanel.CreateGraphics(), a, Color.Aquamarine);
            }
            DrawArea(drawPanel.CreateGraphics(), a);
            DrawArea(drawPanel.CreateGraphics(), b);
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
           if (proc)
            {
                proc = false;
                if (!checkBox1.Checked)
                    timer1.Stop();
                btnModel.Text = contstr;
            }
            else {

                if (btnModel.Text != contstr)
                {
                    resetVls();
                    drawPanel.Refresh();
                }
                proc = true;
                btnModel.Text = pausestr;
                btnStop.Enabled = true;
                timer1.Start();
            }


        }

        private void resetVls()
        {
            pntsInA = 0;
            pntsInB = 0;
            pntsInAandB = 0;
            pntsInAorB = 0;

            psbltA = 0;
            psbltAandB = 0;
            psbltAorB = 0;
            psbltB = 0;

            errA = 0;
            errB = 0;
            errAorB = 0;
            errAandB = 0;

            sqrA = 0;
            sqrB = 0;
            sqrAorB = 0;
            sqrAandB = 0;
            curPoints = 0;
        }

        private void fillTbs()
        {
            // Console.WriteLine("#{0}: x = {1}, y = {2}", curPoints, x, y);
            //set tboxes's values
            tbinA.Text = pntsInA.ToString();
            tbinB.Text = pntsInB.ToString();
            tbinAB.Text = pntsInAandB.ToString();
            tbinAorB.Text = pntsInAorB.ToString();

            clcpA.Text = psbltA.ToString();
            clcpB.Text = psbltB.ToString();
            clcpAB.Text = psbltAandB.ToString();
            clcpAorB.Text = psbltAorB.ToString();

            tbErA.Text = errA.ToString();
            tbErB.Text = errB.ToString();
            tbErAB.Text = errAandB.ToString();
            tbErAorB.Text = errAorB.ToString();

            tbSqrA.Text = sqrA.ToString();
            tbSqrB.Text = sqrB.ToString();
            tbSqrAB.Text = sqrAandB.ToString();
            tbSqrAorB.Text = sqrAorB.ToString();

            tbPnts.Text = curPoints.ToString();
        }

        private void calculate()
        {

            int sz = 3;
            double x = rnd.NextDouble() * (parental.areaI.x2 - parental.areaI.x1) + parental.areaI.x1;
            double y = rnd.NextDouble() * (parental.areaI.y2 - parental.areaI.y1) + parental.areaI.y1;

            PointF temp = getNewCoordnts(k * x - sz / 2, k * y + sz / 2);

            drawPanel.CreateGraphics().FillEllipse(new SolidBrush(Color.Red), new RectangleF(temp, new SizeF(sz, sz)));

            curPoints++;

            bool inA = a.isWithin(x, y);
            bool inB = b.isWithin(x, y);

            if (inA)
                pntsInA++;
            if (inB)
                pntsInB++;
            if (inA && inB)
                pntsInAandB++;
            if (inA || inB)
                pntsInAorB++;

            psbltA = pntsInA / curPoints;
            psbltB = pntsInB / curPoints;
            psbltAandB = pntsInAandB / curPoints;
            psbltAorB = pntsInAorB / curPoints;

            errA = (accPsbltA - psbltA) / accPsbltA;
            errB = (accPsbltB - psbltB) / accPsbltB;
            errAandB = (accPsbltAandB - psbltAandB) / accPsbltAandB;
            errAorB = (accPsbltAorB - psbltAorB) / accPsbltAorB;

            sqrA = sqrI * psbltA;
            sqrB = sqrI * psbltB;
            sqrAandB = sqrI * psbltAandB;
            sqrAorB = sqrI * psbltAorB;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calculate();
            if (!dontupdatecells)
                fillTbs();
            
            if (curPoints == numPoints)
            {
                timer1.Stop();
                btnModel.Text = modelstr;
                btnStop.Enabled = false;
                fillTbs();
                resetVls();
                MessageBox.Show("Done");
            }
            
        }

        private void FillArea(Graphics g, Shape s, Color c)
        {
            if (s is Rect)
            {
                Rect tmp = s as Rect;
                g.FillRectangle(new SolidBrush(c), getNewX(k * tmp.x1), getNewY(k * tmp.y2), k*tmp.width(), k*tmp.height());

            }

            else if (s is Circle)
            {
                float x = getNewX(k*((s as Circle).x - (s as Circle).r));
                float y = getNewY(k*((s as Circle).y + (s as Circle).r));
                float r = (s as Circle).r;
                RectangleF rec = new RectangleF(x, y, k*2*r, k*2*r);
                g.FillEllipse(new SolidBrush(c), rec);

            }


            else if (s is Ellipse)
            {
                Ellipse tmp = s as Ellipse;
                RectangleF rec = new RectangleF(getNewX(k*(tmp.x - tmp.a)), getNewY(k*(tmp.y + tmp.b)), k* 2 * tmp.a, k* 2 * tmp.b);
                g.FillEllipse(new SolidBrush(c), rec);
            }
        }

        private void DrawArea(Graphics g, Shape s)
        {
            if (s is Rect)
            {
                Rect tmp = s as Rect;
                g.DrawRectangle(new Pen(Color.Black), getNewX(k * tmp.x1), getNewY(k * tmp.y2), k * tmp.width(), k * tmp.height());

            }

            else if (s is Circle)
            {
                float x = getNewX(k * ((s as Circle).x - (s as Circle).r));
                float y = getNewY(k * ((s as Circle).y + (s as Circle).r));
                float r = (s as Circle).r;
                RectangleF rec = new RectangleF(x, y, k * 2 * r, k * 2 * r);
                g.DrawEllipse(new Pen(Color.Black), rec);

            }


            else if (s is Ellipse)
            {
                Ellipse tmp = s as Ellipse;
                RectangleF rec = new RectangleF(getNewX(k * (tmp.x - tmp.a)), getNewY(k * (tmp.y + tmp.b)), k * 2 * tmp.a, k * 2 * tmp.b);
                g.DrawEllipse(new Pen(Color.Black), rec);
            }
        }
    }
}
