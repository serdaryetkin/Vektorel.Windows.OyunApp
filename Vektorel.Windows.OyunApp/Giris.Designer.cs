namespace Vektorel.Windows.OyunApp
{
    partial class frmGiris
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grpSeviye = new System.Windows.Forms.GroupBox();
            this.rdKolay = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdZor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(94, 19);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 0;
            
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(298, 310);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(200, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Location = new System.Drawing.Point(298, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(10, 51);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 13);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyadınız";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(7, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 13);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Adınız";
            // 
            // grpSeviye
            // 
            this.grpSeviye.Controls.Add(this.rdZor);
            this.grpSeviye.Controls.Add(this.rdOrta);
            this.grpSeviye.Controls.Add(this.rdKolay);
            this.grpSeviye.Location = new System.Drawing.Point(298, 166);
            this.grpSeviye.Name = "grpSeviye";
            this.grpSeviye.Size = new System.Drawing.Size(200, 100);
            this.grpSeviye.TabIndex = 4;
            this.grpSeviye.TabStop = false;
            this.grpSeviye.Text = "Seviye İşlemleri";
            // 
            // rdKolay
            // 
            this.rdKolay.AutoSize = true;
            this.rdKolay.Location = new System.Drawing.Point(64, 19);
            this.rdKolay.Name = "rdKolay";
            this.rdKolay.Size = new System.Drawing.Size(51, 17);
            this.rdKolay.TabIndex = 0;
            this.rdKolay.TabStop = true;
            this.rdKolay.Text = "Kolay";
            this.rdKolay.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(64, 42);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(45, 17);
            this.rdOrta.TabIndex = 1;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdZor
            // 
            this.rdZor.AutoSize = true;
            this.rdZor.Location = new System.Drawing.Point(64, 65);
            this.rdZor.Name = "rdZor";
            this.rdZor.Size = new System.Drawing.Size(41, 17);
            this.rdZor.TabIndex = 2;
            this.rdZor.TabStop = true;
            this.rdZor.Text = "Zor";
            this.rdZor.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSeviye);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGiris);
            this.Name = "frmGiris";
            this.Text = "Giris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSeviye.ResumeLayout(false);
            this.grpSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grpSeviye;
        public System.Windows.Forms.RadioButton rdZor;
        public System.Windows.Forms.RadioButton rdOrta;
        public System.Windows.Forms.RadioButton rdKolay;
    }
}