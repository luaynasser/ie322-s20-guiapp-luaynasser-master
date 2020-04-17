namespace LUAY_IE322_S20
{
    partial class FarmMain
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpBasic = new System.Windows.Forms.GroupBox();
            this.btnChekBox = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.GrpGrapical = new System.Windows.Forms.GroupBox();
            this.btnPictureBox2 = new System.Windows.Forms.Button();
            this.btnPictureBox = new System.Windows.Forms.Button();
            this.btnSelfeApp = new System.Windows.Forms.Button();
            this.btnGroupieApp = new System.Windows.Forms.Button();
            this.GrpMore = new System.Windows.Forms.GroupBox();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnRndomCom = new System.Windows.Forms.Button();
            this.GrpDraw = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.GrpExam = new System.Windows.Forms.GroupBox();
            this.btnJohari = new System.Windows.Forms.Button();
            this.btnABC = new System.Windows.Forms.Button();
            this.btnRobotic = new System.Windows.Forms.Button();
            this.btnManufacturing = new System.Windows.Forms.Button();
            this.GrpMicro = new System.Windows.Forms.GroupBox();
            this.btnArduino = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.GrpBasic.SuspendLayout();
            this.GrpGrapical.SuspendLayout();
            this.GrpMore.SuspendLayout();
            this.GrpDraw.SuspendLayout();
            this.GrpExam.SuspendLayout();
            this.GrpMicro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.textBox2);
            this.grpLogin.Controls.Add(this.textBox1);
            this.grpLogin.Controls.Add(this.LblPassword);
            this.grpLogin.Controls.Add(this.LblUser);
            this.grpLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(267, 230);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            this.grpLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 32);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(6, 74);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(107, 24);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            this.LblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(6, 34);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(120, 24);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "User Name";
            this.LblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(12, 248);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(148, 47);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(1192, 453);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(165, 48);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // GrpBasic
            // 
            this.GrpBasic.Controls.Add(this.btnChekBox);
            this.GrpBasic.Controls.Add(this.btnCombo);
            this.GrpBasic.Controls.Add(this.btnRadio);
            this.GrpBasic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBasic.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GrpBasic.Location = new System.Drawing.Point(308, 12);
            this.GrpBasic.Name = "GrpBasic";
            this.GrpBasic.Size = new System.Drawing.Size(297, 129);
            this.GrpBasic.TabIndex = 3;
            this.GrpBasic.TabStop = false;
            this.GrpBasic.Text = "Basic Controls";
            this.GrpBasic.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnChekBox
            // 
            this.btnChekBox.Location = new System.Drawing.Point(169, 31);
            this.btnChekBox.Name = "btnChekBox";
            this.btnChekBox.Size = new System.Drawing.Size(122, 35);
            this.btnChekBox.TabIndex = 11;
            this.btnChekBox.Text = "ChekBox";
            this.btnChekBox.UseVisualStyleBackColor = true;
            this.btnChekBox.Click += new System.EventHandler(this.btnChekBox_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(83, 83);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(141, 40);
            this.btnCombo.TabIndex = 10;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(6, 31);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(131, 35);
            this.btnRadio.TabIndex = 9;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrpGrapical
            // 
            this.GrpGrapical.Controls.Add(this.btnPictureBox2);
            this.GrpGrapical.Controls.Add(this.btnPictureBox);
            this.GrpGrapical.Controls.Add(this.btnSelfeApp);
            this.GrpGrapical.Controls.Add(this.btnGroupieApp);
            this.GrpGrapical.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpGrapical.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GrpGrapical.Location = new System.Drawing.Point(308, 147);
            this.GrpGrapical.Name = "GrpGrapical";
            this.GrpGrapical.Size = new System.Drawing.Size(297, 111);
            this.GrpGrapical.TabIndex = 4;
            this.GrpGrapical.TabStop = false;
            this.GrpGrapical.Text = "Grapical";
            // 
            // btnPictureBox2
            // 
            this.btnPictureBox2.Location = new System.Drawing.Point(6, 73);
            this.btnPictureBox2.Name = "btnPictureBox2";
            this.btnPictureBox2.Size = new System.Drawing.Size(130, 32);
            this.btnPictureBox2.TabIndex = 17;
            this.btnPictureBox2.Text = "PictureBox2";
            this.btnPictureBox2.UseVisualStyleBackColor = true;
            // 
            // btnPictureBox
            // 
            this.btnPictureBox.Location = new System.Drawing.Point(6, 31);
            this.btnPictureBox.Name = "btnPictureBox";
            this.btnPictureBox.Size = new System.Drawing.Size(131, 32);
            this.btnPictureBox.TabIndex = 12;
            this.btnPictureBox.Text = "PictureBox";
            this.btnPictureBox.UseVisualStyleBackColor = true;
            this.btnPictureBox.Click += new System.EventHandler(this.btnPictureBox_Click);
            // 
            // btnSelfeApp
            // 
            this.btnSelfeApp.Location = new System.Drawing.Point(142, 31);
            this.btnSelfeApp.Name = "btnSelfeApp";
            this.btnSelfeApp.Size = new System.Drawing.Size(149, 32);
            this.btnSelfeApp.TabIndex = 9;
            this.btnSelfeApp.Text = "SelfeApp";
            this.btnSelfeApp.UseVisualStyleBackColor = true;
            // 
            // btnGroupieApp
            // 
            this.btnGroupieApp.Location = new System.Drawing.Point(142, 73);
            this.btnGroupieApp.Name = "btnGroupieApp";
            this.btnGroupieApp.Size = new System.Drawing.Size(149, 32);
            this.btnGroupieApp.TabIndex = 10;
            this.btnGroupieApp.Text = "Groupie App";
            this.btnGroupieApp.UseVisualStyleBackColor = true;
            // 
            // GrpMore
            // 
            this.GrpMore.Controls.Add(this.btnPrograms);
            this.GrpMore.Controls.Add(this.btnRandom);
            this.GrpMore.Controls.Add(this.btnTimer);
            this.GrpMore.Controls.Add(this.btnRndomCom);
            this.GrpMore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GrpMore.Location = new System.Drawing.Point(308, 264);
            this.GrpMore.Name = "GrpMore";
            this.GrpMore.Size = new System.Drawing.Size(297, 124);
            this.GrpMore.TabIndex = 5;
            this.GrpMore.TabStop = false;
            this.GrpMore.Text = "More Control";
            // 
            // btnPrograms
            // 
            this.btnPrograms.Location = new System.Drawing.Point(6, 31);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(118, 32);
            this.btnPrograms.TabIndex = 16;
            this.btnPrograms.Text = "Programs";
            this.btnPrograms.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(6, 86);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(118, 32);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(130, 31);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(161, 32);
            this.btnTimer.TabIndex = 11;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // btnRndomCom
            // 
            this.btnRndomCom.Location = new System.Drawing.Point(130, 86);
            this.btnRndomCom.Name = "btnRndomCom";
            this.btnRndomCom.Size = new System.Drawing.Size(167, 32);
            this.btnRndomCom.TabIndex = 12;
            this.btnRndomCom.Text = "RndomCompo";
            this.btnRndomCom.UseVisualStyleBackColor = true;
            this.btnRndomCom.Click += new System.EventHandler(this.btnRndomCom_Click);
            // 
            // GrpDraw
            // 
            this.GrpDraw.Controls.Add(this.btnDraw);
            this.GrpDraw.Controls.Add(this.btnTalk);
            this.GrpDraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDraw.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GrpDraw.Location = new System.Drawing.Point(308, 406);
            this.GrpDraw.Name = "GrpDraw";
            this.GrpDraw.Size = new System.Drawing.Size(297, 84);
            this.GrpDraw.TabIndex = 6;
            this.GrpDraw.TabStop = false;
            this.GrpDraw.Text = "Draw and Talk";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(6, 31);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(131, 32);
            this.btnDraw.TabIndex = 13;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(143, 31);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(148, 32);
            this.btnTalk.TabIndex = 14;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = true;
            // 
            // GrpExam
            // 
            this.GrpExam.Controls.Add(this.btnJohari);
            this.GrpExam.Controls.Add(this.btnABC);
            this.GrpExam.Controls.Add(this.btnRobotic);
            this.GrpExam.Controls.Add(this.btnManufacturing);
            this.GrpExam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpExam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GrpExam.Location = new System.Drawing.Point(786, 12);
            this.GrpExam.Name = "GrpExam";
            this.GrpExam.Size = new System.Drawing.Size(248, 246);
            this.GrpExam.TabIndex = 7;
            this.GrpExam.TabStop = false;
            this.GrpExam.Text = "Exam Apps";
            // 
            // btnJohari
            // 
            this.btnJohari.Location = new System.Drawing.Point(17, 208);
            this.btnJohari.Name = "btnJohari";
            this.btnJohari.Size = new System.Drawing.Size(216, 29);
            this.btnJohari.TabIndex = 17;
            this.btnJohari.Text = "Johari";
            this.btnJohari.UseVisualStyleBackColor = true;
            // 
            // btnABC
            // 
            this.btnABC.Location = new System.Drawing.Point(17, 151);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(216, 38);
            this.btnABC.TabIndex = 15;
            this.btnABC.Text = "ABC Analysis";
            this.btnABC.UseVisualStyleBackColor = true;
            // 
            // btnRobotic
            // 
            this.btnRobotic.Location = new System.Drawing.Point(17, 95);
            this.btnRobotic.Name = "btnRobotic";
            this.btnRobotic.Size = new System.Drawing.Size(216, 34);
            this.btnRobotic.TabIndex = 6;
            this.btnRobotic.Text = "Robotic Cell";
            this.btnRobotic.UseVisualStyleBackColor = true;
            // 
            // btnManufacturing
            // 
            this.btnManufacturing.Location = new System.Drawing.Point(17, 40);
            this.btnManufacturing.Name = "btnManufacturing";
            this.btnManufacturing.Size = new System.Drawing.Size(216, 37);
            this.btnManufacturing.TabIndex = 5;
            this.btnManufacturing.Text = "Manufacturing Cell";
            this.btnManufacturing.UseVisualStyleBackColor = true;
            // 
            // GrpMicro
            // 
            this.GrpMicro.Controls.Add(this.btnArduino);
            this.GrpMicro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMicro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GrpMicro.Location = new System.Drawing.Point(1122, 12);
            this.GrpMicro.Name = "GrpMicro";
            this.GrpMicro.Size = new System.Drawing.Size(235, 123);
            this.GrpMicro.TabIndex = 8;
            this.GrpMicro.TabStop = false;
            this.GrpMicro.Text = "Micro Conteroler";
            // 
            // btnArduino
            // 
            this.btnArduino.Location = new System.Drawing.Point(26, 41);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(191, 57);
            this.btnArduino.TabIndex = 9;
            this.btnArduino.Text = "Arduino";
            this.btnArduino.UseVisualStyleBackColor = true;
            // 
            // FarmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1369, 513);
            this.Controls.Add(this.GrpMicro);
            this.Controls.Add(this.GrpExam);
            this.Controls.Add(this.GrpDraw);
            this.Controls.Add(this.GrpMore);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.GrpGrapical);
            this.Controls.Add(this.GrpBasic);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.grpLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FarmMain";
            this.Text = "IE322_S20_KAU";
            this.Load += new System.EventHandler(this.FarmMain_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.GrpBasic.ResumeLayout(false);
            this.GrpGrapical.ResumeLayout(false);
            this.GrpMore.ResumeLayout(false);
            this.GrpDraw.ResumeLayout(false);
            this.GrpExam.ResumeLayout(false);
            this.GrpMicro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpBasic;
        private System.Windows.Forms.GroupBox GrpGrapical;
        private System.Windows.Forms.GroupBox GrpMore;
        private System.Windows.Forms.GroupBox GrpDraw;
        private System.Windows.Forms.GroupBox GrpExam;
        private System.Windows.Forms.GroupBox GrpMicro;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnChekBox;
        private System.Windows.Forms.Button btnPictureBox;
        private System.Windows.Forms.Button btnRobotic;
        private System.Windows.Forms.Button btnManufacturing;
        private System.Windows.Forms.Button btnPictureBox2;
        private System.Windows.Forms.Button btnSelfeApp;
        private System.Windows.Forms.Button btnGroupieApp;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnRndomCom;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnJohari;
        private System.Windows.Forms.Button btnArduino;
    }
}

