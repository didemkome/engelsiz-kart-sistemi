namespace EngelsizKartSistemi
{
    partial class CagriEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CagriEkrani));
            this.timerYenileyici = new System.Windows.Forms.Timer(this.components);
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.flowLayoutPanelCagri = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGuncel = new System.Windows.Forms.Panel();
            this.pnlGecmis = new System.Windows.Forms.Panel();
            this.cbMahalle = new System.Windows.Forms.ComboBox();
            this.dataGridViewGecmis = new System.Windows.Forms.DataGridView();
            this.dataGridViewGuncel = new System.Windows.Forms.DataGridView();
            this.cmb_durum = new System.Windows.Forms.ComboBox();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.btnCagriGuncelle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanelCagri.SuspendLayout();
            this.pnlGuncel.SuspendLayout();
            this.pnlGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuncel)).BeginInit();
            this.SuspendLayout();
            // 
            // timerYenileyici
            // 
            this.timerYenileyici.Interval = 1000;
            this.timerYenileyici.Tick += new System.EventHandler(this.timerYenileyici_Tick);
            // 
            // btnGuncel
            // 
            this.btnGuncel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnGuncel, "btnGuncel");
            this.btnGuncel.FlatAppearance.BorderSize = 0;
            this.btnGuncel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.UseVisualStyleBackColor = false;
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnGecmis, "btnGecmis");
            this.btnGecmis.FlatAppearance.BorderSize = 0;
            this.btnGecmis.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelCagri
            // 
            this.flowLayoutPanelCagri.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCagri.Controls.Add(this.pnlGuncel);
            resources.ApplyResources(this.flowLayoutPanelCagri, "flowLayoutPanelCagri");
            this.flowLayoutPanelCagri.Name = "flowLayoutPanelCagri";
            // 
            // pnlGuncel
            // 
            this.pnlGuncel.Controls.Add(this.pnlGecmis);
            this.pnlGuncel.Controls.Add(this.dataGridViewGuncel);
            this.pnlGuncel.Controls.Add(this.cmb_durum);
            this.pnlGuncel.Controls.Add(this.lbl_durum);
            this.pnlGuncel.Controls.Add(this.btnCagriGuncelle);
            resources.ApplyResources(this.pnlGuncel, "pnlGuncel");
            this.pnlGuncel.Name = "pnlGuncel";
            // 
            // pnlGecmis
            // 
            this.pnlGecmis.Controls.Add(this.cbMahalle);
            this.pnlGecmis.Controls.Add(this.dataGridViewGecmis);
            resources.ApplyResources(this.pnlGecmis, "pnlGecmis");
            this.pnlGecmis.Name = "pnlGecmis";
            // 
            // cbMahalle
            // 
            this.cbMahalle.FormattingEnabled = true;
            resources.ApplyResources(this.cbMahalle, "cbMahalle");
            this.cbMahalle.Name = "cbMahalle";
            // 
            // dataGridViewGecmis
            // 
            this.dataGridViewGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewGecmis, "dataGridViewGecmis");
            this.dataGridViewGecmis.Name = "dataGridViewGecmis";
            // 
            // dataGridViewGuncel
            // 
            this.dataGridViewGuncel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewGuncel, "dataGridViewGuncel");
            this.dataGridViewGuncel.Name = "dataGridViewGuncel";
            this.dataGridViewGuncel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuncel_CellEnter);
            // 
            // cmb_durum
            // 
            this.cmb_durum.FormattingEnabled = true;
            this.cmb_durum.Items.AddRange(new object[] {
            resources.GetString("cmb_durum.Items")});
            resources.ApplyResources(this.cmb_durum, "cmb_durum");
            this.cmb_durum.Name = "cmb_durum";
            // 
            // lbl_durum
            // 
            resources.ApplyResources(this.lbl_durum, "lbl_durum");
            this.lbl_durum.Name = "lbl_durum";
            // 
            // btnCagriGuncelle
            // 
            resources.ApplyResources(this.btnCagriGuncelle, "btnCagriGuncelle");
            this.btnCagriGuncelle.Name = "btnCagriGuncelle";
            this.btnCagriGuncelle.UseVisualStyleBackColor = true;
            this.btnCagriGuncelle.Click += new System.EventHandler(this.btnCagriGuncelle_Click);
            // 
            // CagriEkrani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundImage = global::EngelsizKartSistemi.Resource2.arkaplan2;
            this.Controls.Add(this.flowLayoutPanelCagri);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.btnGuncel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CagriEkrani";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.OturumAcma_Load);
            this.flowLayoutPanelCagri.ResumeLayout(false);
            this.pnlGuncel.ResumeLayout(false);
            this.pnlGuncel.PerformLayout();
            this.pnlGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuncel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerYenileyici;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCagri;
        private System.Windows.Forms.Panel pnlGuncel;
        private System.Windows.Forms.Panel pnlGecmis;
        private System.Windows.Forms.ComboBox cbMahalle;
        private System.Windows.Forms.DataGridView dataGridViewGecmis;
        private System.Windows.Forms.Button btnCagriGuncelle;
        private System.Windows.Forms.ComboBox cmb_durum;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.DataGridView dataGridViewGuncel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

