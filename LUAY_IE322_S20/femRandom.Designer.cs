namespace LUAY_IE322_S20
{
    partial class femRandom
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateRandomColor = new System.Windows.Forms.Button();
            this.labelRGB = new System.Windows.Forms.Label();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(677, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 53);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateRandomColor
            // 
            this.btnGenerateRandomColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGenerateRandomColor.Location = new System.Drawing.Point(179, 54);
            this.btnGenerateRandomColor.Name = "btnGenerateRandomColor";
            this.btnGenerateRandomColor.Size = new System.Drawing.Size(445, 78);
            this.btnGenerateRandomColor.TabIndex = 1;
            this.btnGenerateRandomColor.Text = "Generate Random Color";
            this.btnGenerateRandomColor.UseVisualStyleBackColor = false;
            this.btnGenerateRandomColor.Click += new System.EventHandler(this.btnGenerateRandomColor_Click);
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(381, 161);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(39, 17);
            this.labelRGB.TabIndex = 4;
            this.labelRGB.Text = "r-g-b";
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(95, 259);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(263, 63);
            this.BtnRandomNumber.TabIndex = 5;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // femRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.btnGenerateRandomColor);
            this.Controls.Add(this.btnBack);
            this.Name = "femRandom";
            this.Text = "femRandom";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.femRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateRandomColor;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.Button BtnRandomNumber;
    }
}