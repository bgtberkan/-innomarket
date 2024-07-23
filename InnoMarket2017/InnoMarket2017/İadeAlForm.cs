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
    public partial class İadeAlForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public İadeAlForm()
        {
            InitializeComponent();
        }

        private void İadeAl_Load(object sender, EventArgs e)
        {

        }

        private void siparis_Click(object sender, EventArgs e)
        {
            SatisForm satis = new SatisForm();
            satis.Show();
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            SaticiUrunlerForm urunlerForm = new SaticiUrunlerForm();
            urunlerForm.Show();
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

        private void lblCikis_MouseEnter(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.Red;
        }

        private void lblCikis_MouseLeave(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.SlateGray;
        }

        private void txtBoxWhy_TextChanged(object sender, EventArgs e)
        {
            int karakter = txtBoxWhy.Text.Length;
            int kalan = 100 - karakter;
            lblKalan.Text = kalan.ToString();
            if (kalan <= 200)
            {
                lblKalan.ForeColor = Color.SlateGray;
            }
            if (kalan <= 20)
            {
                lblKalan.ForeColor = Color.Red;
            }
        }

        private void lblCros_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO [Return] (Id, RetName, RetPrice, RetWhy) VALUES (@Barkod, @UrunAdi, @Fiyat, @Neden)";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());

                
                command.Parameters.AddWithValue("@Barkod", txtBoxBarkod.Text.Trim());
                command.Parameters.AddWithValue("@UrunAdi", txtBoxUrunAdi.Text.Trim());
                command.Parameters.AddWithValue("@Fiyat", txtBoxFiyat.Text.Trim());

                
                command.Parameters.AddWithValue("@Neden", txtBoxWhy.Text.Trim());

                dBCon.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla İadeye Alındı");
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }
    }
}
