namespace InnoMarket2017
{
    partial class İadeAlForm
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
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.siparis = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCros = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.txtBoxWhy = new System.Windows.Forms.TextBox();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBoxBarkod = new System.Windows.Forms.TextBox();
            this.lblWhy = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBarkon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblCikis);
            this.panel1.Controls.Add(this.btnUrunler);
            this.panel1.Controls.Add(this.siparis);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCikis.Location = new System.Drawing.Point(12, 639);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(122, 51);
            this.lblCikis.TabIndex = 3;
            this.lblCikis.Text = "Çıkış";
            this.lblCikis.MouseEnter += new System.EventHandler(this.lblCikis_MouseEnter);
            this.lblCikis.MouseLeave += new System.EventHandler(this.lblCikis_MouseLeave);
            // 
            // btnUrunler
            // 
            this.btnUrunler.AutoEllipsis = true;
            this.btnUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ForeColor = System.Drawing.Color.SlateGray;
            this.btnUrunler.Location = new System.Drawing.Point(0, 272);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(200, 82);
            this.btnUrunler.TabIndex = 2;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // siparis
            // 
            this.siparis.AutoEllipsis = true;
            this.siparis.Dock = System.Windows.Forms.DockStyle.Top;
            this.siparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis.ForeColor = System.Drawing.Color.SlateGray;
            this.siparis.Location = new System.Drawing.Point(0, 190);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(200, 82);
            this.siparis.TabIndex = 1;
            this.siparis.Text = "Satış";
            this.siparis.UseVisualStyleBackColor = true;
            this.siparis.Click += new System.EventHandler(this.siparis_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 190);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 190);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InnoMarket2017.Properties.Resources.Return_Baggage;
            this.pictureBox1.Location = new System.Drawing.Point(60, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 89);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "İade";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lblKalan);
            this.panel3.Controls.Add(this.txtBoxWhy);
            this.panel3.Controls.Add(this.txtBoxFiyat);
            this.panel3.Controls.Add(this.txtBoxUrunAdi);
            this.panel3.Controls.Add(this.txtBoxBarkod);
            this.panel3.Controls.Add(this.lblWhy);
            this.panel3.Controls.Add(this.lblFiyat);
            this.panel3.Controls.Add(this.lblUrunAdi);
            this.panel3.Controls.Add(this.lblBarkon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 611);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(275, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(414, 458);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(0, 17);
            this.lblKalan.TabIndex = 13;
            // 
            // txtBoxWhy
            // 
            this.txtBoxWhy.Location = new System.Drawing.Point(275, 287);
            this.txtBoxWhy.MaxLength = 100;
            this.txtBoxWhy.Multiline = true;
            this.txtBoxWhy.Name = "txtBoxWhy";
            this.txtBoxWhy.Size = new System.Drawing.Size(185, 151);
            this.txtBoxWhy.TabIndex = 12;
            this.txtBoxWhy.TextChanged += new System.EventHandler(this.txtBoxWhy_TextChanged);
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Location = new System.Drawing.Point(275, 229);
            this.txtBoxFiyat.Multiline = true;
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.Size = new System.Drawing.Size(185, 35);
            this.txtBoxFiyat.TabIndex = 11;
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(275, 168);
            this.txtBoxUrunAdi.Multiline = true;
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(185, 35);
            this.txtBoxUrunAdi.TabIndex = 10;
            // 
            // txtBoxBarkod
            // 
            this.txtBoxBarkod.Location = new System.Drawing.Point(275, 101);
            this.txtBoxBarkod.MaxLength = 13;
            this.txtBoxBarkod.Multiline = true;
            this.txtBoxBarkod.Name = "txtBoxBarkod";
            this.txtBoxBarkod.Size = new System.Drawing.Size(185, 35);
            this.txtBoxBarkod.TabIndex = 9;
            // 
            // lblWhy
            // 
            this.lblWhy.AutoSize = true;
            this.lblWhy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWhy.Location = new System.Drawing.Point(68, 287);
            this.lblWhy.Name = "lblWhy";
            this.lblWhy.Size = new System.Drawing.Size(193, 36);
            this.lblWhy.TabIndex = 8;
            this.lblWhy.Text = "İade Sebebi:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(68, 229);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(93, 36);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(68, 168);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(151, 36);
            this.lblUrunAdi.TabIndex = 6;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblBarkon
            // 
            this.lblBarkon.AutoSize = true;
            this.lblBarkon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkon.Location = new System.Drawing.Point(68, 101);
            this.lblBarkon.Name = "lblBarkon";
            this.lblBarkon.Size = new System.Drawing.Size(125, 36);
            this.lblBarkon.TabIndex = 5;
            this.lblBarkon.Text = "Barkod:";
            // 
            // İadeAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "İadeAlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İadeAl";
            this.Load += new System.EventHandler(this.İadeAl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button siparis;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCros;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.TextBox txtBoxBarkod;
        private System.Windows.Forms.Label lblWhy;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBarkon;
        private System.Windows.Forms.TextBox txtBoxWhy;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}