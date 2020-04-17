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
    public partial class frmRandomCompo : Form
    {
        public frmRandomCompo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            ComboBox2.ResetText();
            ComboBox2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                ComboBox2.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ComboBox1.ResetText();
            ComboBox1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 500) - 1; i++)
            {
                ComboBox2.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
