namespace IMCApp
{
    partial class Form1
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
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblestat = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.cmdIMC = new System.Windows.Forms.Button();
            this.cmdrespes = new System.Windows.Forms.Button();
            this.lbltotimc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblpeso.Location = new System.Drawing.Point(82, 74);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(34, 13);
            this.lblpeso.TabIndex = 0;
            this.lblpeso.Text = "Peso:";
            // 
            // lblestat
            // 
            this.lblestat.AutoSize = true;
            this.lblestat.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblestat.Location = new System.Drawing.Point(82, 141);
            this.lblestat.Name = "lblestat";
            this.lblestat.Size = new System.Drawing.Size(49, 13);
            this.lblestat.TabIndex = 1;
            this.lblestat.Text = "Estatura:";
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(183, 71);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(105, 20);
            this.txtval1.TabIndex = 2;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(183, 138);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(103, 20);
            this.txtval2.TabIndex = 3;
            // 
            // cmdIMC
            // 
            this.cmdIMC.BackColor = System.Drawing.Color.IndianRed;
            this.cmdIMC.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cmdIMC.Location = new System.Drawing.Point(108, 283);
            this.cmdIMC.Name = "cmdIMC";
            this.cmdIMC.Size = new System.Drawing.Size(121, 39);
            this.cmdIMC.TabIndex = 4;
            this.cmdIMC.Text = "Resultado IMC";
            this.cmdIMC.UseVisualStyleBackColor = false;
            this.cmdIMC.Click += new System.EventHandler(this.cmdIMC_Click);
            // 
            // cmdrespes
            // 
            this.cmdrespes.BackColor = System.Drawing.Color.IndianRed;
            this.cmdrespes.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cmdrespes.Location = new System.Drawing.Point(358, 281);
            this.cmdrespes.Name = "cmdrespes";
            this.cmdrespes.Size = new System.Drawing.Size(122, 40);
            this.cmdrespes.TabIndex = 5;
            this.cmdrespes.Text = "Resultado Peso";
            this.cmdrespes.UseVisualStyleBackColor = false;
            this.cmdrespes.Click += new System.EventHandler(this.cmdrespes_Click);
            // 
            // lbltotimc
            // 
            this.lbltotimc.AutoSize = true;
            this.lbltotimc.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbltotimc.Location = new System.Drawing.Point(133, 246);
            this.lbltotimc.Name = "lbltotimc";
            this.lbltotimc.Size = new System.Drawing.Size(13, 13);
            this.lbltotimc.TabIndex = 6;
            this.lbltotimc.Text = "0";
            this.lbltotimc.Click += new System.EventHandler(this.lbltotimc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMCApp.Properties.Resources.IMC;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(571, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltotimc);
            this.Controls.Add(this.cmdrespes);
            this.Controls.Add(this.cmdIMC);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.lblestat);
            this.Controls.Add(this.lblpeso);
            this.Name = "Form1";
            this.Text = "IMC App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblestat;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.Button cmdIMC;
        private System.Windows.Forms.Button cmdrespes;
        private System.Windows.Forms.Label lbltotimc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

