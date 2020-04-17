namespace LUAY_IE322_S20
{
    partial class frmRadio
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
            this.btnReset = new System.Windows.Forms.Button();
            this.RdoRed = new System.Windows.Forms.RadioButton();
            this.RdoGreen = new System.Windows.Forms.RadioButton();
            this.RdoYellow = new System.Windows.Forms.RadioButton();
            this.grpRdo = new System.Windows.Forms.GroupBox();
            this.RdoYellow2 = new System.Windows.Forms.RadioButton();
            this.RdoBlue2 = new System.Windows.Forms.RadioButton();
            this.RdoGreen2 = new System.Windows.Forms.RadioButton();
            this.RdoRed2 = new System.Windows.Forms.RadioButton();
            this.RdoBlue = new System.Windows.Forms.RadioButton();
            this.BtnBack = new System.Windows.Forms.Button();
            this.grpRdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(319, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RdoRed
            // 
            this.RdoRed.AutoSize = true;
            this.RdoRed.Location = new System.Drawing.Point(184, 123);
            this.RdoRed.Name = "RdoRed";
            this.RdoRed.Size = new System.Drawing.Size(53, 21);
            this.RdoRed.TabIndex = 1;
            this.RdoRed.TabStop = true;
            this.RdoRed.Text = "Red";
            this.RdoRed.UseVisualStyleBackColor = true;
            this.RdoRed.CheckedChanged += new System.EventHandler(this.RdoRed_CheckedChanged);
            // 
            // RdoGreen
            // 
            this.RdoGreen.AutoSize = true;
            this.RdoGreen.Location = new System.Drawing.Point(184, 212);
            this.RdoGreen.Name = "RdoGreen";
            this.RdoGreen.Size = new System.Drawing.Size(65, 21);
            this.RdoGreen.TabIndex = 2;
            this.RdoGreen.TabStop = true;
            this.RdoGreen.Text = "Green";
            this.RdoGreen.UseVisualStyleBackColor = true;
            this.RdoGreen.CheckedChanged += new System.EventHandler(this.RdoGreen_CheckedChanged);
            // 
            // RdoYellow
            // 
            this.RdoYellow.AutoSize = true;
            this.RdoYellow.Location = new System.Drawing.Point(184, 328);
            this.RdoYellow.Name = "RdoYellow";
            this.RdoYellow.Size = new System.Drawing.Size(66, 21);
            this.RdoYellow.TabIndex = 3;
            this.RdoYellow.TabStop = true;
            this.RdoYellow.Text = "Yellow";
            this.RdoYellow.UseVisualStyleBackColor = true;
            this.RdoYellow.CheckedChanged += new System.EventHandler(this.RdoYellow_CheckedChanged);
            // 
            // grpRdo
            // 
            this.grpRdo.Controls.Add(this.RdoYellow2);
            this.grpRdo.Controls.Add(this.RdoBlue2);
            this.grpRdo.Controls.Add(this.RdoGreen2);
            this.grpRdo.Controls.Add(this.RdoRed2);
            this.grpRdo.Location = new System.Drawing.Point(411, 123);
            this.grpRdo.Name = "grpRdo";
            this.grpRdo.Size = new System.Drawing.Size(323, 232);
            this.grpRdo.TabIndex = 4;
            this.grpRdo.TabStop = false;
            this.grpRdo.Text = "GroupRadio";
            // 
            // RdoYellow2
            // 
            this.RdoYellow2.AutoSize = true;
            this.RdoYellow2.Location = new System.Drawing.Point(129, 205);
            this.RdoYellow2.Name = "RdoYellow2";
            this.RdoYellow2.Size = new System.Drawing.Size(66, 21);
            this.RdoYellow2.TabIndex = 3;
            this.RdoYellow2.TabStop = true;
            this.RdoYellow2.Text = "Yellow";
            this.RdoYellow2.UseVisualStyleBackColor = true;
            this.RdoYellow2.CheckedChanged += new System.EventHandler(this.RdoYellow2_CheckedChanged);
            // 
            // RdoBlue2
            // 
            this.RdoBlue2.AutoSize = true;
            this.RdoBlue2.Location = new System.Drawing.Point(129, 154);
            this.RdoBlue2.Name = "RdoBlue2";
            this.RdoBlue2.Size = new System.Drawing.Size(54, 21);
            this.RdoBlue2.TabIndex = 2;
            this.RdoBlue2.TabStop = true;
            this.RdoBlue2.Text = "Blue";
            this.RdoBlue2.UseVisualStyleBackColor = true;
            this.RdoBlue2.CheckedChanged += new System.EventHandler(this.RdoBlue2_CheckedChanged);
            // 
            // RdoGreen2
            // 
            this.RdoGreen2.AutoSize = true;
            this.RdoGreen2.Location = new System.Drawing.Point(129, 89);
            this.RdoGreen2.Name = "RdoGreen2";
            this.RdoGreen2.Size = new System.Drawing.Size(65, 21);
            this.RdoGreen2.TabIndex = 1;
            this.RdoGreen2.TabStop = true;
            this.RdoGreen2.Text = "Green";
            this.RdoGreen2.UseVisualStyleBackColor = true;
            this.RdoGreen2.CheckedChanged += new System.EventHandler(this.RdoGreen2_CheckedChanged);
            // 
            // RdoRed2
            // 
            this.RdoRed2.AutoSize = true;
            this.RdoRed2.Location = new System.Drawing.Point(129, 36);
            this.RdoRed2.Name = "RdoRed2";
            this.RdoRed2.Size = new System.Drawing.Size(53, 21);
            this.RdoRed2.TabIndex = 0;
            this.RdoRed2.TabStop = true;
            this.RdoRed2.Text = "Red";
            this.RdoRed2.UseVisualStyleBackColor = true;
            // 
            // RdoBlue
            // 
            this.RdoBlue.AutoSize = true;
            this.RdoBlue.Location = new System.Drawing.Point(184, 277);
            this.RdoBlue.Name = "RdoBlue";
            this.RdoBlue.Size = new System.Drawing.Size(54, 21);
            this.RdoBlue.TabIndex = 5;
            this.RdoBlue.TabStop = true;
            this.RdoBlue.Text = "Blue";
            this.RdoBlue.UseVisualStyleBackColor = true;
            this.RdoBlue.CheckedChanged += new System.EventHandler(this.RdoBlue_CheckedChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(658, 404);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(130, 34);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.RdoBlue);
            this.Controls.Add(this.grpRdo);
            this.Controls.Add(this.RdoYellow);
            this.Controls.Add(this.RdoGreen);
            this.Controls.Add(this.RdoRed);
            this.Controls.Add(this.btnReset);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.grpRdo.ResumeLayout(false);
            this.grpRdo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton RdoRed;
        private System.Windows.Forms.RadioButton RdoGreen;
        private System.Windows.Forms.RadioButton RdoYellow;
        private System.Windows.Forms.GroupBox grpRdo;
        private System.Windows.Forms.RadioButton RdoYellow2;
        private System.Windows.Forms.RadioButton RdoBlue2;
        private System.Windows.Forms.RadioButton RdoGreen2;
        private System.Windows.Forms.RadioButton RdoRed2;
        private System.Windows.Forms.RadioButton RdoBlue;
        private System.Windows.Forms.Button BtnBack;
    }
}