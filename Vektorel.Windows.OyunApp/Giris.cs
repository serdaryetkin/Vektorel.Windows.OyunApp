using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.OyunApp
{
    public partial class frmGiris : Form
    {

        public frmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            frmOyun frm = new frmOyun(this);
            frm.Show();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
