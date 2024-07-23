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
using DGVPrinterHelper;

namespace InnoMarket2017
{
    public partial class SatisDurumForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DGVPrinter fis = new DGVPrinter();
        public SatisDurumForm()
        {
            InitializeComponent();
        }
        public void getSellTable()
        {
            string SelectQuerry = "SELECT *FROM Bill";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dGVfis.DataSource = table;
        }

        private void SatışDurumForm_Load(object sender, EventArgs e)
        {
            getSellTable();
            labeldate.Text = DateTime.Today.ToShortDateString();
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void btnyazdır_Click(object sender, EventArgs e)
        {
            fis.Title = "İnno MiniMarket Satış Faturası";
            fis.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            fis.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            fis.PageNumbers = true;
            fis.PageNumberInHeader = false;
            fis.PorportionalColumns = true;
            fis.HeaderCellAlignment = StringAlignment.Near;
            fis.Footer = "İnno MiniMarket";
            fis.FooterSpacing = 15;
            fis.printDocument.DefaultPageSettings.Landscape = true;
            fis.PrintDataGridView(dGVfis);
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriForm kategori = new KategoriForm();
            kategori.Show();
            this.Hide();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunlerForm urunlerForm = new UrunlerForm();
            urunlerForm.Show();
            this.Hide();
        }

        private void btnsatici_Click(object sender, EventArgs e)
        {
            SaticiForm saticiForm = new SaticiForm();
            saticiForm.Show();
            this.Hide();
        }

        private void lblCros_MouseEnter(object sender, EventArgs e)
        {
            lblCros.ForeColor = Color.Red;
        }

        private void lblCros_MouseLeave(object sender, EventArgs e)
        {
            lblCros.ForeColor = Color.SlateGray;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.SlateGray;
        }

        private void lblCros_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtboxbarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string barkod = txtboxbarkod.Text.Trim();
                if (barkod.Length != 13)
                {
                    return;
                }

                dBCon.openCon();
                string query = "SELECT * FROM Product WHERE ProdId = @Barkod";

                using (SqlCommand komut = new SqlCommand(query, dBCon.GetCon()))
                {
                    komut.Parameters.AddWithValue("@Barkod", barkod);
                    SqlDataReader read = komut.ExecuteReader();

                    if (read.Read())
                    {
                        txtboxsurunadi.Text = read["ProdName"].ToString();
                        txtboxFiyat.Text = read["ProdPrice"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Barkod bulunamadı.");
                    }
                }

                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dGVfis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxbarkod.Text = dGVfis.CurrentRow.Cells[0].Value.ToString();
            txtboxsurunadi.Text = dGVfis.CurrentRow.Cells[1].Value.ToString();
            txtboxFiyat.Text = dGVfis.CurrentRow.Cells[2].Value.ToString();
            txtboxAdet.Text = dGVfis.CurrentRow.Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIade_Click(object sender, EventArgs e)
        {
            IadeGoruntuleForm ıadeGoruntule = new IadeGoruntuleForm();
            ıadeGoruntule.Show();
            this.Hide();
        }
    }
}
