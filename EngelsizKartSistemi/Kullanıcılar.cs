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
    public partial class Kullanıcılar : Form
    {
        SQL connect = new SQL();
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommand komut = new SqlCommand();
        int TC;

        public Kullanıcılar()
        {
            InitializeComponent();
        }
        public void stringkontrol(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }
        public void numerickontrol(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        public void karakterkontrol(object sender, KeyPressEventArgs e, TextBox txt)
        {
            if ((Char)Keys.Back != e.KeyChar)
            {
                if (!Char.IsDigit(e.KeyChar) || txt.Text.Length > 10)
                {
                    e.Handled = true;
                }
            }
        }
        public void sembol(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Back != e.KeyChar)
            {
                if (Char.IsDigit(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false && Char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        public bool nullcontrol(TextBox txt)
        {

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                return false;
            }
            return true;
        }
        public void datagridfiltesiz(string butonname)
        {
            if (butonname == "Kullanici")
            {

                dataGridViewKullanici.ClearSelection();
                dt.Clear();
                dt.Columns.Clear();
                dataGridViewKullanici.DataSource = null;

                dataGridViewKullanici.Refresh();

                da = new SqlDataAdapter("Select * From Kullanici", connect.baglantıadresi());
                da.Fill(dt);
                dataGridViewKullanici.DataSource = dt;

                dataGridViewKullanici.AutoResizeColumns();
                dataGridViewKullanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Arial", 9);
                dataGridViewKullanici.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            }
            dt.Dispose();
            da.Dispose();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.pnlKullaniciBilgi.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
            foreach (Control item in this.pnlKullaniciEkle.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }

            connect.baglanticontrol();
            datagridfiltesiz("Kullanici");

            flowLayoutPanelKullanici.Controls.Clear();
            flowLayoutPanelKullanici.Controls.Add(pnlKullaniciBilgi);

            pnlKullaniciEkle.Visible = false;
            pnlKullaniciBilgi.Visible = true;

            dataGridViewKullanici.Visible = true;

            cmb_kullanıcıtc.Text = "Filtrele";
            komut.CommandText = "SELECT distinct TC FROM Kullanici";
            komut.Connection = connect.baglantıadresi();
            komut.CommandType = CommandType.Text;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_kullanıcıtc.Items.Add(dr["TC"]);
            }

            dr.Close();
            connect.baglantıkapamak();

        }
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            connect.baglanticontrol();

            flowLayoutPanelKullanici.Controls.Clear();
            flowLayoutPanelKullanici.Controls.Add(pnlKullaniciEkle);

            pnlKullaniciEkle.Visible = true;
            pnlKullaniciBilgi.Visible = false;

            dataGridViewKullanici.Visible = false;

            connect.baglantıacmak();
            cbKullaniciEngel.Text = "Filtrele";
            cbİl.Text = "Filtrele";
            komut.CommandText = "SELECT distinct engeli,il FROM Kullanici,Adres";
            komut.Connection = connect.baglantıadresi();
            komut.CommandType = CommandType.Text;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbKullaniciEngel.Items.Add(dr["engeli"]);
                cbİl.Items.Add(dr["il"]);
            }
            dr.Close();
            connect.baglantıkapamak();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            connect.baglanticontrol();

            pnlKullaniciEkle.Visible = false;
            pnlKullaniciBilgi.Visible = true;

            dataGridViewKullanici.Visible = true;

            //string kullanicisil = " ";
            cmb_kullanıcıtc.Text = "Filtrele";
            /*foreach (DataGridViewRow drow in dataGridViewKullanici.SelectedRows)
            {
                int TC = Convert.ToInt32(drow.Cells[0].Value);
                kullanicisil = connect.KullaniciSil(TC);
            }
            MessageBox.Show(kullanicisil);*/
            datagridfiltesiz("Kullanici");

            connect.baglantıkapamak();
        }
        private void bntKullaniciBilgi_Click(object sender, EventArgs e)
        {
            connect.baglanticontrol();
            datagridfiltesiz("Kullanici");

            flowLayoutPanelKullanici.Controls.Clear();
            flowLayoutPanelKullanici.Controls.Add(pnlKullaniciBilgi);

            pnlKullaniciEkle.Visible = false;
            pnlKullaniciBilgi.Visible = true;

            dataGridViewKullanici.Visible = true;

            cmb_kullanıcıtc.Text = "Filtrele";
            komut.CommandText = "SELECT distinct TC FROM Kullanici";
            komut.Connection = connect.baglantıadresi();
            komut.CommandType = CommandType.Text;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_kullanıcıtc.Items.Add(dr["TC"]);
            }

            dr.Close();
            connect.baglantıkapamak();

        }

        private void btnKullaniciAyar_Click(object sender, EventArgs e)
        {
            try
            {
                connect.baglanticontrol();

                pnlKullaniciEkle.Visible = false;
                pnlKullaniciBilgi.Visible = true;

                dataGridViewKullanici.Visible = true;

                da = new SqlDataAdapter("Select * From Kullanici", connect.baglantıadresi());
                dataGridViewKullanici.DataSource = dt;
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Kayıt güncellendi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK);

                datagridfiltesiz("Kullanici");
                connect.baglantıkapamak();
            }
            catch
            {
                MessageBox.Show("Hata! Kayıt Güncellenemedi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSistemdenSil_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (nullcontrol(tbKullaniciEkleTc) == false || nullcontrol(tbKullaniciAd) == false || nullcontrol(tbKullaniciSoyad) == false
                || nullcontrol(txt_kartID) == false /*|| IsValidEmail(txtyetkiliposta_m.Text) == false || IsValidEmail(txt_teposta_m.Text) == false*/)
            {
                MessageBox.Show("LUTFEN * İLE BELİRTİLEN ALANLARI DOLDURUNUZ !");
            }
            else
            {
                try
                {
                    connect.baglanticontrol();
                    SqlCommand komut = new SqlCommand("KullaniciEkle", connect.baglantıadresi());
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@TC", SqlDbType.Int).Value = tbKullaniciEkleTc.Text.Trim();
                    komut.Parameters.AddWithValue("@adi", SqlDbType.NVarChar).Value = tbKullaniciAd.Text.Trim();
                    komut.Parameters.AddWithValue("@soyadi", SqlDbType.NVarChar).Value = tbKullaniciSoyad.Text.Trim();
                    komut.Parameters.AddWithValue("@engeli", SqlDbType.NVarChar).Value = cbKullaniciEngel.SelectedItem.ToString().Trim();
                    komut.Parameters.AddWithValue("@yakinAdi", SqlDbType.NVarChar).Value = tbYakinAd.Text.Trim();
                    komut.Parameters.AddWithValue("@yakinSoyadi", SqlDbType.NVarChar).Value = tbYakinSoyad.Text.Trim();
                    komut.Parameters.AddWithValue("@yakinTelefonu", SqlDbType.NVarChar).Value = tbYakinTelefon.Text.Trim();
                    komut.Parameters.AddWithValue("@telefonu", SqlDbType.NVarChar).Value = tbKullaniciTelefon.Text.Trim();
                    komut.Parameters.AddWithValue("@mahalle", SqlDbType.NVarChar).Value = tbMahalle.Text.Trim();
                    komut.Parameters.AddWithValue("@sokakCaddeBulvar", SqlDbType.NVarChar).Value = tbSokak.Text.Trim();
                    komut.Parameters.AddWithValue("@il", SqlDbType.NVarChar).Value = cbİl.SelectedItem.ToString().Trim();
                    komut.Parameters.AddWithValue("@ilce", SqlDbType.NVarChar).Value = tbİlce.Text.Trim();
                    komut.Parameters.AddWithValue("@adresTarifi", SqlDbType.NVarChar).Value = tbTarif.Text.Trim();
                    komut.Parameters.AddWithValue("@kartID", SqlDbType.NVarChar).Value = txt_kartID.Text.Trim();
                    komut.ExecuteNonQuery();
                    //komut.Parameters.AddWithValue("@adresID", SqlDbType.Int).Value = int.Parse(AdresID);
                    MessageBox.Show("Kullanıcı Eklendi !", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı Eklenemedi ! ");
                    //this.Close();
                }
            }
        }

        private void cmb_kullanıcıtc_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.baglanticontrol();
            dataGridViewKullanici.ClearSelection();
            dt.Clear();
            dt.Columns.Clear();
            dataGridViewKullanici.DataSource = null;

            dataGridViewKullanici.Refresh();
            string KullaniciTC;
            KullaniciTC = cmb_kullanıcıtc.SelectedItem.ToString();
            da = new SqlDataAdapter("Select * From Kullanici where TC = '" + KullaniciTC + "'", connect.baglantıadresi());
            da.Fill(dt);
            dataGridViewKullanici.DataSource = dt;
            dt.Dispose();
            da.Dispose();
            dr.Close();
            connect.baglantıkapamak();
        }

        private void tbKullaniciAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            stringkontrol(sender, e);
        }

        private void tbKullaniciSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            stringkontrol(sender, e);
        }

        private void tbKullaniciEkleTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            karakterkontrol(sender, e, tbKullaniciEkleTc);
            if (tbKullaniciEkleTc.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void tbKullaniciTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            karakterkontrol(sender, e, tbKullaniciTelefon);
            if (tbKullaniciTelefon.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void txt_kartID_KeyPress(object sender, KeyPressEventArgs e)
        {
            karakterkontrol(sender, e, txt_kartID);
        }

        private void tbYakinTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            karakterkontrol(sender, e, tbYakinTelefon);
            if (tbYakinTelefon.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void dataGridViewKullanici_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//farenin sağ tuşuna basılmışsa
            {
                cmb_kullanıcıtc.Text = "Filtrele";
                int satir = dataGridViewKullanici.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1)
                {
                    dataGridViewKullanici.Rows[satir].Selected = true;//bu tıkladığımız alanı seçtiriyoruz
                    TC = Convert.ToInt32(dataGridViewKullanici.Rows[satir].Cells["TC"].Value);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kullanicisil = " ";
            cmb_kullanıcıtc.Text = "Filtrele";
            //foreach (DataGridViewRow drow in dataGridViewKullanici.SelectedRows)
            //{
               // int TC = Convert.ToInt32(drow.Cells[0].Value);
                kullanicisil = connect.KullaniciSil(TC);
            //}
            MessageBox.Show(kullanicisil);
        }
    }
}
