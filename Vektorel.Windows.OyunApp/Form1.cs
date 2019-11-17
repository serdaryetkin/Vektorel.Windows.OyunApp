using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vektorel.Windows.OyunApp
{
    public partial class frmOyun : Form
    {
        Random rnd = new Random();
        int skor = 0;
        int kalan = 5;
        private frmGiris frmGiris;
        List<int> skorlar = new List<int>();
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
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Size.Width - pnlBilgi.Size.Height), rnd.Next(this.ClientSize.Height - btn.Size.Height));
            btn.Text = rnd.Next(10, 100).ToString();
            btn.Click += Btn_Click;
            btn.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            skor += int.Parse(btn.Text);
            this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            btn.Dispose();
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrForm.Start();
            tmrButton.Start();
            lblAdSoyad.Text = frmGiris.txtad.Text.Trim() + " " + frmGiris.txtSoyad.Text.Trim().ToUpper();

        }

        private void TmrForm_Tick(object sender, EventArgs e)
        {
            kalan--;
            lblSüre.Text = kalan.ToString();
            lblSkor.Text = skor.ToString();


            if (kalan == 0)
            {

                tmrForm.Stop();
                tmrButton.Stop();
                lstSkorlar.Text = skorlar.ToString();
                DialogResult cvp = MessageBox.Show($"{frmGiris.txtad.Text} {frmGiris.txtSoyad.Text}\nOyun bitti!\nToplam Puan:{skor}\nYeniden oynamak ister misiniz?", "Yeniden Oyna", MessageBoxButtons.YesNo);
                skorlar.Add(skor);
                lstSkorlar.Items.Add(skor);
                if (cvp == DialogResult.Yes)
                {
                    YenidenBaslat();
                }
                else
                {
                    int max = 0;
                    foreach (int item in lstSkorlar.Items)
                    {
                        if (item > max)
                        {
                            max = item;
                        }
                    }
                    MessageBox.Show($"{frmGiris.txtad.Text} {frmGiris.txtSoyad.Text}\nOyun bitti!\nEn Yüksek Puan:{max}");
                }
            }
        }

        void YenidenBaslat()
        {
            kalan = 5;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {
                    this.Controls[i].Dispose();
                    i--;
                } 
               
            }

            skor = 0;
            tmrForm.Start();
            tmrButton.Start();
        }



        private void FrmOyun_Resize(object sender, EventArgs e)
        {
            pnlBilgi.Height = this.ClientSize.Height;
            pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Size.Width, 0);
        }
    }
}
