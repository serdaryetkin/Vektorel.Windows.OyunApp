using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vektorel.Windows.OyunApp
{
    public partial class frmOyun : Form
    {
        Random rnd = new Random();
        int toplam = 0;
        int kalan = 10;
        private frmGiris frmGiris;
        List<int> list = new List<int>();
        public frmOyun()
        {
            InitializeComponent();
        }

        public frmOyun(frmGiris frmGiris)
        {
            InitializeComponent();
            this.frmGiris = frmGiris;
        }

        private void TmrButton_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Size.Width), rnd.Next(this.ClientSize.Height - btn.Size.Height));
            btn.Text = rnd.Next(10, 100).ToString();
            btn.Click += Btn_Click;
            btn.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            btn.Dispose();
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrForm.Start();
            tmrButton.Start();
            lblAdSoyad.Text = frmGiris.txtad.Text + " " + frmGiris.txtSoyad.Text;
        }

        private void TmrForm_Tick(object sender, EventArgs e)
        {
            kalan--;
            this.Text = kalan.ToString();
            if (kalan == 0)
            {
                list.Add(toplam);
                tmrForm.Stop();
                tmrButton.Stop();
                MessageBox.Show($"{frmGiris.txtad.Text} {frmGiris.txtSoyad.Text}\nOyun bitti!\nToplam Puan:{toplam}");
                DialogResult cvp = MessageBox.Show("Yeniden oynamak ister misiniz?", "Yeniden Oyna", MessageBoxButtons.YesNo);
                
                if (cvp==DialogResult.Yes)
                {
                    kalan = 10;
                }
            }
        }
    }
}
