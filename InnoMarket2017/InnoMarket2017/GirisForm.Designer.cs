namespace InnoMarket2017
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpasword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblcros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxsecim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxpasword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpasword
            // 
            this.lblpasword.AutoSize = true;
            this.lblpasword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpasword.Location = new System.Drawing.Point(438, 364);
            this.lblpasword.Name = "lblpasword";
            this.lblpasword.Size = new System.Drawing.Size(90, 36);
            this.lblpasword.TabIndex = 1;
            this.lblpasword.Text = "Şifre:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusername.Location = new System.Drawing.Point(438, 280);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(203, 36);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Kullanıcı Adı:";
            // 
            // lblcros
            // 
            this.lblcros.AutoSize = true;
            this.lblcros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcros.ForeColor = System.Drawing.Color.Gray;
            this.lblcros.Location = new System.Drawing.Point(972, 9);
            this.lblcros.Name = "lblcros";
            this.lblcros.Size = new System.Drawing.Size(37, 36);
            this.lblcros.TabIndex = 6;
            this.lblcros.Text = "X";
            this.lblcros.Click += new System.EventHandler(this.lblcros_Click);
            this.lblcros.MouseEnter += new System.EventHandler(this.lblcros_MouseEnter);
            this.lblcros.MouseLeave += new System.EventHandler(this.lblcros_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(30, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "INNOMARKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Otomasyon sistemine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(30, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hoş Geldiniz";
            // 
            // comboboxsecim
            // 
            this.comboboxsecim.FormattingEnabled = true;
            this.comboboxsecim.Items.AddRange(new object[] {
            "Yönetici",
            "Kasiyer"});
            this.comboboxsecim.Location = new System.Drawing.Point(700, 212);
            this.comboboxsecim.Name = "comboboxsecim";
            this.comboboxsecim.Size = new System.Drawing.Size(229, 33);
            this.comboboxsecim.TabIndex = 10;
            this.comboboxsecim.Text = "Siz Kimsiniz?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(780, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "temizle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(700, 280);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(229, 30);
            this.txtboxusername.TabIndex = 12;
            // 
            // txtboxpasword
            // 
            this.txtboxpasword.Location = new System.Drawing.Point(700, 364);
            this.txtboxpasword.Name = "txtboxpasword";
            this.txtboxpasword.Size = new System.Drawing.Size(229, 30);
            this.txtboxpasword.TabIndex = 13;
            this.txtboxpasword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(700, 423);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(229, 37);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1021, 696);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxpasword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboboxsecim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcros);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblpasword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpasword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblcros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxsecim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtboxpasword;
        private System.Windows.Forms.Button btnLogin;
    }
}

