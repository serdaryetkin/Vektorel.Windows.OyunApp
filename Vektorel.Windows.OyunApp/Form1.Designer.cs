namespace Vektorel.Windows.OyunApp
{
    partial class frmOyun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.tmrForm = new System.Windows.Forms.Timer(this.components);
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblSüre = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lstSkorlar = new System.Windows.Forms.ListBox();
            this.pnlBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 1000;
            this.tmrButton.Tick += new System.EventHandler(this.TmrButton_Tick);
            // 
            // tmrForm
            // 
            this.tmrForm.Interval = 1000;
            this.tmrForm.Tick += new System.EventHandler(this.TmrForm_Tick);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(3, 22);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(51, 16);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "label1";
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBilgi.Controls.Add(this.lstSkorlar);
            this.pnlBilgi.Controls.Add(this.lblSüre);
            this.pnlBilgi.Controls.Add(this.lblSkor);
            this.pnlBilgi.Controls.Add(this.lblAdSoyad);
            this.pnlBilgi.Location = new System.Drawing.Point(680, -2);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(120, 305);
            this.pnlBilgi.TabIndex = 1;
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSüre.Location = new System.Drawing.Point(1, 100);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(64, 29);
            this.lblSüre.TabIndex = 2;
            this.lblSüre.Text = "Süre";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(3, 62);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(51, 20);
            this.lblSkor.TabIndex = 3;
            this.lblSkor.Text = "label2";
            // 
            // lstSkorlar
            // 
            this.lstSkorlar.FormattingEnabled = true;
            this.lstSkorlar.Location = new System.Drawing.Point(3, 162);
            this.lstSkorlar.Name = "lstSkorlar";
            this.lstSkorlar.Size = new System.Drawing.Size(105, 108);
            this.lstSkorlar.TabIndex = 4;
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.pnlBilgi);
            this.Name = "frmOyun";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.Resize += new System.EventHandler(this.FrmOyun_Resize);
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Timer tmrForm;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.ListBox lstSkorlar;
    }
}

