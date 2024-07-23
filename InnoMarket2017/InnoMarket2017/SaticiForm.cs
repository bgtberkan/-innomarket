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
    public partial class SaticiForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public SaticiForm()
        {
            InitializeComponent();
        }
        public void getTable()
        {
            string SelectQuerry = "SELECT * FROM seller";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dGWSatici.DataSource = table;
        }
        public void Clear()
        {
            txtboxıd.Clear();
            txtboxsaticiadi.Clear();
            txtboxtel.Clear();
            TxtboxSifre.Clear();
            textBoxYas.Clear();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO seller VALUES("+txtboxıd.Text.Trim()+" ,'"+txtboxsaticiadi.Text.Trim()+"' , "+ textBoxYas.Text.Trim()+" ,"+txtboxtel.Text.Trim()+" , '"+TxtboxSifre.Text.Trim()+"' )";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Satıcı Başarıyla kaydedildi");
                dBCon.CloseCon();
                getTable();
                Clear();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void urunpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaticiForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void bgtguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtboxıd.Text) || string.IsNullOrWhiteSpace(txtboxsaticiadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYas.Text) || string.IsNullOrWhiteSpace(txtboxtel.Text) || string.IsNullOrWhiteSpace(TxtboxSifre.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                }
                else
                {
                    string updateQuery = "UPDATE seller SET SellerName = @SellerName, Sellerage = @Sellerage, SellerPhone = @SellerPhone, SellerPass = @SellerPass WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon()))
                    {
                        command.Parameters.AddWithValue("@SellerName", txtboxsaticiadi.Text.Trim());
                        command.Parameters.AddWithValue("@Sellerage", Convert.ToDecimal(textBoxYas.Text.Trim()));
                        command.Parameters.AddWithValue("@SellerPhone", Convert.ToInt32(txtboxtel.Text.Trim()));
                        command.Parameters.AddWithValue("@SellerPass", TxtboxSifre.Text.Trim());
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtboxıd.Text.Trim()));

                        dBCon.openCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Depişiklikler Başarıyla güncellendi");
                    }
                    dBCon.CloseCon();
                    getTable();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dGWUrunler_Click(object sender, EventArgs e)
        {
            txtboxıd.Text = dGWSatici.SelectedRows[0].Cells[0].Value.ToString();
            txtboxsaticiadi.Text = dGWSatici.SelectedRows[0].Cells[1].Value.ToString();
            textBoxYas.Text = dGWSatici.SelectedRows[0].Cells[2].Value.ToString();
            txtboxtel.Text = dGWSatici.SelectedRows[0].Cells[3].Value.ToString();
            TxtboxSifre.Text = dGWSatici.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM seller WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon()))
            {
                command.Parameters.AddWithValue("@Id", txtboxıd.Text);

                try
                {
                    dBCon.openCon();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Satıcı Başarıyla Silindi");
                        getTable();
                        Clear();
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

        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunlerForm urunlerForm = new UrunlerForm();
            urunlerForm.Show();
            this.Hide();
        }

        private void btnkatagori_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();
            kategoriForm.Show();
            this.Hide();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            SatisDurumForm satisDurum = new SatisDurumForm();
            satisDurum.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }

        private void lblcros_MouseEnter(object sender, EventArgs e)
        {
            lblcros.ForeColor = Color.Red;
        }

        private void lblcros_MouseLeave(object sender, EventArgs e)
        {
            lblcros.ForeColor = Color.SlateGray;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red; 
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.SlateGray;
        }

        private void lblcros_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }

        private void dGWSatici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxıd.Text = dGWSatici.CurrentRow.Cells[0].Value.ToString();
            txtboxsaticiadi.Text = dGWSatici.CurrentRow.Cells[1].Value.ToString();
            textBoxYas.Text = dGWSatici.CurrentRow.Cells[2].Value.ToString();
            txtboxtel.Text = dGWSatici.CurrentRow.Cells[3].Value.ToString();
            TxtboxSifre.Text = dGWSatici.CurrentRow.Cells[4].Value.ToString();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
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
