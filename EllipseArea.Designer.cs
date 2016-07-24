namespace MonteCarlo
{
    partial class EllipseArea
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cntrlB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cntrlY1 = new System.Windows.Forms.NumericUpDown();
            this.cntrlA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cntrlX1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntrlB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cntrlY1);
            this.groupBox1.Controls.Add(this.cntrlA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cntrlX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 323);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cntrlB
            // 
            this.cntrlB.Location = new System.Drawing.Point(41, 118);
            this.cntrlB.Name = "cntrlB";
            this.cntrlB.Size = new System.Drawing.Size(65, 26);
            this.cntrlB.TabIndex = 1;
            this.cntrlB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "b";
            // 
            // cntrlY1
            // 
            this.cntrlY1.Location = new System.Drawing.Point(41, 52);
            this.cntrlY1.Name = "cntrlY1";
            this.cntrlY1.Size = new System.Drawing.Size(65, 26);
            this.cntrlY1.TabIndex = 1;
            this.cntrlY1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cntrlA
            // 
            this.cntrlA.Location = new System.Drawing.Point(41, 86);
            this.cntrlA.Name = "cntrlA";
            this.cntrlA.Size = new System.Drawing.Size(65, 26);
            this.cntrlA.TabIndex = 1;
            this.cntrlA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "a";
            // 
            // cntrlX1
            // 
            this.cntrlX1.Location = new System.Drawing.Point(41, 20);
            this.cntrlX1.Name = "cntrlX1";
            this.cntrlX1.Size = new System.Drawing.Size(65, 26);
            this.cntrlX1.TabIndex = 1;
            this.cntrlX1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MonteCarlo.Properties.Resources.ellps;
            this.pictureBox1.Location = new System.Drawing.Point(163, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EllipseArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EllipseArea";
            this.Size = new System.Drawing.Size(469, 340);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown cntrlB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cntrlY1;
        private System.Windows.Forms.NumericUpDown cntrlA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cntrlX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
