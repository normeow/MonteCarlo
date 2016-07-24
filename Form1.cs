using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo
{
    public partial class Form1 : Form
    {
        string[] areaTypes;
        public IArea areaA, areaB;
        public Rect areaI;

        public int numPoints;

        public double accPsbltA;
        public double accPsbltB;
        public double accPsbltAandB;
        public double accPsbltAorB;

        const string AREA = "Область А";
        const string AREB = "Область B";
        const string AREI = "Область I";

        public Form1()
        {
            InitializeComponent();
            areaTypes = new string[] { "Прямоугольник", "Окружность", "Эллипс" };
            cbTypeA.Items.AddRange(areaTypes);
            cbTypeB.Items.AddRange(areaTypes);
            cbTypeA.SelectedIndex = 1;
            cbTypeB.SelectedIndex = 2;
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            try {
                numPoints = (int)numPoint.Value;
                areaI = new Rect((int)cntrlX1.Value, (int)cntrlY1.Value, (int)cntrlX2.Value, (int)cntrlY2.Value);
                /*accPsbltA = Double.Parse(tbPa.Text);
                accPsbltB = Double.Parse(tbPb.Text);
                accPsbltAandB = Double.Parse(tbPAB.Text);
                accPsbltAorB = Double.Parse(tbPAorB.Text);*/
                checkAllValues();
                Form2 form = new Form2(this);
                form.Activate();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  

        void checkAllValues()
        {
            double pa = Double.Parse(tbPa.Text);
            double pb = Double.Parse(tbPb.Text);
            double pab = Double.Parse(tbPAB.Text);
            double paorb = Double.Parse(tbPAorB.Text);
            if (pa < 0 || pb < 0 || pab < 0 || paorb < 0)
                throw new ArgumentOutOfRangeException("Расчетные вероятности должны быть больше нуля");
            accPsbltA = pa;
            accPsbltB = pb;
            accPsbltAandB = pab;
            accPsbltAorB = paorb;

        }

        void updateTabs()
        {
            updateTabA();
            updateTabB();
        }

        void updateTabA()
        {
            switch (cbTypeA.SelectedIndex)
            {
                case 0:
                    drawRectSample(tabA, ref areaA);
                    break;
                case 1:
                    drawCircleSample(tabA, ref areaA);
                    break;
                case 2:
                    drawEllipseSample(tabA, ref areaA);
                    break;
            }
        }

        void updateTabB()
        {

            switch (cbTypeB.SelectedIndex)
            {
                case 0:
                    drawRectSample(tabB, ref areaB);
                    break;
                case 1:
                    drawCircleSample(tabB, ref areaB);
                    break;
                case 2:
                    drawEllipseSample(tabB, ref areaB);
                    break;
            }
        }

        private void drawEllipseSample(TabPage tab, ref IArea a)
        {
            a = new EllipseArea();
            tab.Controls.Add((EllipseArea)a);
        }
        
        private void drawCircleSample(TabPage tab, ref IArea a)
        {
            a = new CircleArea();
            tab.Controls.Add((CircleArea)a);
        }

        private void drawRectSample(TabPage tab, ref IArea a)
        {
            a = new RectArea();
            tab.Controls.Add((RectArea)a);
        }

        private void cbTypeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tabA.Controls.Clear();
            tabA.Invalidate();
            updateTabA();

        }


        private void cbTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;
            tabB.Controls.Clear();
            tabB.Invalidate();
            updateTabB();
        }
    }
}
