namespace LUAY_IE322_S20
{
    partial class frmCheckbox
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
            this.btnShow = new System.Windows.Forms.Button();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.ChkDounat = new System.Windows.Forms.CheckBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(285, 26);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 43);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(285, 114);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(69, 21);
            this.ChkCoffee.TabIndex = 1;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // ChkDounat
            // 
            this.ChkDounat.AutoSize = true;
            this.ChkDounat.Location = new System.Drawing.Point(285, 180);
            this.ChkDounat.Name = "ChkDounat";
            this.ChkDounat.Size = new System.Drawing.Size(76, 21);
            this.ChkDounat.TabIndex = 2;
            this.ChkDounat.Text = "Dounat";
            this.ChkDounat.UseVisualStyleBackColor = true;
            this.ChkDounat.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(285, 271);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(78, 21);
            this.ChkBrownie.TabIndex = 3;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            this.ChkBrownie.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(681, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ChkBrownie);
            this.Controls.Add(this.ChkDounat);
            this.Controls.Add(this.ChkCoffee);
            this.Controls.Add(this.btnShow);
            this.Name = "frmCheckbox";
            this.Text = "frmCheckbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.CheckBox ChkDounat;
        private System.Windows.Forms.CheckBox ChkBrownie;
        private System.Windows.Forms.Button btnBack;
    }
}