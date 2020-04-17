namespace LUAY_IE322_S20
{
    partial class frmCombo
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
            this.btnShow1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(85, 24);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(129, 60);
            this.btnShow1.TabIndex = 0;
            this.btnShow1.Text = "Show Selected Method1";
            this.btnShow1.UseVisualStyleBackColor = true;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(699, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(223, 24);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(134, 60);
            this.btnShow2.TabIndex = 2;
            this.btnShow2.Text = "Show Selected Method2";
            this.btnShow2.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(272, 294);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(139, 60);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Remove by Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(617, 197);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(147, 101);
            this.btnRemove2.TabIndex = 4;
            this.btnRemove2.Text = "Remove 2nd last item";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(617, 45);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(147, 116);
            this.btnRemove1.TabIndex = 5;
            this.btnRemove1.Text = "Remove 1ast item";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(66, 294);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(129, 60);
            this.btnIndex.TabIndex = 6;
            this.btnIndex.Text = "Remove by Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(194, 137);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(163, 24);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShow1);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label label1;
    }
}