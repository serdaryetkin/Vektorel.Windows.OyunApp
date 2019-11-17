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
        public enum Seviye
        {
            Kolay,
            Orta,
            Zor
        }
        public frmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            Seviye seviye;
            if (rdKolay.Checked)
            {
                seviye = Seviye.Kolay;
            }
            else if (rdOrta.Checked)
            {

                seviye = Seviye.Orta;
            }
            else
            {
                seviye = Seviye.Zor;
            }
            frmOyun frm = new frmOyun(this);
            frm.Show();
        }

        
    }
}
