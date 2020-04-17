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
    public partial class frmCheckbox : Form
    {
        public frmCheckbox()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if (ChkDounat.Checked == true)
            {
                msg = msg + " " + ChkDounat.Text;
            }
            if(ChkBrownie.Checked == true)
            {
                msg = msg + " " + ChkBrownie.Text;
            }
            if(msg.Length > 0)
            {
                MessageBox.Show(msg + " ordered. ");
            }
               else
            {
                MessageBox.Show(" Nothing Ordered. ");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
