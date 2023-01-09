namespace DiyetApp
{
    partial class GirisForm
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
            this.txtGizliYanit = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnUnuttum = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblSorular = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGizliYanit
            // 
            this.txtGizliYanit.Location = new System.Drawing.Point(192, 134);
            this.txtGizliYanit.Name = "txtGizliYanit";
            this.txtGizliYanit.Size = new System.Drawing.Size(224, 29);
            this.txtGizliYanit.TabIndex = 3;
            this.txtGizliYanit.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(192, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 29);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Visible = false;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(15, 74);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(138, 21);
            this.lblTelefon.TabIndex = 23;
            this.lblTelefon.Text = "Telefon Numarası: ";
            this.lblTelefon.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(91, 11);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.Visible = false;
            // 
            // btnUnuttum
            // 
            this.btnUnuttum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnuttum.Location = new System.Drawing.Point(169, 319);
            this.btnUnuttum.Name = "btnUnuttum";
            this.btnUnuttum.Size = new System.Drawing.Size(82, 53);
            this.btnUnuttum.TabIndex = 21;
            this.btnUnuttum.Text = "Şifremi Unuttum";
            this.btnUnuttum.UseVisualStyleBackColor = true;
            this.btnUnuttum.Click += new System.EventHandler(this.btnUnuttum_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Location = new System.Drawing.Point(345, 318);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(82, 53);
            this.btnUyeOl.TabIndex = 20;
            this.btnUyeOl.Text = "Üye Ol!";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(192, 262);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(224, 29);
            this.txtSifre.TabIndex = 5;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(192, 199);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(224, 29);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminGiris.Location = new System.Drawing.Point(468, 12);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(148, 58);
            this.btnAdminGiris.TabIndex = 16;
            this.btnAdminGiris.Text = "Admin Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(103, 265);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 21);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(50, 202);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(98, 21);
            this.lblKullaniciAdi.TabIndex = 6;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(179, 8);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(248, 178);
            this.btnGirisYap.TabIndex = 13;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(192, 71);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(224, 29);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.Visible = false;
            // 
            // lblSorular
            // 
            this.lblSorular.AutoSize = true;
            this.lblSorular.Location = new System.Drawing.Point(9, 137);
            this.lblSorular.Name = "lblSorular";
            this.lblSorular.Size = new System.Drawing.Size(140, 21);
            this.lblSorular.TabIndex = 10;
            this.lblSorular.Text = "Anne Kızlık Soyadı:";
            this.lblSorular.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(257, 317);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(82, 53);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 421);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblSorular);
            this.Controls.Add(this.txtGizliYanit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnUnuttum);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalori Takibe Hoşgeldiniz!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGizliYanit;
        private TextBox txtEmail;
        private Label lblTelefon;
        private Label lblEmail;
        private Button btnUnuttum;
        private Button btnUyeOl;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Button btnAdminGiris;
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private Button btnGirisYap;
        private TextBox txtTelefon;
        private Label lblSorular;
        private Button btnKaydet;
    }
}