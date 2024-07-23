namespace InnoMarket2017
{
    partial class UrunlerForm
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
            this.components = new System.ComponentModel.Container();
            this.urunpanel = new System.Windows.Forms.Panel();
            this.TxtboxMiktae = new System.Windows.Forms.TextBox();
            this.txtboxfiyat = new System.Windows.Forms.TextBox();
            this.txtboxurunadi = new System.Windows.Forms.TextBox();
            this.txtboxıd = new System.Windows.Forms.TextBox();
            this.dGUrunler = new System.Windows.Forms.DataGridView();
            this.btnAc = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.bgtguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcros = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsatis = new System.Windows.Forms.Button();
            this.btnkatagori = new System.Windows.Forms.Button();
            this.btnsatici = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.urunpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunpanel
            // 
            this.urunpanel.BackColor = System.Drawing.Color.Lavender;
            this.urunpanel.Controls.Add(this.TxtboxMiktae);
            this.urunpanel.Controls.Add(this.txtboxfiyat);
            this.urunpanel.Controls.Add(this.txtboxurunadi);
            this.urunpanel.Controls.Add(this.txtboxıd);
            this.urunpanel.Controls.Add(this.dGUrunler);
            this.urunpanel.Controls.Add(this.btnAc);
            this.urunpanel.Controls.Add(this.comboBox1);
            this.urunpanel.Controls.Add(this.pictureBox1);
            this.urunpanel.Controls.Add(this.btnyenile);
            this.urunpanel.Controls.Add(this.comboBoxSearch);
            this.urunpanel.Controls.Add(this.btnsil);
            this.urunpanel.Controls.Add(this.bgtguncelle);
            this.urunpanel.Controls.Add(this.btnekle);
            this.urunpanel.Controls.Add(this.comboBoxCat);
            this.urunpanel.Controls.Add(this.label4);
            this.urunpanel.Controls.Add(this.label3);
            this.urunpanel.Controls.Add(this.label2);
            this.urunpanel.Controls.Add(this.label1);
            this.urunpanel.Controls.Add(this.lblusername);
            this.urunpanel.Location = new System.Drawing.Point(195, 87);
            this.urunpanel.Name = "urunpanel";
            this.urunpanel.Size = new System.Drawing.Size(1017, 707);
            this.urunpanel.TabIndex = 0;
            this.urunpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.urunpanel_Paint);
            // 
            // TxtboxMiktae
            // 
            this.TxtboxMiktae.Location = new System.Drawing.Point(174, 252);
            this.TxtboxMiktae.Name = "TxtboxMiktae";
            this.TxtboxMiktae.Size = new System.Drawing.Size(187, 22);
            this.TxtboxMiktae.TabIndex = 27;
            // 
            // txtboxfiyat
            // 
            this.txtboxfiyat.Location = new System.Drawing.Point(174, 187);
            this.txtboxfiyat.Name = "txtboxfiyat";
            this.txtboxfiyat.Size = new System.Drawing.Size(187, 22);
            this.txtboxfiyat.TabIndex = 26;
            // 
            // txtboxurunadi
            // 
            this.txtboxurunadi.Location = new System.Drawing.Point(175, 120);
            this.txtboxurunadi.Name = "txtboxurunadi";
            this.txtboxurunadi.Size = new System.Drawing.Size(186, 22);
            this.txtboxurunadi.TabIndex = 25;
            // 
            // txtboxıd
            // 
            this.txtboxıd.Location = new System.Drawing.Point(179, 55);
            this.txtboxıd.MaxLength = 13;
            this.txtboxıd.Name = "txtboxıd";
            this.txtboxıd.Size = new System.Drawing.Size(182, 22);
            this.txtboxıd.TabIndex = 23;
            this.txtboxıd.TextChanged += new System.EventHandler(this.txtboxıd_TextChanged);
            // 
            // dGUrunler
            // 
            this.dGUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dGUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGUrunler.Location = new System.Drawing.Point(409, 124);
            this.dGUrunler.Name = "dGUrunler";
            this.dGUrunler.RowTemplate.Height = 24;
            this.dGUrunler.Size = new System.Drawing.Size(562, 441);
            this.dGUrunler.TabIndex = 24;
            this.dGUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGUrunler_CellClick);
            // 
            // btnAc
            // 
            this.btnAc.FlatAppearance.BorderSize = 0;
            this.btnAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAc.Location = new System.Drawing.Point(23, 496);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 35);
            this.btnAc.TabIndex = 23;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 433);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(221, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnyenile
            // 
            this.btnyenile.FlatAppearance.BorderSize = 0;
            this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenile.Location = new System.Drawing.Point(782, 69);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(168, 31);
            this.btnyenile.TabIndex = 19;
            this.btnyenile.Text = "Listeyi Yenile";
            this.btnyenile.UseVisualStyleBackColor = true;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(516, 76);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(229, 24);
            this.comboBoxSearch.TabIndex = 17;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // btnsil
            // 
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(259, 353);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 35);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // bgtguncelle
            // 
            this.bgtguncelle.FlatAppearance.BorderSize = 0;
            this.bgtguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgtguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bgtguncelle.Location = new System.Drawing.Point(123, 353);
            this.bgtguncelle.Name = "bgtguncelle";
            this.bgtguncelle.Size = new System.Drawing.Size(105, 35);
            this.bgtguncelle.TabIndex = 15;
            this.bgtguncelle.Text = "Güncelle";
            this.bgtguncelle.UseVisualStyleBackColor = true;
            this.bgtguncelle.Click += new System.EventHandler(this.bgtguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.FlatAppearance.BorderSize = 0;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(23, 353);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 35);
            this.btnekle.TabIndex = 14;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(174, 305);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(187, 24);
            this.comboBoxCat.TabIndex = 13;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusername.Location = new System.Drawing.Point(17, 41);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(125, 36);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "Barkod:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(398, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ürünler Listesi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblcros
            // 
            this.lblcros.AutoSize = true;
            this.lblcros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcros.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcros.ForeColor = System.Drawing.Color.SlateGray;
            this.lblcros.Location = new System.Drawing.Point(947, 9);
            this.lblcros.Name = "lblcros";
            this.lblcros.Size = new System.Drawing.Size(52, 51);
            this.lblcros.TabIndex = 7;
            this.lblcros.Text = "X";
            this.lblcros.Click += new System.EventHandler(this.lblcros_Click);
            this.lblcros.MouseEnter += new System.EventHandler(this.lblcros_MouseEnter);
            this.lblcros.MouseLeave += new System.EventHandler(this.lblcros_MouseLeave);
            // 
            // btncikis
            // 
            this.btncikis.FlatAppearance.BorderSize = 0;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btncikis.Location = new System.Drawing.Point(0, 570);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(128, 82);
            this.btncikis.TabIndex = 22;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.MouseEnter += new System.EventHandler(this.btncikis_MouseEnter);
            this.btncikis.MouseLeave += new System.EventHandler(this.btncikis_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 190);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InnoMarket2017.Properties.Resources.Food_Receiver;
            this.pictureBox2.Location = new System.Drawing.Point(60, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnIade);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnsatis);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnkatagori);
            this.panel1.Controls.Add(this.btnsatici);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnIade
            // 
            this.btnIade.FlatAppearance.BorderSize = 0;
            this.btnIade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIade.ForeColor = System.Drawing.Color.SlateGray;
            this.btnIade.Location = new System.Drawing.Point(0, 355);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(200, 82);
            this.btnIade.TabIndex = 23;
            this.btnIade.Text = "İade";
            this.btnIade.UseVisualStyleBackColor = true;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(0, 649);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 51);
            this.label6.TabIndex = 22;
            this.label6.Text = "Çıkış";
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // btnsatis
            // 
            this.btnsatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsatis.FlatAppearance.BorderSize = 0;
            this.btnsatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatis.ForeColor = System.Drawing.Color.SlateGray;
            this.btnsatis.Location = new System.Drawing.Point(0, 190);
            this.btnsatis.Name = "btnsatis";
            this.btnsatis.Size = new System.Drawing.Size(200, 82);
            this.btnsatis.TabIndex = 21;
            this.btnsatis.Text = "Satış";
            this.btnsatis.UseVisualStyleBackColor = true;
            this.btnsatis.Click += new System.EventHandler(this.btnsatis_Click);
            // 
            // btnkatagori
            // 
            this.btnkatagori.FlatAppearance.BorderSize = 0;
            this.btnkatagori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkatagori.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkatagori.ForeColor = System.Drawing.Color.SlateGray;
            this.btnkatagori.Location = new System.Drawing.Point(0, 267);
            this.btnkatagori.Name = "btnkatagori";
            this.btnkatagori.Size = new System.Drawing.Size(200, 82);
            this.btnkatagori.TabIndex = 16;
            this.btnkatagori.Text = "Katagori";
            this.btnkatagori.UseVisualStyleBackColor = true;
            this.btnkatagori.Click += new System.EventHandler(this.btnkatagori_Click);
            // 
            // btnsatici
            // 
            this.btnsatici.FlatAppearance.BorderSize = 0;
            this.btnsatici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsatici.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatici.ForeColor = System.Drawing.Color.SlateGray;
            this.btnsatici.Location = new System.Drawing.Point(3, 443);
            this.btnsatici.Name = "btnsatici";
            this.btnsatici.Size = new System.Drawing.Size(200, 82);
            this.btnsatici.TabIndex = 15;
            this.btnsatici.Text = "Satıcı";
            this.btnsatici.UseVisualStyleBackColor = true;
            this.btnsatici.Click += new System.EventHandler(this.btnsatici_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblcros);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 89);
            this.panel3.TabIndex = 24;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1212, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.urunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunlerForm";
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            this.urunpanel.ResumeLayout(false);
            this.urunpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel urunpanel;
        private System.Windows.Forms.Label lblcros;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button bgtguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dGUrunler;
        private System.Windows.Forms.TextBox TxtboxMiktae;
        private System.Windows.Forms.TextBox txtboxfiyat;
        private System.Windows.Forms.TextBox txtboxurunadi;
        private System.Windows.Forms.TextBox txtboxıd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.Button btnsatici;
        private System.Windows.Forms.Button btnkatagori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}