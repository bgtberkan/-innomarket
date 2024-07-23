using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace InnoMarket2017
{
    public partial class KategoriForm : Form
    {
        DBConnect dBCon = new DBConnect();
        FilterInfoCollection barkod;
        VideoCaptureDevice vcd;
        public KategoriForm()
        {
            InitializeComponent();
        }

        public void GetTable()
        {
            string SelectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(SelectQuerry , dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            datagrid.DataSource = table;

        }

        private void KatagoriForm_Load(object sender, EventArgs e)
        {
            GetTable();
            barkod = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in barkod)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
  


        }

        private void lblcros_MouseEnter(object sender, EventArgs e)
        {
            lblcros.ForeColor = Color.Red;
        }

        private void lblcros_MouseLeave(object sender, EventArgs e)
        {
            lblcros.ForeColor = Color.SlateGray;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + txtboxıd.Text.Trim() +" , ' " + txtboxurunadi.Text.Trim() + " ','"+txtboxcatdes.Text.Trim() +"')";
                SqlCommand command = new SqlCommand(insertQuery , dBCon.GetCon());
                dBCon.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Katagori Başarıyla kaydedildi");
                dBCon.CloseCon();
                GetTable();

            }
            catch (Exception ex)
            {     
                MessageBox.Show(ex.Message);
            }

             
        }

        private void lblcros_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void txtboxıd_TextChanged(object sender, EventArgs e)
        {
            if (txtboxıd.Text == "") foreach (Control items in Controls) if (items is TextBox) items.Text = "";
            dBCon.openCon();
            string quary = "Select * from Product Where ProdId like '" + txtboxıd.Text + "'";
            SqlCommand komut = new SqlCommand(quary, dBCon.GetCon());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtboxurunadi.Text = read["ProdName"].ToString();
                txtboxcatdes.Text = read["ProdCat"].ToString();
            }
            dBCon.CloseCon();
        }

        private void dataGridCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunlerForm urunlerForm = new UrunlerForm();
            urunlerForm.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Category SET CatName = @CatName, CatDes = @CatDes WHERE CatId = @CatId";

            using (SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon()))
            {
                command.Parameters.AddWithValue("@CatName", txtboxurunadi.Text.Trim());
                command.Parameters.AddWithValue("@CatDes", txtboxcatdes.Text.Trim());
                command.Parameters.AddWithValue("@CatId", txtboxıd.Text.Trim());

                try
                {
                    dBCon.openCon();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kategori Başarıyla Güncellendi");
                        GetTable();
                        temizle();

                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız oldu. Belirtilen ID bulunamadı.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    dBCon.CloseCon();
                }
            }
        }

        private void datagrid_Click(object sender, EventArgs e)
        {
            txtboxıd.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            txtboxurunadi.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
            txtboxcatdes.Text = datagrid.SelectedRows[0].Cells[2].Value.ToString();
          

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Category WHERE CatId = @CatId";

            using (SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon()))
            {
                command.Parameters.AddWithValue("@CatId", txtboxıd.Text);

                try
                {
                    dBCon.openCon();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kategori Başarıyla Silindi");
                        GetTable();
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Silme Başarısız oldu. Belirtilen ID bulunamadı.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    dBCon.CloseCon();
                }
            }
        }
        private void temizle()
        {
            txtboxurunadi.Clear();
            txtboxcatdes.Clear();
            txtboxıd.Clear();
        }

        private void lblcikis_Click(object sender, EventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();
            this.Hide();
        }

        private void lblcikis_MouseEnter(object sender, EventArgs e)
        {
            lblcikis.ForeColor = Color.Red;
        }

        private void urunpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblcikis_MouseLeave(object sender, EventArgs e)
        {
            lblcikis.ForeColor = Color.SlateGray;
        }

        private void btnsatici_Click(object sender, EventArgs e)
        { 

                SaticiForm saticiForm = new SaticiForm();
                saticiForm.Show();
                this.Hide();
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picturBoxBarkod.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)picturBoxBarkod.Image);
                if (sonuc != null)
                {
                    txtboxıd.Text = sonuc.ToString();

                }
            }

        }

        private void btnkameraac_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(barkod[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picturBoxBarkod.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxıd.Text = datagrid.CurrentRow.Cells[0].Value.ToString();
            txtboxcatdes.Text = datagrid.CurrentRow.Cells[2].Value.ToString();
            txtboxurunadi.Text = datagrid.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            SatisDurumForm satisForm = new SatisDurumForm();
            satisForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsatis_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnsatis_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            IadeGoruntuleForm ıadeGoruntule = new IadeGoruntuleForm();
            ıadeGoruntule.Show();
            this.Hide();
        }
    }
}
