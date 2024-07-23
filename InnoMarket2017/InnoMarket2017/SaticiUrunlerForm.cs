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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace InnoMarket2017
{
    public partial class SaticiUrunlerForm : Form
    {
        FilterInfoCollection barkod;
        VideoCaptureDevice vcd;
        DBConnect dBCon = new DBConnect();
        public SaticiUrunlerForm()
        {
            InitializeComponent();
        }

        private void txtboxıd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string barkod = txtboxıd.Text.Trim();
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
                        txtboxurunadi.Text = read["ProdName"].ToString();
                        txtboxfiyat.Text = read["ProdPrice"].ToString();
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



        private void SaticiUrunlerForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
            barkod = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in barkod)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
        }
        public void getTable()
        {
            string SelectQuerry = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dGUrunler.DataSource = table;
        }
        private void getCategory()
        {
            string SelectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxCat.DataSource = table;
            comboBoxCat.ValueMember = "CatDes";

        }
        public void temizle()
        {
            txtboxıd.Clear();
            txtboxurunadi.Clear();
            txtboxfiyat.Clear();
            TxtboxMiktae.Clear();
            comboBoxCat.SelectedIndex = 0;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES(" + txtboxıd.Text.Trim() + " , ' " + txtboxurunadi.Text.Trim() + " '," + txtboxfiyat.Text.Trim() +
                    ", " + TxtboxMiktae.Text.Trim() + " , '" + comboBoxCat.Text.Trim() + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla kaydedildi");
                dBCon.CloseCon();
                getTable();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bgtguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtboxıd.Text) || string.IsNullOrWhiteSpace(txtboxurunadi.Text) ||
                    string.IsNullOrWhiteSpace(txtboxfiyat.Text) || string.IsNullOrWhiteSpace(TxtboxMiktae.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                }
                else
                {
                    string updateQuery = "UPDATE Product SET ProdName = @ProdName, ProdPrice = @ProdPrice, ProdQty = @ProdQty, ProdCat = @ProdCat WHERE ProdId = @ProdId";

                    using (SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon()))
                    {
                        command.Parameters.AddWithValue("@ProdName", txtboxurunadi.Text.Trim());
                        command.Parameters.AddWithValue("@ProdPrice", Convert.ToInt32(txtboxfiyat.Text.Trim()));
                        command.Parameters.AddWithValue("@ProdQty", Convert.ToInt32(TxtboxMiktae.Text.Trim()));
                        command.Parameters.AddWithValue("@ProdCat", comboBoxCat.Text.Trim());
                        command.Parameters.AddWithValue("@ProdId", Convert.ToInt64(txtboxıd.Text.Trim()));

                        dBCon.openCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün Başarıyla güncellendi");
                    }
                    dBCon.CloseCon();
                    getTable();
                    temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxıd.Text == "")
                {
                    MessageBox.Show("Ürün Bulanamadı");
                }
                else
                {
                    String deleteQuery = "DELETE FROM Product WHERE ProdId= " + txtboxıd.Text.Trim() + " ";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.openCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarıyla silindi");
                    dBCon.CloseCon();
                    getTable();
                    temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    txtboxıd.Text = sonuc.ToString();

                }
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(barkod[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame; ;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void dGUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxıd.Text = dGUrunler.CurrentRow.Cells[0].Value.ToString();
            txtboxurunadi.Text = dGUrunler.CurrentRow.Cells[1].Value.ToString();
            txtboxfiyat.Text = dGUrunler.CurrentRow.Cells[2].Value.ToString();
            TxtboxMiktae.Text = dGUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void Satis_Click(object sender, EventArgs e)
        {
            SatisForm satis = new SatisForm();
            satis.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            İadeAlForm iadeAlForm = new İadeAlForm();
            iadeAlForm.Show();
            this.Hide();
        }
    }
}
