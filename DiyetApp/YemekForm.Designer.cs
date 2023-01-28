namespace DiyetApp
{
    partial class YemekForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekForm));
            this.dtZaman = new System.Windows.Forms.DateTimePicker();
            this.rbSabah = new System.Windows.Forms.RadioButton();
            this.rbOgle = new System.Windows.Forms.RadioButton();
            this.rbAksam = new System.Windows.Forms.RadioButton();
            this.dgvYemekler = new System.Windows.Forms.DataGridView();
            this.gbxZaman = new System.Windows.Forms.GroupBox();
            this.gbxKahvalti = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSabah = new System.Windows.Forms.DataGridView();
            this.gbxOglen = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOgle = new System.Windows.Forms.DataGridView();
            this.gbxAksam = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAksam = new System.Windows.Forms.DataGridView();
            this.prbKalori = new System.Windows.Forms.ProgressBar();
            this.txtYemek = new System.Windows.Forms.TextBox();
            this.cmbPorsiyon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYemekEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHedefKalori = new System.Windows.Forms.Label();
            this.btnOgunYemekSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblMevcutKalori = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            this.gbxZaman.SuspendLayout();
            this.gbxKahvalti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabah)).BeginInit();
            this.gbxOglen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgle)).BeginInit();
            this.gbxAksam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtZaman
            // 
            this.dtZaman.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtZaman.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.dtZaman.Enabled = false;
            this.dtZaman.Location = new System.Drawing.Point(17, 27);
            this.dtZaman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtZaman.Name = "dtZaman";
            this.dtZaman.Size = new System.Drawing.Size(250, 27);
            this.dtZaman.TabIndex = 0;
            // 
            // rbSabah
            // 
            this.rbSabah.AutoSize = true;
            this.rbSabah.ForeColor = System.Drawing.Color.Teal;
            this.rbSabah.Location = new System.Drawing.Point(7, 29);
            this.rbSabah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSabah.Name = "rbSabah";
            this.rbSabah.Size = new System.Drawing.Size(78, 24);
            this.rbSabah.TabIndex = 0;
            this.rbSabah.TabStop = true;
            this.rbSabah.Text = "SABAH";
            this.rbSabah.UseVisualStyleBackColor = true;
            // 
            // rbOgle
            // 
            this.rbOgle.AutoSize = true;
            this.rbOgle.ForeColor = System.Drawing.Color.Teal;
            this.rbOgle.Location = new System.Drawing.Point(86, 29);
            this.rbOgle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOgle.Name = "rbOgle";
            this.rbOgle.Size = new System.Drawing.Size(77, 24);
            this.rbOgle.TabIndex = 1;
            this.rbOgle.TabStop = true;
            this.rbOgle.Text = "ÖĞLEN";
            this.rbOgle.UseVisualStyleBackColor = true;
            // 
            // rbAksam
            // 
            this.rbAksam.AutoSize = true;
            this.rbAksam.ForeColor = System.Drawing.Color.Teal;
            this.rbAksam.Location = new System.Drawing.Point(165, 29);
            this.rbAksam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAksam.Name = "rbAksam";
            this.rbAksam.Size = new System.Drawing.Size(80, 24);
            this.rbAksam.TabIndex = 2;
            this.rbAksam.TabStop = true;
            this.rbAksam.Text = "AKŞAM";
            this.rbAksam.UseVisualStyleBackColor = true;
            // 
            // dgvYemekler
            // 
            this.dgvYemekler.AllowUserToAddRows = false;
            this.dgvYemekler.AllowUserToDeleteRows = false;
            this.dgvYemekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYemekler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYemekler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekler.Location = new System.Drawing.Point(274, 27);
            this.dgvYemekler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvYemekler.MultiSelect = false;
            this.dgvYemekler.Name = "dgvYemekler";
            this.dgvYemekler.ReadOnly = true;
            this.dgvYemekler.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvYemekler.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYemekler.RowTemplate.Height = 25;
            this.dgvYemekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYemekler.Size = new System.Drawing.Size(695, 159);
            this.dgvYemekler.TabIndex = 3;
            this.dgvYemekler.SelectionChanged += new System.EventHandler(this.dgvYemekler_SelectionChanged);
            // 
            // gbxZaman
            // 
            this.gbxZaman.Controls.Add(this.rbSabah);
            this.gbxZaman.Controls.Add(this.rbOgle);
            this.gbxZaman.Controls.Add(this.rbAksam);
            this.gbxZaman.ForeColor = System.Drawing.Color.OrangeRed;
            this.gbxZaman.Location = new System.Drawing.Point(17, 65);
            this.gbxZaman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxZaman.Name = "gbxZaman";
            this.gbxZaman.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxZaman.Size = new System.Drawing.Size(250, 73);
            this.gbxZaman.TabIndex = 1;
            this.gbxZaman.TabStop = false;
            this.gbxZaman.Text = "Öğün";
            // 
            // gbxKahvalti
            // 
            this.gbxKahvalti.Controls.Add(this.label1);
            this.gbxKahvalti.Controls.Add(this.dgvSabah);
            this.gbxKahvalti.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxKahvalti.ForeColor = System.Drawing.Color.OrangeRed;
            this.gbxKahvalti.Location = new System.Drawing.Point(17, 243);
            this.gbxKahvalti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxKahvalti.Name = "gbxKahvalti";
            this.gbxKahvalti.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxKahvalti.Size = new System.Drawing.Size(361, 224);
            this.gbxKahvalti.TabIndex = 6;
            this.gbxKahvalti.TabStop = false;
            this.gbxKahvalti.Text = "SABAH";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOPLAM:";
            // 
            // dgvSabah
            // 
            this.dgvSabah.AllowUserToAddRows = false;
            this.dgvSabah.AllowUserToDeleteRows = false;
            this.dgvSabah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSabah.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSabah.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSabah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabah.Location = new System.Drawing.Point(7, 29);
            this.dgvSabah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSabah.MultiSelect = false;
            this.dgvSabah.Name = "dgvSabah";
            this.dgvSabah.ReadOnly = true;
            this.dgvSabah.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvSabah.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSabah.RowTemplate.Height = 25;
            this.dgvSabah.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSabah.Size = new System.Drawing.Size(347, 156);
            this.dgvSabah.TabIndex = 0;
            this.dgvSabah.SelectionChanged += new System.EventHandler(this.dgvSabah_SelectionChanged);
            // 
            // gbxOglen
            // 
            this.gbxOglen.Controls.Add(this.label2);
            this.gbxOglen.Controls.Add(this.dgvOgle);
            this.gbxOglen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxOglen.ForeColor = System.Drawing.Color.Teal;
            this.gbxOglen.Location = new System.Drawing.Point(385, 243);
            this.gbxOglen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxOglen.Name = "gbxOglen";
            this.gbxOglen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxOglen.Size = new System.Drawing.Size(361, 224);
            this.gbxOglen.TabIndex = 7;
            this.gbxOglen.TabStop = false;
            this.gbxOglen.Text = "ÖĞLEN";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "TOPLAM:";
            // 
            // dgvOgle
            // 
            this.dgvOgle.AllowUserToAddRows = false;
            this.dgvOgle.AllowUserToDeleteRows = false;
            this.dgvOgle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOgle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgle.Location = new System.Drawing.Point(7, 29);
            this.dgvOgle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOgle.MultiSelect = false;
            this.dgvOgle.Name = "dgvOgle";
            this.dgvOgle.ReadOnly = true;
            this.dgvOgle.RowHeadersWidth = 51;
            this.dgvOgle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOgle.RowTemplate.Height = 25;
            this.dgvOgle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgle.Size = new System.Drawing.Size(347, 156);
            this.dgvOgle.TabIndex = 0;
            this.dgvOgle.SelectionChanged += new System.EventHandler(this.dgvOgle_SelectionChanged);
            // 
            // gbxAksam
            // 
            this.gbxAksam.Controls.Add(this.label3);
            this.gbxAksam.Controls.Add(this.dgvAksam);
            this.gbxAksam.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxAksam.ForeColor = System.Drawing.Color.OrangeRed;
            this.gbxAksam.Location = new System.Drawing.Point(753, 243);
            this.gbxAksam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAksam.Name = "gbxAksam";
            this.gbxAksam.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAksam.Size = new System.Drawing.Size(361, 224);
            this.gbxAksam.TabIndex = 8;
            this.gbxAksam.TabStop = false;
            this.gbxAksam.Text = "AKŞAM";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "TOPLAM:";
            // 
            // dgvAksam
            // 
            this.dgvAksam.AllowUserToAddRows = false;
            this.dgvAksam.AllowUserToDeleteRows = false;
            this.dgvAksam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAksam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAksam.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAksam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAksam.Location = new System.Drawing.Point(7, 29);
            this.dgvAksam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAksam.MultiSelect = false;
            this.dgvAksam.Name = "dgvAksam";
            this.dgvAksam.ReadOnly = true;
            this.dgvAksam.RowHeadersWidth = 51;
            this.dgvAksam.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAksam.RowTemplate.Height = 25;
            this.dgvAksam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAksam.Size = new System.Drawing.Size(347, 156);
            this.dgvAksam.TabIndex = 0;
            this.dgvAksam.SelectionChanged += new System.EventHandler(this.dgvAksam_SelectionChanged);
            // 
            // prbKalori
            // 
            this.prbKalori.Location = new System.Drawing.Point(310, 557);
            this.prbKalori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prbKalori.Name = "prbKalori";
            this.prbKalori.Size = new System.Drawing.Size(557, 45);
            this.prbKalori.TabIndex = 11;
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(17, 147);
            this.txtYemek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(220, 27);
            this.txtYemek.TabIndex = 2;
            this.txtYemek.TextChanged += new System.EventHandler(this.txtYemek_TextChanged);
            // 
            // cmbPorsiyon
            // 
            this.cmbPorsiyon.FormattingEnabled = true;
            this.cmbPorsiyon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPorsiyon.Location = new System.Drawing.Point(976, 65);
            this.cmbPorsiyon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPorsiyon.Name = "cmbPorsiyon";
            this.cmbPorsiyon.Size = new System.Drawing.Size(138, 28);
            this.cmbPorsiyon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(976, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "PORSİYON:";
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnYemekEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYemekEkle.ForeColor = System.Drawing.Color.White;
            this.btnYemekEkle.Location = new System.Drawing.Point(976, 104);
            this.btnYemekEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(138, 81);
            this.btnYemekEkle.TabIndex = 5;
            this.btnYemekEkle.Text = "EKLE";
            this.btnYemekEkle.UseVisualStyleBackColor = false;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(211, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "kcal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(954, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "kcal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHedefKalori
            // 
            this.lblHedefKalori.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHedefKalori.ForeColor = System.Drawing.Color.Teal;
            this.lblHedefKalori.Location = new System.Drawing.Point(906, 572);
            this.lblHedefKalori.Name = "lblHedefKalori";
            this.lblHedefKalori.Size = new System.Drawing.Size(42, 31);
            this.lblHedefKalori.TabIndex = 23;
            this.lblHedefKalori.Text = "2550";
            this.lblHedefKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOgunYemekSil
            // 
            this.btnOgunYemekSil.BackColor = System.Drawing.Color.Gold;
            this.btnOgunYemekSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgunYemekSil.ForeColor = System.Drawing.Color.White;
            this.btnOgunYemekSil.Location = new System.Drawing.Point(497, 475);
            this.btnOgunYemekSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOgunYemekSil.Name = "btnOgunYemekSil";
            this.btnOgunYemekSil.Size = new System.Drawing.Size(136, 43);
            this.btnOgunYemekSil.TabIndex = 9;
            this.btnOgunYemekSil.Text = "YEMEK SİL";
            this.btnOgunYemekSil.UseVisualStyleBackColor = false;
            this.btnOgunYemekSil.Click += new System.EventHandler(this.btnOgunYemekSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(1041, 614);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(73, 73);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblMevcutKalori
            // 
            this.lblMevcutKalori.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMevcutKalori.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMevcutKalori.Location = new System.Drawing.Point(163, 572);
            this.lblMevcutKalori.Name = "lblMevcutKalori";
            this.lblMevcutKalori.Size = new System.Drawing.Size(42, 31);
            this.lblMevcutKalori.TabIndex = 21;
            this.lblMevcutKalori.Text = "0";
            this.lblMevcutKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(123, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "ALINAN KALORİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(873, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "HEDEF KALORİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // YemekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOgunYemekSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHedefKalori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMevcutKalori);
            this.Controls.Add(this.btnYemekEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPorsiyon);
            this.Controls.Add(this.txtYemek);
            this.Controls.Add(this.prbKalori);
            this.Controls.Add(this.gbxAksam);
            this.Controls.Add(this.gbxOglen);
            this.Controls.Add(this.gbxKahvalti);
            this.Controls.Add(this.gbxZaman);
            this.Controls.Add(this.dgvYemekler);
            this.Controls.Add(this.dtZaman);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "YemekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğün Ekleme/Çıkartma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            this.gbxZaman.ResumeLayout(false);
            this.gbxZaman.PerformLayout();
            this.gbxKahvalti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabah)).EndInit();
            this.gbxOglen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgle)).EndInit();
            this.gbxAksam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtZaman;
        private RadioButton rbSabah;
        private RadioButton rbOgle;
        private RadioButton rbAksam;
        private DataGridView dgvYemekler;
        private GroupBox gbxZaman;
        private GroupBox gbxKahvalti;
        private Label label1;
        private DataGridView dgvSabah;
        private GroupBox gbxOglen;
        private Label label2;
        private DataGridView dgvOgle;
        private GroupBox gbxAksam;
        private Label label3;
        private DataGridView dgvAksam;
        private ProgressBar prbKalori;
        private TextBox txtYemek;
        private Label label5;
        private ComboBox cmbPorsiyon;
        private Button btnYemekEkle;
        private Label label7;
        private Label label4;
        private Label lblHedefKalori;
        private Button btnOgunYemekSil;
        private Button btnGeri;
        private Label lblMevcutKalori;
        private Label label6;
        private Label label8;
        private PictureBox pictureBox1;
    }
}