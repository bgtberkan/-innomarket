using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoMarket2017
{
    public partial class GirisAnimasyonForm : Form
    {
        public GirisAnimasyonForm()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void GirisAnimasyonForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 2;
            label2.Left += 3;
            progressBar1.Value = sayac;
            if (progressBar1.Value == 100 && label1.Top <=206 )
            {

                
                progressBar1.Value = 0;
                timer1.Stop();
                GirisForm giris = new GirisForm();
                this.Hide();
                giris.Show();
            }
        }

        private void girisdolumprogresbar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
