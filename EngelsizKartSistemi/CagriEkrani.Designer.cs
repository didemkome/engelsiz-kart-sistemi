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
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.flowLayoutPanelCagri = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGuncel = new System.Windows.Forms.Panel();
            this.pnlGecmis = new System.Windows.Forms.Panel();
            this.dataGridViewGecmis = new System.Windows.Forms.DataGridView();
            this.dataGridViewGuncel = new System.Windows.Forms.DataGridView();
            this.btnCagriGuncelle = new System.Windows.Forms.Button();
            this.btnReturnAnaEkran = new System.Windows.Forms.Button();
            this.timer_Güncel = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelCagri.SuspendLayout();
            this.pnlGuncel.SuspendLayout();
            this.pnlGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuncel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncel
            // 
            this.btnGuncel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnGuncel, "btnGuncel");
            this.btnGuncel.FlatAppearance.BorderSize = 0;
            this.btnGuncel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.UseVisualStyleBackColor = false;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnGecmis, "btnGecmis");
            this.btnGecmis.FlatAppearance.BorderSize = 0;
            this.btnGecmis.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.UseVisualStyleBackColor = false;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
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
            this.pnlGuncel.Controls.Add(this.btnCagriGuncelle);
            resources.ApplyResources(this.pnlGuncel, "pnlGuncel");
            this.pnlGuncel.Name = "pnlGuncel";
            // 
            // pnlGecmis
            // 
            this.pnlGecmis.Controls.Add(this.dataGridViewGecmis);
            resources.ApplyResources(this.pnlGecmis, "pnlGecmis");
            this.pnlGecmis.Name = "pnlGecmis";
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
            this.dataGridViewGuncel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuncel_CellEndEdit);
            this.dataGridViewGuncel.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGuncel_CellMouseDoubleClick);
            // 
            // btnCagriGuncelle
            // 
            resources.ApplyResources(this.btnCagriGuncelle, "btnCagriGuncelle");
            this.btnCagriGuncelle.Name = "btnCagriGuncelle";
            this.btnCagriGuncelle.UseVisualStyleBackColor = true;
            this.btnCagriGuncelle.Click += new System.EventHandler(this.btnCagriGuncelle_Click);
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
            // timer_Güncel
            // 
            this.timer_Güncel.Interval = 10000;
            this.timer_Güncel.Tick += new System.EventHandler(this.timer_Güncel_Tick);
            // 
            // CagriEkrani
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundImage = global::EngelsizKartSistemi.Resource2.arkaplan2;
            this.Controls.Add(this.btnReturnAnaEkran);
            this.Controls.Add(this.flowLayoutPanelCagri);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.btnGuncel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CagriEkrani";
            this.ShowInTaskbar = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CagriEkrani_FormClosed);
            this.Load += new System.EventHandler(this.OturumAcma_Load);
            this.flowLayoutPanelCagri.ResumeLayout(false);
            this.pnlGuncel.ResumeLayout(false);
            this.pnlGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuncel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCagri;
        private System.Windows.Forms.Panel pnlGuncel;
        private System.Windows.Forms.Panel pnlGecmis;
        private System.Windows.Forms.DataGridView dataGridViewGecmis;
        private System.Windows.Forms.Button btnCagriGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewGuncel;
        private System.Windows.Forms.Button btnReturnAnaEkran;
        private System.Windows.Forms.Timer timer_Güncel;
    }
}

