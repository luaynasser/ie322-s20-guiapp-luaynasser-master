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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();

            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("friday");
            CmbDays.Items.Add("Saturday");

        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow1_Click(object sender, EventArgs e)
        {        //using Method1
            

            MessageBox.Show(CmbDays.Text);

        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");

            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
