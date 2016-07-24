namespace MonteCarlo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbinAB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbinAorB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbinB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbinA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clcpAB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clcpAorB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clcpB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clcpA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbErAB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbErAorB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbErB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbErA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbSqrAB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSqrAorB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSqrB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSqrA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.tbPnts = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbinAB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbinAorB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbinB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbinA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(692, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Попало в область";
            // 
            // tbinAB
            // 
            this.tbinAB.Location = new System.Drawing.Point(141, 121);
            this.tbinAB.Name = "tbinAB";
            this.tbinAB.ReadOnly = true;
            this.tbinAB.Size = new System.Drawing.Size(168, 26);
            this.tbinAB.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "A и B";
            // 
            // tbinAorB
            // 
            this.tbinAorB.Location = new System.Drawing.Point(141, 89);
            this.tbinAorB.Name = "tbinAorB";
            this.tbinAorB.ReadOnly = true;
            this.tbinAorB.Size = new System.Drawing.Size(168, 26);
            this.tbinAorB.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "A или B";
            // 
            // tbinB
            // 
            this.tbinB.Location = new System.Drawing.Point(141, 57);
            this.tbinB.Name = "tbinB";
            this.tbinB.ReadOnly = true;
            this.tbinB.Size = new System.Drawing.Size(168, 26);
            this.tbinB.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "B";
            // 
            // tbinA
            // 
            this.tbinA.Location = new System.Drawing.Point(141, 25);
            this.tbinA.Name = "tbinA";
            this.tbinA.ReadOnly = true;
            this.tbinA.Size = new System.Drawing.Size(168, 26);
            this.tbinA.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clcpAB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.clcpAorB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clcpB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.clcpA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(692, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчетная вероятность";
            // 
            // clcpAB
            // 
            this.clcpAB.Location = new System.Drawing.Point(141, 121);
            this.clcpAB.Name = "clcpAB";
            this.clcpAB.ReadOnly = true;
            this.clcpAB.Size = new System.Drawing.Size(168, 26);
            this.clcpAB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "P(AB)";
            // 
            // clcpAorB
            // 
            this.clcpAorB.Location = new System.Drawing.Point(141, 89);
            this.clcpAorB.Name = "clcpAorB";
            this.clcpAorB.ReadOnly = true;
            this.clcpAorB.Size = new System.Drawing.Size(168, 26);
            this.clcpAorB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "P(A+B)";
            // 
            // clcpB
            // 
            this.clcpB.Location = new System.Drawing.Point(141, 57);
            this.clcpB.Name = "clcpB";
            this.clcpB.ReadOnly = true;
            this.clcpB.Size = new System.Drawing.Size(168, 26);
            this.clcpB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "P(B)";
            // 
            // clcpA
            // 
            this.clcpA.Location = new System.Drawing.Point(141, 25);
            this.clcpA.Name = "clcpA";
            this.clcpA.ReadOnly = true;
            this.clcpA.Size = new System.Drawing.Size(168, 26);
            this.clcpA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "P(A)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbErAB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbErAorB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbErB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbErA);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(692, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Относительная погрешность, %";
            // 
            // tbErAB
            // 
            this.tbErAB.Location = new System.Drawing.Point(141, 121);
            this.tbErAB.Name = "tbErAB";
            this.tbErAB.ReadOnly = true;
            this.tbErAB.Size = new System.Drawing.Size(168, 26);
            this.tbErAB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "P(AB)";
            // 
            // tbErAorB
            // 
            this.tbErAorB.Location = new System.Drawing.Point(141, 89);
            this.tbErAorB.Name = "tbErAorB";
            this.tbErAorB.ReadOnly = true;
            this.tbErAorB.Size = new System.Drawing.Size(168, 26);
            this.tbErAorB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "P(A+B)";
            // 
            // tbErB
            // 
            this.tbErB.Location = new System.Drawing.Point(141, 57);
            this.tbErB.Name = "tbErB";
            this.tbErB.ReadOnly = true;
            this.tbErB.Size = new System.Drawing.Size(168, 26);
            this.tbErB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "P(B)";
            // 
            // tbErA
            // 
            this.tbErA.Location = new System.Drawing.Point(141, 25);
            this.tbErA.Name = "tbErA";
            this.tbErA.ReadOnly = true;
            this.tbErA.Size = new System.Drawing.Size(168, 26);
            this.tbErA.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "P(A)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbSqrAB);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbSqrAorB);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbSqrB);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbSqrA);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(692, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 160);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расчетная площадь";
            // 
            // tbSqrAB
            // 
            this.tbSqrAB.Location = new System.Drawing.Point(141, 121);
            this.tbSqrAB.Name = "tbSqrAB";
            this.tbSqrAB.ReadOnly = true;
            this.tbSqrAB.Size = new System.Drawing.Size(168, 26);
            this.tbSqrAB.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "S(AB)";
            // 
            // tbSqrAorB
            // 
            this.tbSqrAorB.Location = new System.Drawing.Point(141, 89);
            this.tbSqrAorB.Name = "tbSqrAorB";
            this.tbSqrAorB.ReadOnly = true;
            this.tbSqrAorB.Size = new System.Drawing.Size(168, 26);
            this.tbSqrAorB.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "S(A+B)";
            // 
            // tbSqrB
            // 
            this.tbSqrB.Location = new System.Drawing.Point(141, 57);
            this.tbSqrB.Name = "tbSqrB";
            this.tbSqrB.ReadOnly = true;
            this.tbSqrB.Size = new System.Drawing.Size(168, 26);
            this.tbSqrB.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "S(B)";
            // 
            // tbSqrA
            // 
            this.tbSqrA.Location = new System.Drawing.Point(141, 25);
            this.tbSqrA.Name = "tbSqrA";
            this.tbSqrA.ReadOnly = true;
            this.tbSqrA.Size = new System.Drawing.Size(168, 26);
            this.tbSqrA.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "S(A)";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(857, 709);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(150, 35);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(692, 709);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(150, 35);
            this.btnModel.TabIndex = 4;
            this.btnModel.Text = "Моделировать";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Enabled = false;
            this.drawPanel.Location = new System.Drawing.Point(13, 12);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(655, 655);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(710, 676);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Точек брошено";
            // 
            // tbPnts
            // 
            this.tbPnts.Location = new System.Drawing.Point(833, 673);
            this.tbPnts.Name = "tbPnts";
            this.tbPnts.ReadOnly = true;
            this.tbPnts.Size = new System.Drawing.Size(168, 26);
            this.tbPnts.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 676);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(655, 69);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 715);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(235, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Не пересчитывать ячейки";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1023, 756);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tbPnts);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Графическая иллюстрация метода Монте-Карло";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbinAB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbinAorB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbinB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbinA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox clcpAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clcpAorB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clcpB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clcpA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbErAB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbErAorB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbErB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbErA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbSqrAB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSqrAorB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSqrB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSqrA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPnts;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}