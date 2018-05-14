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
            timerYenileyici.Start();
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Arial", 9);
            //dataGridView_engelli.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void btnKullaniciGetir_Click(object sender, EventArgs e)
        {
           
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

        private void dataGridView_engelli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
