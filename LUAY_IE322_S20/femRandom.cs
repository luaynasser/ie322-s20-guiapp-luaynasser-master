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
    public partial class femRandom : Form
    {
        Random y = new Random();
        

        public femRandom()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void femRandom_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnRandomNumber_Click(object sender, EventArgs e)
        {
            BtnRandomNumber.Text = Convert.ToString(y.Next(1, 10));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGenerateRandomColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            labelRGB.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            btnGenerateRandomColor.BackColor = Color.FromArgb(r, g, b);
        }
    }
} //kkjiuh
