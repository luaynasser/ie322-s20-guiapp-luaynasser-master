using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUAY_IE322_S20
{
    public partial class FarmMain : Form
    {
        string username = "Atif";
        string myPassword = "1234";

        int attempt = 1;
        int MaxAttempts = 3;
        public FarmMain()
        {
            InitializeComponent();
        }

        private void FarmMain_Load(object sender, EventArgs e)
        {
           //btnLoginenabled= false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            while (attempt <= MaxAttempts)
            {
                if (textBox2.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (textBox1.Text != "1234")
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        BtnLogin.Text = "Logout";

                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                frmRadio frm = new frmRadio();
                frm.ShowDialog();
            }
        }

        private void TxtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void btnChekBox_Click(object sender, EventArgs e)
        {
            frmCheckbox frm = new frmCheckbox();
            frm.ShowDialog();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            femRandom frm = new femRandom();
            frm.ShowDialog();
        }

        private void btnRndomCom_Click(object sender, EventArgs e)
        {
            frmRandomCompo frm = new frmRandomCompo();
            frm.ShowDialog();
        }

        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPicture frm = new FrmPicture();
            frm.ShowDialog();
        }
    }


}
    


