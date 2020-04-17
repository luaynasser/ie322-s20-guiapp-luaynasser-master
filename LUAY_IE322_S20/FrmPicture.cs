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
    public partial class FrmPicture : Form
    {
        public FrmPicture()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("C:\\Users\\HP\\Pictures\\kau");
        }
    }
}
