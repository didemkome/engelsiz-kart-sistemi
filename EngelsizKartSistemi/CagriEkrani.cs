using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EngelsizKartSistemi
{
    public partial class CagriEkrani : Form
    {
        SQL connect = new SQL();
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        //SqlDataReader dr;
        SqlDataAdapter da;

        public CagriEkrani()
        {
            InitializeComponent();
        }

        private void OturumAcma_Load(object sender, EventArgs e)
        {
            flowLayoutPanelCagri.Controls.Clear();
            flowLayoutPanelCagri.Controls.Add(pnlGuncel);

            pnlGecmis.Visible = false;
            pnlGuncel.Visible = true;

            dataGridViewGuncel.Visible = true;
            dataGridViewGecmis.Visible = false;

            //timerYenileyici.Start();
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Arial", 9);
            //dataGridView_engelli.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void timerYenileyici_Tick(object sender, EventArgs e)
        {/*
            connect.baglanticontrol();
            AnaPanel.Visible = true;
            dataGridView_engelli.Visible = true;
            //dataGridView_engelli.ClearSelection();
            //dt.Clear();
            //dt.Columns.Clear();
            dataGridView_engelli.DataSource = null;
            dataGridView_engelli.Refresh();

            da = new SqlDataAdapter("Select * From Kullanici", connect.baglantıadresi());
            da.Fill(dt);
            dataGridView_engelli.DataSource = dt;
            //dt.Dispose();
            //da.Dispose();
            dataGridView_engelli.AutoResizeColumns();
            dataGridView_engelli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            

            connect.baglantıkapamak();
            //timerYenileyici.Stop();*/
        }

        private void btnCagriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connect.baglanticontrol();

                pnlGuncel.Visible = true;
                pnlGecmis.Visible = false;


                dataGridViewGuncel.Visible = true;
                cmb_durum.Text = "Filtrele";
                connect.baglantıacmak();
                komut.CommandText = "Insert Into Yardim(durum) values('" + cmb_durum.Text + "')";
                komut.ExecuteNonQuery();


                //da = new SqlDataAdapter("Select kartID, TC, adi, soyadi, engeli, telefonu, yakinTelefonu, sonuc, yardimTarihiSaati, ekNot " +
                //    "From Yardim, Kullanici, Kart, RaspAdres where Yardim.kartID = Kart.kartID", connect.baglantıadresi());
                //dataGridViewGuncel.DataSource = dt;
                //SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                //da.Update(dt);
                dataGridViewGuncel.ClearSelection();
                dt.Clear();
                dt.Columns.Clear();
                dataGridViewGuncel.DataSource = null;

                dataGridViewGuncel.Refresh();
                string KullaniciTC;
                KullaniciTC = cmb_kullanıcıtc.SelectedItem.ToString();
                da = new SqlDataAdapter("Select * From Kullanici where TC = '" + KullaniciTC + "'", connect.baglantıadresi());
                da.Fill(dt);
                dataGridViewKullanici.DataSource = dt;
                dt.Dispose();
                da.Dispose();
                dr.Close();
                connect.baglantıkapamak();
                MessageBox.Show("Kayıt güncellendi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK);
                komut.Clone();

                connect.baglantıkapamak();
            }
            catch
            {
                MessageBox.Show("Hata! Kayıt Güncellenemedi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
