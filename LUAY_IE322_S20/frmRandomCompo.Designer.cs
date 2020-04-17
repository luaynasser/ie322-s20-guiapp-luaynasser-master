namespace LUAY_IE322_S20
{
    partial class frmRandomCompo
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
            this.BtnRest = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.RdoGreater = new System.Windows.Forms.RadioButton();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.RdoLess = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RdoLess2 = new System.Windows.Forms.RadioButton();
            this.RdoGreater2 = new System.Windows.Forms.RadioButton();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnResst2 = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRest
            // 
            this.BtnRest.Location = new System.Drawing.Point(179, 211);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(75, 23);
            this.BtnRest.TabIndex = 0;
            this.BtnRest.Text = "Reset";
            this.BtnRest.UseVisualStyleBackColor = true;
            this.BtnRest.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(6, 37);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ComboBox1.TabIndex = 1;
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.RdoGreater);
            this.grpbox.Controls.Add(this.BtnRest);
            this.grpbox.Controls.Add(this.BtnGenerate);
            this.grpbox.Controls.Add(this.RdoLess);
            this.grpbox.Controls.Add(this.ComboBox1);
            this.grpbox.Location = new System.Drawing.Point(37, 30);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(296, 254);
            this.grpbox.TabIndex = 2;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Quiz03_AAF19";
            // 
            // RdoGreater
            // 
            this.RdoGreater.AutoSize = true;
            this.RdoGreater.Location = new System.Drawing.Point(162, 150);
            this.RdoGreater.Name = "RdoGreater";
            this.RdoGreater.Size = new System.Drawing.Size(134, 21);
            this.RdoGreater.TabIndex = 4;
            this.RdoGreater.TabStop = true;
            this.RdoGreater.Text = "Greater than 500";
            this.RdoGreater.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(179, 38);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 5;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // RdoLess
            // 
            this.RdoLess.AutoSize = true;
            this.RdoLess.Location = new System.Drawing.Point(162, 86);
            this.RdoLess.Name = "RdoLess";
            this.RdoLess.Size = new System.Drawing.Size(115, 21);
            this.RdoLess.TabIndex = 3;
            this.RdoLess.TabStop = true;
            this.RdoLess.Text = "Less than 500";
            this.RdoLess.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RdoLess2);
            this.groupBox1.Controls.Add(this.RdoGreater2);
            this.groupBox1.Controls.Add(this.ComboBox2);
            this.groupBox1.Controls.Add(this.BtnResst2);
            this.groupBox1.Controls.Add(this.BtnGenerate2);
            this.groupBox1.Location = new System.Drawing.Point(411, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_EAF19";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count:";
            // 
            // RdoLess2
            // 
            this.RdoLess2.AutoSize = true;
            this.RdoLess2.Location = new System.Drawing.Point(183, 86);
            this.RdoLess2.Name = "RdoLess2";
            this.RdoLess2.Size = new System.Drawing.Size(115, 21);
            this.RdoLess2.TabIndex = 4;
            this.RdoLess2.TabStop = true;
            this.RdoLess2.Text = "Less than 500";
            this.RdoLess2.UseVisualStyleBackColor = true;
            // 
            // RdoGreater2
            // 
            this.RdoGreater2.AutoSize = true;
            this.RdoGreater2.Location = new System.Drawing.Point(183, 138);
            this.RdoGreater2.Name = "RdoGreater2";
            this.RdoGreater2.Size = new System.Drawing.Size(134, 21);
            this.RdoGreater2.TabIndex = 3;
            this.RdoGreater2.TabStop = true;
            this.RdoGreater2.Text = "Greater than 500";
            this.RdoGreater2.UseVisualStyleBackColor = true;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(6, 38);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 24);
            this.ComboBox2.TabIndex = 2;
            // 
            // BtnResst2
            // 
            this.BtnResst2.Location = new System.Drawing.Point(200, 211);
            this.BtnResst2.Name = "BtnResst2";
            this.BtnResst2.Size = new System.Drawing.Size(75, 23);
            this.BtnResst2.TabIndex = 1;
            this.BtnResst2.Text = "Reset";
            this.BtnResst2.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(200, 37);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate2.TabIndex = 0;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(536, 387);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmRandomCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox);
            this.Name = "frmRandomCompo";
            this.Text = "frmRandomCompo";
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.RadioButton RdoGreater;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.RadioButton RdoLess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoLess2;
        private System.Windows.Forms.RadioButton RdoGreater2;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.Button BtnResst2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
    }
}