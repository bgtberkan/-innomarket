namespace InnoMarket2017
{
    partial class IadeGoruntuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatici = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.lblCikis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCros = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxWhy = new System.Windows.Forms.TextBox();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBoxBarkod = new System.Windows.Forms.TextBox();
            this.lblWhy = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBarkon = new System.Windows.Forms.Label();
            this.dGWIade = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWIade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnSatici);
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnUrunler);
            this.panel1.Controls.Add(this.btnSatis);
            this.panel1.Controls.Add(this.lblCikis);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSatici
            // 
            this.btnSatici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatici.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatici.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSatici.Location = new System.Drawing.Point(0, 436);
            this.btnSatici.Name = "btnSatici";
            this.btnSatici.Size = new System.Drawing.Size(200, 82);
            this.btnSatici.TabIndex = 5;
            this.btnSatici.Text = "Satıcı";
            this.btnSatici.UseVisualStyleBackColor = true;
            this.btnSatici.Click += new System.EventHandler(this.btnSatici_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.ForeColor = System.Drawing.Color.SlateGray;
            this.btnKategori.Location = new System.Drawing.Point(0, 354);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(200, 82);
            this.btnKategori.TabIndex = 4;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ForeColor = System.Drawing.Color.SlateGray;
            this.btnUrunler.Location = new System.Drawing.Point(0, 272);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(200, 82);
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSatis.Location = new System.Drawing.Point(0, 190);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(200, 82);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCikis.Location = new System.Drawing.Point(12, 639);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(122, 51);
            this.lblCikis.TabIndex = 1;
            this.lblCikis.Text = "Çıkış";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            this.lblCikis.MouseEnter += new System.EventHandler(this.lblCikis_MouseEnter);
            this.lblCikis.MouseLeave += new System.EventHandler(this.lblCikis_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 190);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InnoMarket2017.Properties.Resources.Return_Baggage;
            this.pictureBox1.Location = new System.Drawing.Point(54, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblCros);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 89);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "İadeler";
            // 
            // lblCros
            // 
            this.lblCros.AutoSize = true;
            this.lblCros.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCros.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCros.Location = new System.Drawing.Point(947, 9);
            this.lblCros.Name = "lblCros";
            this.lblCros.Size = new System.Drawing.Size(52, 51);
            this.lblCros.TabIndex = 0;
            this.lblCros.Text = "X";
            this.lblCros.Click += new System.EventHandler(this.lblCros_Click);
            this.lblCros.MouseEnter += new System.EventHandler(this.lblCros_MouseEnter);
            this.lblCros.MouseLeave += new System.EventHandler(this.lblCros_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.txtBoxWhy);
            this.panel4.Controls.Add(this.txtBoxFiyat);
            this.panel4.Controls.Add(this.txtBoxUrunAdi);
            this.panel4.Controls.Add(this.txtBoxBarkod);
            this.panel4.Controls.Add(this.lblWhy);
            this.panel4.Controls.Add(this.lblFiyat);
            this.panel4.Controls.Add(this.lblUrunAdi);
            this.panel4.Controls.Add(this.lblBarkon);
            this.panel4.Controls.Add(this.dGWIade);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 611);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtBoxWhy
            // 
            this.txtBoxWhy.Location = new System.Drawing.Point(252, 281);
            this.txtBoxWhy.MaxLength = 100;
            this.txtBoxWhy.Multiline = true;
            this.txtBoxWhy.Name = "txtBoxWhy";
            this.txtBoxWhy.ReadOnly = true;
            this.txtBoxWhy.Size = new System.Drawing.Size(185, 151);
            this.txtBoxWhy.TabIndex = 21;
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Location = new System.Drawing.Point(252, 223);
            this.txtBoxFiyat.Multiline = true;
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.ReadOnly = true;
            this.txtBoxFiyat.Size = new System.Drawing.Size(185, 35);
            this.txtBoxFiyat.TabIndex = 20;
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(252, 162);
            this.txtBoxUrunAdi.Multiline = true;
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.ReadOnly = true;
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(185, 35);
            this.txtBoxUrunAdi.TabIndex = 19;
            // 
            // txtBoxBarkod
            // 
            this.txtBoxBarkod.Location = new System.Drawing.Point(252, 95);
            this.txtBoxBarkod.MaxLength = 13;
            this.txtBoxBarkod.Multiline = true;
            this.txtBoxBarkod.Name = "txtBoxBarkod";
            this.txtBoxBarkod.Size = new System.Drawing.Size(185, 35);
            this.txtBoxBarkod.TabIndex = 18;
            // 
            // lblWhy
            // 
            this.lblWhy.AutoSize = true;
            this.lblWhy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWhy.Location = new System.Drawing.Point(45, 281);
            this.lblWhy.Name = "lblWhy";
            this.lblWhy.Size = new System.Drawing.Size(193, 36);
            this.lblWhy.TabIndex = 17;
            this.lblWhy.Text = "İade Sebebi:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(45, 223);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(93, 36);
            this.lblFiyat.TabIndex = 16;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(45, 162);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(151, 36);
            this.lblUrunAdi.TabIndex = 15;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblBarkon
            // 
            this.lblBarkon.AutoSize = true;
            this.lblBarkon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkon.Location = new System.Drawing.Point(45, 95);
            this.lblBarkon.Name = "lblBarkon";
            this.lblBarkon.Size = new System.Drawing.Size(125, 36);
            this.lblBarkon.TabIndex = 14;
            this.lblBarkon.Text = "Barkod:";
            // 
            // dGWIade
            // 
            this.dGWIade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWIade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWIade.Location = new System.Drawing.Point(540, 75);
            this.dGWIade.Name = "dGWIade";
            this.dGWIade.RowTemplate.Height = 24;
            this.dGWIade.Size = new System.Drawing.Size(390, 452);
            this.dGWIade.TabIndex = 0;
            this.dGWIade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWIade_CellClick);
            // 
            // IadeGoruntuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 700);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IadeGoruntuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İadeGörüntüleForm";
            this.Load += new System.EventHandler(this.İadeGörüntüleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWIade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dGWIade;
        private System.Windows.Forms.TextBox txtBoxWhy;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.TextBox txtBoxBarkod;
        private System.Windows.Forms.Label lblWhy;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBarkon;
        private System.Windows.Forms.Label lblCros;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnSatici;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}