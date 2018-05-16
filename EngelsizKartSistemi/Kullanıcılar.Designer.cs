namespace EngelsizKartSistemi
{
    partial class Kullanıcılar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcılar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnKullaniciAyar = new System.Windows.Forms.Button();
            this.pnlKullaniciBilgi = new System.Windows.Forms.Panel();
            this.pnlKullaniciEkle = new System.Windows.Forms.Panel();
            this.txt_kartID = new System.Windows.Forms.TextBox();
            this.lbl_kartID = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBoxYakin = new System.Windows.Forms.GroupBox();
            this.lblYakinTelefon = new System.Windows.Forms.Label();
            this.lblYakinSoyad = new System.Windows.Forms.Label();
            this.tbYakinTelefon = new System.Windows.Forms.TextBox();
            this.lblYakinAd = new System.Windows.Forms.Label();
            this.tbYakinAd = new System.Windows.Forms.TextBox();
            this.tbYakinSoyad = new System.Windows.Forms.TextBox();
            this.groupBoxKullanici = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKullaniciEkleTc = new System.Windows.Forms.TextBox();
            this.tbKullaniciTelefon = new System.Windows.Forms.TextBox();
            this.lblKulliniTelefon = new System.Windows.Forms.Label();
            this.lblKullaniciEngel = new System.Windows.Forms.Label();
            this.lblKullaniciSoyad = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.cbKullaniciEngel = new System.Windows.Forms.ComboBox();
            this.tbKullaniciAd = new System.Windows.Forms.TextBox();
            this.tbKullaniciSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKullanici = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_Sil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_kullanıcıtc = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelKullanici = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturnAnaEkran = new System.Windows.Forms.Button();
            this.bntKullaniciBilgi = new System.Windows.Forms.Button();
            this.pnlKullaniciBilgi.SuspendLayout();
            this.pnlKullaniciEkle.SuspendLayout();
            this.groupBoxYakin.SuspendLayout();
            this.groupBoxKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).BeginInit();
            this.contextMenuStrip_Sil.SuspendLayout();
            this.flowLayoutPanelKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciEkle.BackgroundImage = global::EngelsizKartSistemi.Resource2.kullaniciEkle;
            resources.ApplyResources(this.btnKullaniciEkle, "btnKullaniciEkle");
            this.btnKullaniciEkle.FlatAppearance.BorderSize = 0;
            this.btnKullaniciEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnKullaniciAyar
            // 
            this.btnKullaniciAyar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnKullaniciAyar.BackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciAyar.BackgroundImage = global::EngelsizKartSistemi.Resource2.kullaniciAyar;
            resources.ApplyResources(this.btnKullaniciAyar, "btnKullaniciAyar");
            this.btnKullaniciAyar.FlatAppearance.BorderSize = 0;
            this.btnKullaniciAyar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciAyar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciAyar.Name = "btnKullaniciAyar";
            this.btnKullaniciAyar.UseVisualStyleBackColor = false;
            this.btnKullaniciAyar.Click += new System.EventHandler(this.btnKullaniciAyar_Click);
            // 
            // pnlKullaniciBilgi
            // 
            this.pnlKullaniciBilgi.BackColor = System.Drawing.Color.Transparent;
            this.pnlKullaniciBilgi.Controls.Add(this.pnlKullaniciEkle);
            this.pnlKullaniciBilgi.Controls.Add(this.label1);
            this.pnlKullaniciBilgi.Controls.Add(this.dataGridViewKullanici);
            this.pnlKullaniciBilgi.Controls.Add(this.cmb_kullanıcıtc);
            resources.ApplyResources(this.pnlKullaniciBilgi, "pnlKullaniciBilgi");
            this.pnlKullaniciBilgi.Name = "pnlKullaniciBilgi";
            // 
            // pnlKullaniciEkle
            // 
            this.pnlKullaniciEkle.Controls.Add(this.txt_kartID);
            this.pnlKullaniciEkle.Controls.Add(this.lbl_kartID);
            this.pnlKullaniciEkle.Controls.Add(this.btnEkle);
            this.pnlKullaniciEkle.Controls.Add(this.groupBoxYakin);
            this.pnlKullaniciEkle.Controls.Add(this.groupBoxKullanici);
            resources.ApplyResources(this.pnlKullaniciEkle, "pnlKullaniciEkle");
            this.pnlKullaniciEkle.Name = "pnlKullaniciEkle";
            // 
            // txt_kartID
            // 
            resources.ApplyResources(this.txt_kartID, "txt_kartID");
            this.txt_kartID.Name = "txt_kartID";
            // 
            // lbl_kartID
            // 
            resources.ApplyResources(this.lbl_kartID, "lbl_kartID");
            this.lbl_kartID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_kartID.Name = "lbl_kartID";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBoxYakin
            // 
            this.groupBoxYakin.Controls.Add(this.lblYakinTelefon);
            this.groupBoxYakin.Controls.Add(this.lblYakinSoyad);
            this.groupBoxYakin.Controls.Add(this.tbYakinTelefon);
            this.groupBoxYakin.Controls.Add(this.lblYakinAd);
            this.groupBoxYakin.Controls.Add(this.tbYakinAd);
            this.groupBoxYakin.Controls.Add(this.tbYakinSoyad);
            resources.ApplyResources(this.groupBoxYakin, "groupBoxYakin");
            this.groupBoxYakin.Name = "groupBoxYakin";
            this.groupBoxYakin.TabStop = false;
            // 
            // lblYakinTelefon
            // 
            resources.ApplyResources(this.lblYakinTelefon, "lblYakinTelefon");
            this.lblYakinTelefon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblYakinTelefon.Name = "lblYakinTelefon";
            // 
            // lblYakinSoyad
            // 
            resources.ApplyResources(this.lblYakinSoyad, "lblYakinSoyad");
            this.lblYakinSoyad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblYakinSoyad.Name = "lblYakinSoyad";
            // 
            // tbYakinTelefon
            // 
            resources.ApplyResources(this.tbYakinTelefon, "tbYakinTelefon");
            this.tbYakinTelefon.Name = "tbYakinTelefon";
            this.tbYakinTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYakinTelefon_KeyPress);
            // 
            // lblYakinAd
            // 
            resources.ApplyResources(this.lblYakinAd, "lblYakinAd");
            this.lblYakinAd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblYakinAd.Name = "lblYakinAd";
            // 
            // tbYakinAd
            // 
            resources.ApplyResources(this.tbYakinAd, "tbYakinAd");
            this.tbYakinAd.Name = "tbYakinAd";
            // 
            // tbYakinSoyad
            // 
            resources.ApplyResources(this.tbYakinSoyad, "tbYakinSoyad");
            this.tbYakinSoyad.Name = "tbYakinSoyad";
            // 
            // groupBoxKullanici
            // 
            this.groupBoxKullanici.Controls.Add(this.label7);
            this.groupBoxKullanici.Controls.Add(this.tbKullaniciEkleTc);
            this.groupBoxKullanici.Controls.Add(this.tbKullaniciTelefon);
            this.groupBoxKullanici.Controls.Add(this.lblKulliniTelefon);
            this.groupBoxKullanici.Controls.Add(this.lblKullaniciEngel);
            this.groupBoxKullanici.Controls.Add(this.lblKullaniciSoyad);
            this.groupBoxKullanici.Controls.Add(this.lblKullaniciAd);
            this.groupBoxKullanici.Controls.Add(this.cbKullaniciEngel);
            this.groupBoxKullanici.Controls.Add(this.tbKullaniciAd);
            this.groupBoxKullanici.Controls.Add(this.tbKullaniciSoyad);
            resources.ApplyResources(this.groupBoxKullanici, "groupBoxKullanici");
            this.groupBoxKullanici.Name = "groupBoxKullanici";
            this.groupBoxKullanici.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Name = "label7";
            // 
            // tbKullaniciEkleTc
            // 
            resources.ApplyResources(this.tbKullaniciEkleTc, "tbKullaniciEkleTc");
            this.tbKullaniciEkleTc.Name = "tbKullaniciEkleTc";
            this.tbKullaniciEkleTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKullaniciEkleTc_KeyPress);
            // 
            // tbKullaniciTelefon
            // 
            resources.ApplyResources(this.tbKullaniciTelefon, "tbKullaniciTelefon");
            this.tbKullaniciTelefon.Name = "tbKullaniciTelefon";
            this.tbKullaniciTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKullaniciTelefon_KeyPress);
            // 
            // lblKulliniTelefon
            // 
            resources.ApplyResources(this.lblKulliniTelefon, "lblKulliniTelefon");
            this.lblKulliniTelefon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblKulliniTelefon.Name = "lblKulliniTelefon";
            // 
            // lblKullaniciEngel
            // 
            resources.ApplyResources(this.lblKullaniciEngel, "lblKullaniciEngel");
            this.lblKullaniciEngel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblKullaniciEngel.Name = "lblKullaniciEngel";
            // 
            // lblKullaniciSoyad
            // 
            resources.ApplyResources(this.lblKullaniciSoyad, "lblKullaniciSoyad");
            this.lblKullaniciSoyad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblKullaniciSoyad.Name = "lblKullaniciSoyad";
            // 
            // lblKullaniciAd
            // 
            resources.ApplyResources(this.lblKullaniciAd, "lblKullaniciAd");
            this.lblKullaniciAd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            // 
            // cbKullaniciEngel
            // 
            this.cbKullaniciEngel.BackColor = System.Drawing.SystemColors.Window;
            this.cbKullaniciEngel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciEngel.FormattingEnabled = true;
            resources.ApplyResources(this.cbKullaniciEngel, "cbKullaniciEngel");
            this.cbKullaniciEngel.Name = "cbKullaniciEngel";
            // 
            // tbKullaniciAd
            // 
            resources.ApplyResources(this.tbKullaniciAd, "tbKullaniciAd");
            this.tbKullaniciAd.Name = "tbKullaniciAd";
            this.tbKullaniciAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKullaniciAd_KeyPress);
            // 
            // tbKullaniciSoyad
            // 
            resources.ApplyResources(this.tbKullaniciSoyad, "tbKullaniciSoyad");
            this.tbKullaniciSoyad.Name = "tbKullaniciSoyad";
            this.tbKullaniciSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKullaniciSoyad_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Name = "label1";
            // 
            // dataGridViewKullanici
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewKullanici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKullanici.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKullanici.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanici.ContextMenuStrip = this.contextMenuStrip_Sil;
            this.dataGridViewKullanici.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dataGridViewKullanici, "dataGridViewKullanici");
            this.dataGridViewKullanici.Name = "dataGridViewKullanici";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewKullanici.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKullanici.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewKullanici_MouseDown);
            // 
            // contextMenuStrip_Sil
            // 
            this.contextMenuStrip_Sil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip_Sil.Name = "contextMenuStrip_Sil";
            resources.ApplyResources(this.contextMenuStrip_Sil, "contextMenuStrip_Sil");
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            resources.ApplyResources(this.silToolStripMenuItem, "silToolStripMenuItem");
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // cmb_kullanıcıtc
            // 
            this.cmb_kullanıcıtc.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_kullanıcıtc, "cmb_kullanıcıtc");
            this.cmb_kullanıcıtc.Name = "cmb_kullanıcıtc";
            this.cmb_kullanıcıtc.SelectedIndexChanged += new System.EventHandler(this.cmb_kullanıcıtc_SelectedIndexChanged);
            // 
            // flowLayoutPanelKullanici
            // 
            this.flowLayoutPanelKullanici.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelKullanici.Controls.Add(this.pnlKullaniciBilgi);
            resources.ApplyResources(this.flowLayoutPanelKullanici, "flowLayoutPanelKullanici");
            this.flowLayoutPanelKullanici.Name = "flowLayoutPanelKullanici";
            // 
            // btnReturnAnaEkran
            // 
            this.btnReturnAnaEkran.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnAnaEkran.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnReturnAnaEkran, "btnReturnAnaEkran");
            this.btnReturnAnaEkran.Name = "btnReturnAnaEkran";
            this.btnReturnAnaEkran.UseVisualStyleBackColor = false;
            this.btnReturnAnaEkran.Click += new System.EventHandler(this.btnReturnAnaEkran_Click);
            // 
            // bntKullaniciBilgi
            // 
            this.bntKullaniciBilgi.BackColor = System.Drawing.Color.Transparent;
            this.bntKullaniciBilgi.BackgroundImage = global::EngelsizKartSistemi.Resource2.kullaniciBilgi;
            resources.ApplyResources(this.bntKullaniciBilgi, "bntKullaniciBilgi");
            this.bntKullaniciBilgi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntKullaniciBilgi.FlatAppearance.BorderSize = 0;
            this.bntKullaniciBilgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntKullaniciBilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntKullaniciBilgi.Name = "bntKullaniciBilgi";
            this.bntKullaniciBilgi.UseVisualStyleBackColor = false;
            this.bntKullaniciBilgi.Click += new System.EventHandler(this.bntKullaniciBilgi_Click);
            // 
            // Kullanıcılar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturnAnaEkran);
            this.Controls.Add(this.flowLayoutPanelKullanici);
            this.Controls.Add(this.btnKullaniciAyar);
            this.Controls.Add(this.bntKullaniciBilgi);
            this.Controls.Add(this.btnKullaniciEkle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Kullanıcılar_Load);
            this.pnlKullaniciBilgi.ResumeLayout(false);
            this.pnlKullaniciBilgi.PerformLayout();
            this.pnlKullaniciEkle.ResumeLayout(false);
            this.pnlKullaniciEkle.PerformLayout();
            this.groupBoxYakin.ResumeLayout(false);
            this.groupBoxYakin.PerformLayout();
            this.groupBoxKullanici.ResumeLayout(false);
            this.groupBoxKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).EndInit();
            this.contextMenuStrip_Sil.ResumeLayout(false);
            this.flowLayoutPanelKullanici.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnKullaniciAyar;
        private System.Windows.Forms.Panel pnlKullaniciBilgi;
        private System.Windows.Forms.DataGridView dataGridViewKullanici;
        private System.Windows.Forms.Panel pnlKullaniciEkle;
        private System.Windows.Forms.GroupBox groupBoxKullanici;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.TextBox tbKullaniciAd;
        private System.Windows.Forms.TextBox tbYakinTelefon;
        private System.Windows.Forms.ComboBox cbKullaniciEngel;
        private System.Windows.Forms.TextBox tbKullaniciSoyad;
        private System.Windows.Forms.GroupBox groupBoxYakin;
        private System.Windows.Forms.Label lblYakinTelefon;
        private System.Windows.Forms.Label lblYakinSoyad;
        private System.Windows.Forms.Label lblYakinAd;
        private System.Windows.Forms.TextBox tbYakinAd;
        private System.Windows.Forms.TextBox tbYakinSoyad;
        private System.Windows.Forms.TextBox tbKullaniciTelefon;
        private System.Windows.Forms.Label lblKulliniTelefon;
        private System.Windows.Forms.Label lblKullaniciEngel;
        private System.Windows.Forms.Label lblKullaniciSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKullaniciEkleTc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKullanici;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_kullanıcıtc;
        private System.Windows.Forms.TextBox txt_kartID;
        private System.Windows.Forms.Label lbl_kartID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Sil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnReturnAnaEkran;
        private System.Windows.Forms.Button bntKullaniciBilgi;
    }
}