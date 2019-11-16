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
            this.lblAdSoyad.Location = new System.Drawing.Point(317, 13);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "label1";
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdSoyad);
            this.Name = "frmOyun";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Timer tmrForm;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}

