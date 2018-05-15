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
using System.Collections;

namespace EngelsizKartSistemi
{
    public partial class CagriEkrani : Form
    {
        SQL connect = new SQL();
        SqlCommand komut = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        SqlDataAdapter da;
        private bool bIsComboBox;
        delegate void SetComboBoxCellType(int iRowIndex);

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
            dataGridViewGuncel.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridViewGuncel.ClearSelection();
            dt.Clear();
            dt.Columns.Clear();
            dataGridViewGuncel.DataSource = null;
            dataGridViewGuncel.Refresh();

            //da = new SqlDataAdapter("Select * from Kullanici", connect.baglantıadresi());

            da = new SqlDataAdapter("Select Kart.kartID, Kullanici.TC, adi, soyadi, engeli, telefonu, yakinTelefonu, durum, sonuc, yardimTarihiSaati, mahalle, sokakCaddeBulvar, il, ilce " +
                    "From Yardim, Kullanici, Kart, Raspberry where Yardim.kartID = Kart.kartID and Kullanici.TC = Kart.TC and Yardim.raspberryID = Raspberry.raspberryID", connect.baglantıadresi());

            da.Fill(dt);
            dataGridViewGuncel.DataSource = dt;
            dt.Dispose();
            da.Dispose();
            connect.baglantıkapamak();
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
            //try
            //{
            //    connect.baglanticontrol();

            //    pnlGuncel.Visible = true;
            //    pnlGecmis.Visible = false;


            //    dataGridViewGuncel.Visible = true;

            //    dataGridViewGuncel.ReadOnly = false;

            //    cmb_durum.Text = "Filtrele";
            //    komut.CommandText = "Insert Into Yardim(durum) values('" + cmb_durum.Text + "')";
            //    komut.ExecuteNonQuery();

            //    //da = new SqlDataAdapter("Select kartID, TC, adi, soyadi, engeli, telefonu, yakinTelefonu, sonuc, yardimTarihiSaati, ekNot " +
            //    //    "From Yardim, Kullanici, Kart, RaspAdres where Yardim.kartID = Kart.kartID", connect.baglantıadresi());
            //    //dataGridViewGuncel.DataSource = dt;
            //    //SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
            //    da.Update(dt);

            //    MessageBox.Show("Kayıt güncellendi!", "Bilgilendirme Penceresi", MessageBoxButtons.OK);
            //    komut.Clone();

            //    connect.baglantıkapamak();
            //}
            //catch
            //{
            //    MessageBox.Show("Hata! Kayıt Güncellenemedi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dataGridViewGuncel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewGuncel.ReadOnly = false;
            SetComboBoxCellType objChangeCellType = new SetComboBoxCellType(ChangeCellToComboBox);
            if (e.ColumnIndex == this.dataGridViewGuncel.Columns["durum"].Index)
            {
                this.dataGridViewGuncel.BeginInvoke(objChangeCellType, e.RowIndex);
                bIsComboBox = false;
            }
        }
        private void ChangeCellToComboBox(int iRowIndex)
        {
            dataGridViewGuncel.ReadOnly = false;

            if (bIsComboBox == false)
            {
                DataGridViewComboBoxCell dgComboCell = new DataGridViewComboBoxCell();
                dgComboCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                dataGridViewGuncel.Rows[iRowIndex].Cells[dataGridViewGuncel.CurrentCell.ColumnIndex] = dgComboCell;
                bIsComboBox = true;
            }
        }
    }
}
