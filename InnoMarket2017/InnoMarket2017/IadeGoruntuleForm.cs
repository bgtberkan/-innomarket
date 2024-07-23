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

namespace InnoMarket2017
{
    public partial class IadeGoruntuleForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public IadeGoruntuleForm()
        {
            InitializeComponent();
        }

        private void İadeGörüntüleForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getTable()
        {
            string SelectQuerry = "SELECT * FROM [Return]";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dGWIade.DataSource = table;
        }

        private void dGWIade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxBarkod.Text = dGWIade.CurrentRow.Cells[0].Value.ToString();
            txtBoxUrunAdi.Text = dGWIade.CurrentRow.Cells[1].Value.ToString();
            txtBoxFiyat.Text = dGWIade.CurrentRow.Cells[2].Value.ToString();
            txtBoxWhy.Text = dGWIade.CurrentRow.Cells[3].Value.ToString();
        }

        private void lblCros_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
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

        private void lblCikis_MouseLeave(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.SlateGray;
        }

        private void lblCikis_MouseEnter(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            SatisDurumForm satis = new SatisDurumForm();
            satis.Show();
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunlerForm urunler = new UrunlerForm();
            urunler.Show();
            this.Hide();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();
            kategoriForm.Show();
            this.Hide();
        }

        private void btnSatici_Click(object sender, EventArgs e)
        {
            SaticiForm satici = new SaticiForm();
            satici.Show();
            this.Hide();
        }
    }
}
