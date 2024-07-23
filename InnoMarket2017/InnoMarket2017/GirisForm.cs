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
using System.Runtime.InteropServices;

namespace InnoMarket2017
{
    public partial class GirisForm : Form
    { DBConnect dbCon = new DBConnect();
      public static string sellerName;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeft,
             int nRigt,
             int nTop,
             int nBottom,
             int nWidthEllipse,
             int nHeightEllipse
            );

        public GirisForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void lblcros_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void lblcros_MouseEnter(object sender, EventArgs e)
        {
            lblcros.ForeColor = Color.Red;
        }

        private void lblcros_MouseLeave(object sender, EventArgs e)
        {
            lblcros.ForeColor = Color.SlateGray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtboxpasword.Clear();
            txtboxusername.Clear();
        }

       

        private void GirisForm_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 30, 30
                ));
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxusername.Text == "" || txtboxpasword.Text == "")
            {
                MessageBox.Show("Lütfen Yukardaki Alanları Doldurun", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboboxsecim.SelectedIndex > -1)
                {
                    if (comboboxsecim.SelectedItem.ToString() == "Yönetici")
                    {
                        if (txtboxusername.Text == "Inno" && txtboxpasword.Text == "BGTinnobgt17")
                        {
                            UrunlerForm urunler = new UrunlerForm();
                            urunler.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Yönetici Girişi", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        string selectQuary = "SELECT * FROM seller WHERE SellerName = '" + txtboxusername.Text + "' AND SellerPass = '" + txtboxpasword.Text + "'";
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuary, dbCon.GetCon());
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            sellerName = txtboxusername.Text;
                            SatisForm satis = new SatisForm();
                            satis.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Satıcı Girişi", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Rol Secin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
