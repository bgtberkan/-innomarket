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
using DGVPrinterHelper;
using System.Media;

namespace InnoMarket2017
{
    public partial class SatisForm : Form
    {
        
        SoundPlayer sPlayer = new SoundPlayer(Resources.videoplayback);
        DGVPrinter fis = new DGVPrinter();
        FilterInfoCollection barkod;
        VideoCaptureDevice vcd;
        DBConnect dBCon = new DBConnect();
        
        
        public SatisForm()
        {
            InitializeComponent();
        }
        private void getCategory()
        {
            string SelectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }
         public void getTable()
         {
            string SelectQuerry = "SELECT ProdName, ProdPrice , ProdQty FROM Product";
            SqlCommand command = new SqlCommand(SelectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dGWUrun.DataSource = table;
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
        int grandtotal = 0, n = 0;
        DataTable table = new DataTable();
        private void btnekle_Click(object sender, EventArgs e)
        {
            bool adetkontrol = true;
            while (adetkontrol)
            {
                if (string.IsNullOrWhiteSpace(txtboxAdet.Text))
                {
                    MessageBox.Show("Lütfen adet giriniz");
                    break; 
                }
                else
                {

                    int fiyat = Convert.ToInt32(txtboxFiyat.Text);
                    int Adet = Convert.ToInt32(txtboxAdet.Text);
                    int mevcutStok = GetMevcutStok(textBoxBarkod.Text);
                    if (mevcutStok >= Adet)
                    {
                        
                        string updateQuery = "UPDATE Product SET ProdQty = ProdQty - @SatisAdedi WHERE ProdId = @ProdId";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, dBCon.GetCon()))
                        {
                            updateCommand.Parameters.AddWithValue("@SatisAdedi", Adet);
                            updateCommand.Parameters.AddWithValue("@ProdId", textBoxBarkod.Text);

                            dBCon.openCon();
                            updateCommand.ExecuteNonQuery();
                            dBCon.CloseCon();
                            int total = fiyat * Adet;
                            table.Rows.Add(txtboxsurunadi.Text, txtboxFiyat.Text, txtboxAdet.Text, total);
                     ;
                            grandtotal += total;
                            lbltutar.Text = grandtotal + "TL";
                            adetkontrol = false;
                            getTable();
                            Clear();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz stok! Satış işlemi gerçekleştirilemedi.");
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelsatici_Click(object sender, EventArgs e)
        {

        }
        
        private void SatisForm_Load(object sender, EventArgs e)
        {
             
            getSellTable();
            getCategory();
            getTable();
            barkod = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in barkod)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
            labeldate.Text = DateTime.Today.ToShortDateString();
            table.Columns.Add("Ürün Adı", typeof(string));
            table.Columns.Add("Fiyat", typeof(int));
            table.Columns.Add("Adet", typeof(int));
            table.Columns.Add("Tutar", typeof(int));
            dGWSiparis.DataSource = table;
            lblsatici.Text = GirisForm.sellerName;
            


        }

        private void dGWUrun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 

        private void btnac_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(barkod[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    sPlayer.Play();
                    textBoxBarkod.Text = sonuc.ToString();
                }
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void urunpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGWUrun_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear()
        {
            textBoxBarkod.Clear();
            txtboxFiyat.Clear();
            txtboxsurunadi.Clear();
            txtboxAdet.Clear();
        }
        int nFis = -1;
        
        private void btnekle_Click_1(object sender, EventArgs e)
        {
            nFis++;
            int yazFis = 1;
            yazFis = yazFis + nFis;
            lblfis.Text = yazFis.ToString();
             try
             {
                
                string insertQuery = "INSERT INTO Bill VALUES('" + lblfis.Text.Trim() + "', '" + lblsatici.Text.Trim() + "', '" + labeldate.Text.Trim() + "', " + grandtotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("sipariş Başarıyla Alındı");
                
                dBCon.CloseCon();
                getSellTable();
                ((DataTable)dGWSiparis.DataSource).Rows.Clear();
                Clear();
                
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }


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
            fis.PrintDataGridView(dGWSiparis);
        } 
        private void lblcros_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Urunler_Click(object sender, EventArgs e)
        {
            SaticiUrunlerForm urun = new SaticiUrunlerForm();
            urun.Show();
            this.Hide();
        }

        private void Tutar_Click(object sender, EventArgs e)
        {

        }

        private void dGWSiparis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGWUrun_Click(object sender, EventArgs e)
        {
           
        }

        private void dGWUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxsurunadi.Text = dGWUrun.CurrentRow.Cells[0].Value.ToString();
            txtboxFiyat.Text = dGWUrun.CurrentRow.Cells[1].Value.ToString();
        }



        private void lblcikis_MouseLeave(object sender, EventArgs e)
        {
            lblcikis.ForeColor = Color.SlateGray;
        }

        private void lblcikis_MouseEnter(object sender, EventArgs e)
        {
            lblcikis.ForeColor = Color.Red;
        }

        private void textBoxBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string barkod = textBoxBarkod.Text.Trim(); 
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

        private void btnIade_Click(object sender, EventArgs e)
        {
            İadeAlForm iadeAl = new İadeAlForm();
            iadeAl.Show();
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

        private void dGWSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxsurunadi.Text = dGWSiparis.CurrentRow.Cells[0].Value.ToString();
            txtboxFiyat.Text = dGWSiparis.CurrentRow.Cells[1].Value.ToString();
            txtboxAdet.Text = dGWSiparis.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnIade1_Click(object sender, EventArgs e)
        {
            bool adetkontrol = true;

            while (adetkontrol)
            {
                if (string.IsNullOrWhiteSpace(txtboxAdet.Text))
                {
                    MessageBox.Show("Lütfen adet giriniz");
                    break;
                }
                else
                {
                    int iadeAdet = Convert.ToInt32(txtboxAdet.Text);

                    if (iadeAdet > 0)
                    {
                        DataGridViewRow selectedRow = dGWSiparis.SelectedRows[0];
                        int mevcutAdet = Convert.ToInt32(selectedRow.Cells["Adet"].Value);

                        if (iadeAdet <= mevcutAdet)
                        {
                            
                            decimal fiyat = Convert.ToDecimal(selectedRow.Cells["Fiyat"].Value);
                            selectedRow.Cells["Adet"].Value = mevcutAdet - iadeAdet;
                            selectedRow.Cells["Tutar"].Value = fiyat * (mevcutAdet - iadeAdet);

                           
                            MessageBox.Show($"Ürün başarıyla {iadeAdet} adet iade edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            string updateQuery = "UPDATE Product SET ProdQty = ProdQty + @IadeAdedi WHERE ProdName = @ProdName";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, dBCon.GetCon()))
                            {
                                updateCommand.Parameters.AddWithValue("@IadeAdedi", iadeAdet);
                                updateCommand.Parameters.AddWithValue("@ProdName", txtboxsurunadi.Text);

                                dBCon.openCon();
                                updateCommand.ExecuteNonQuery();
                                dBCon.CloseCon();
                                getTable();
                                adetkontrol = false;
                            }

                            if (Convert.ToInt32(selectedRow.Cells["Adet"].Value) == 0)
                            {
                                dGWSiparis.Rows.Remove(selectedRow);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("İade edilecek adet, mevcut adetten fazla olamaz.");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("İade edilecek adet giriniz");
                        break;
                    }
                }
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public int GetMevcutStok(string productId)
        {
            int mevcutStok = 0;
            try
            {
                string selectQuery = "SELECT ProdQty FROM Product WHERE ProdId = @ProdId";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, dBCon.GetCon()))
                {
                    selectCommand.Parameters.AddWithValue("@ProdId", productId);

                    dBCon.openCon();

                    
                    object result = selectCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        mevcutStok = Convert.ToInt32(result);
                    }

                    dBCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            return mevcutStok;
        }
    }
}
