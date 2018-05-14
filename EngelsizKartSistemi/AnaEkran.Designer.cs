namespace EngelsizKartSistemi
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.btnKullaniciEkrani = new System.Windows.Forms.Button();
            this.btnCagriEkrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciEkrani
            // 
            this.btnKullaniciEkrani.BackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciEkrani.BackgroundImage = global::EngelsizKartSistemi.Resource2.kullanici;
            this.btnKullaniciEkrani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKullaniciEkrani.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKullaniciEkrani.FlatAppearance.BorderSize = 0;
            this.btnKullaniciEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciEkrani.Location = new System.Drawing.Point(0, 0);
            this.btnKullaniciEkrani.Name = "btnKullaniciEkrani";
            this.btnKullaniciEkrani.Size = new System.Drawing.Size(200, 330);
            this.btnKullaniciEkrani.TabIndex = 0;
            this.btnKullaniciEkrani.UseVisualStyleBackColor = false;
            this.btnKullaniciEkrani.Click += new System.EventHandler(this.btnKullaniciEkrani_Click);
            // 
            // btnCagriEkrani
            // 
            this.btnCagriEkrani.BackColor = System.Drawing.Color.Transparent;
            this.btnCagriEkrani.BackgroundImage = global::EngelsizKartSistemi.Resource2.kullaniciServisi;
            this.btnCagriEkrani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCagriEkrani.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCagriEkrani.FlatAppearance.BorderSize = 0;
            this.btnCagriEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCagriEkrani.Location = new System.Drawing.Point(222, 0);
            this.btnCagriEkrani.Name = "btnCagriEkrani";
            this.btnCagriEkrani.Size = new System.Drawing.Size(228, 330);
            this.btnCagriEkrani.TabIndex = 1;
            this.btnCagriEkrani.UseVisualStyleBackColor = false;
            this.btnCagriEkrani.Click += new System.EventHandler(this.btnCagriEkrani_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EngelsizKartSistemi.Resource2.arkaplan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.btnCagriEkrani);
            this.Controls.Add(this.btnKullaniciEkrani);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkrani;
        private System.Windows.Forms.Button btnCagriEkrani;
    }
}