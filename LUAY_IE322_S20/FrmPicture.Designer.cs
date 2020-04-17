namespace LUAY_IE322_S20
{
    partial class FrmPicture
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
            this.button1 = new System.Windows.Forms.Button();
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(161, 30);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(491, 317);
            this.PicTry.TabIndex = 1;
            this.PicTry.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(12, 12);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(90, 41);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load Image";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.PicTry);
            this.Controls.Add(this.button1);
            this.Name = "FrmPicture";
            this.Text = "FrmPicture";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button BtnLoad;
    }
}