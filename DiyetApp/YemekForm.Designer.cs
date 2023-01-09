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
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            this.gbxZaman.SuspendLayout();
            this.gbxKahvalti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabah)).BeginInit();
            this.gbxOglen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgle)).BeginInit();
            this.gbxAksam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksam)).BeginInit();
            this.SuspendLayout();
            // 
            // dtZaman
            // 
            this.dtZaman.Location = new System.Drawing.Point(15, 20);
            this.dtZaman.Name = "dtZaman";
            this.dtZaman.Size = new System.Drawing.Size(219, 23);
            this.dtZaman.TabIndex = 0;
            // 
            // rbSabah
            // 
            this.rbSabah.AutoSize = true;
            this.rbSabah.Location = new System.Drawing.Point(6, 22);
            this.rbSabah.Name = "rbSabah";
            this.rbSabah.Size = new System.Drawing.Size(63, 19);
            this.rbSabah.TabIndex = 1;
            this.rbSabah.TabStop = true;
            this.rbSabah.Text = "SABAH";
            this.rbSabah.UseVisualStyleBackColor = true;
            // 
            // rbOgle
            // 
            this.rbOgle.AutoSize = true;
            this.rbOgle.Location = new System.Drawing.Point(75, 22);
            this.rbOgle.Name = "rbOgle";
            this.rbOgle.Size = new System.Drawing.Size(63, 19);
            this.rbOgle.TabIndex = 2;
            this.rbOgle.TabStop = true;
            this.rbOgle.Text = "ÖĞLEN";
            this.rbOgle.UseVisualStyleBackColor = true;
            // 
            // rbAksam
            // 
            this.rbAksam.AutoSize = true;
            this.rbAksam.Location = new System.Drawing.Point(144, 22);
            this.rbAksam.Name = "rbAksam";
            this.rbAksam.Size = new System.Drawing.Size(65, 19);
            this.rbAksam.TabIndex = 3;
            this.rbAksam.TabStop = true;
            this.rbAksam.Text = "AKŞAM";
            this.rbAksam.UseVisualStyleBackColor = true;
            // 
            // dgvYemekler
            // 
            this.dgvYemekler.AllowUserToAddRows = false;
            this.dgvYemekler.AllowUserToDeleteRows = false;
            this.dgvYemekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvYemekler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekler.Location = new System.Drawing.Point(240, 20);
            this.dgvYemekler.MultiSelect = false;
            this.dgvYemekler.Name = "dgvYemekler";
            this.dgvYemekler.ReadOnly = true;
            this.dgvYemekler.RowTemplate.Height = 25;
            this.dgvYemekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYemekler.Size = new System.Drawing.Size(608, 119);
            this.dgvYemekler.TabIndex = 5;
            this.dgvYemekler.SelectionChanged += new System.EventHandler(this.dgvYemekler_SelectionChanged);
            // 
            // gbxZaman
            // 
            this.gbxZaman.Controls.Add(this.rbSabah);
            this.gbxZaman.Controls.Add(this.rbOgle);
            this.gbxZaman.Controls.Add(this.rbAksam);
            this.gbxZaman.Location = new System.Drawing.Point(15, 49);
            this.gbxZaman.Name = "gbxZaman";
            this.gbxZaman.Size = new System.Drawing.Size(219, 55);
            this.gbxZaman.TabIndex = 7;
            this.gbxZaman.TabStop = false;
            this.gbxZaman.Text = "Öğün";
            // 
            // gbxKahvalti
            // 
            this.gbxKahvalti.Controls.Add(this.label1);
            this.gbxKahvalti.Controls.Add(this.dgvSabah);
            this.gbxKahvalti.Location = new System.Drawing.Point(15, 182);
            this.gbxKahvalti.Name = "gbxKahvalti";
            this.gbxKahvalti.Size = new System.Drawing.Size(316, 168);
            this.gbxKahvalti.TabIndex = 8;
            this.gbxKahvalti.TabStop = false;
            this.gbxKahvalti.Text = "SABAH";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOPLAM:";
            // 
            // dgvSabah
            // 
            this.dgvSabah.AllowUserToAddRows = false;
            this.dgvSabah.AllowUserToDeleteRows = false;
            this.dgvSabah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabah.Location = new System.Drawing.Point(6, 22);
            this.dgvSabah.MultiSelect = false;
            this.dgvSabah.Name = "dgvSabah";
            this.dgvSabah.ReadOnly = true;
            this.dgvSabah.RowTemplate.Height = 25;
            this.dgvSabah.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSabah.Size = new System.Drawing.Size(304, 117);
            this.dgvSabah.TabIndex = 1;
            this.dgvSabah.SelectionChanged += new System.EventHandler(this.dgvSabah_SelectionChanged);
            // 
            // gbxOglen
            // 
            this.gbxOglen.Controls.Add(this.label2);
            this.gbxOglen.Controls.Add(this.dgvOgle);
            this.gbxOglen.Location = new System.Drawing.Point(337, 182);
            this.gbxOglen.Name = "gbxOglen";
            this.gbxOglen.Size = new System.Drawing.Size(316, 168);
            this.gbxOglen.TabIndex = 9;
            this.gbxOglen.TabStop = false;
            this.gbxOglen.Text = "ÖĞLEN";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "TOPLAM:";
            // 
            // dgvOgle
            // 
            this.dgvOgle.AllowUserToAddRows = false;
            this.dgvOgle.AllowUserToDeleteRows = false;
            this.dgvOgle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgle.Location = new System.Drawing.Point(6, 22);
            this.dgvOgle.MultiSelect = false;
            this.dgvOgle.Name = "dgvOgle";
            this.dgvOgle.ReadOnly = true;
            this.dgvOgle.RowTemplate.Height = 25;
            this.dgvOgle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgle.Size = new System.Drawing.Size(304, 117);
            this.dgvOgle.TabIndex = 2;
            this.dgvOgle.SelectionChanged += new System.EventHandler(this.dgvOgle_SelectionChanged);
            // 
            // gbxAksam
            // 
            this.gbxAksam.Controls.Add(this.label3);
            this.gbxAksam.Controls.Add(this.dgvAksam);
            this.gbxAksam.Location = new System.Drawing.Point(659, 182);
            this.gbxAksam.Name = "gbxAksam";
            this.gbxAksam.Size = new System.Drawing.Size(316, 168);
            this.gbxAksam.TabIndex = 10;
            this.gbxAksam.TabStop = false;
            this.gbxAksam.Text = "AKŞAM";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "TOPLAM:";
            // 
            // dgvAksam
            // 
            this.dgvAksam.AllowUserToAddRows = false;
            this.dgvAksam.AllowUserToDeleteRows = false;
            this.dgvAksam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAksam.Location = new System.Drawing.Point(6, 22);
            this.dgvAksam.MultiSelect = false;
            this.dgvAksam.Name = "dgvAksam";
            this.dgvAksam.ReadOnly = true;
            this.dgvAksam.RowTemplate.Height = 25;
            this.dgvAksam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAksam.Size = new System.Drawing.Size(304, 117);
            this.dgvAksam.TabIndex = 3;
            this.dgvAksam.SelectionChanged += new System.EventHandler(this.dgvAksam_SelectionChanged);
            // 
            // prbKalori
            // 
            this.prbKalori.Location = new System.Drawing.Point(271, 418);
            this.prbKalori.Name = "prbKalori";
            this.prbKalori.Size = new System.Drawing.Size(487, 34);
            this.prbKalori.TabIndex = 11;
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(11, 114);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(223, 23);
            this.txtYemek.TabIndex = 17;
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
            this.cmbPorsiyon.Location = new System.Drawing.Point(854, 49);
            this.cmbPorsiyon.Name = "cmbPorsiyon";
            this.cmbPorsiyon.Size = new System.Drawing.Size(121, 23);
            this.cmbPorsiyon.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(854, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "PORSİYON:";
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.Location = new System.Drawing.Point(854, 78);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(121, 61);
            this.btnYemekEkle.TabIndex = 20;
            this.btnYemekEkle.Text = "EKLE";
            this.btnYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "kcal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(836, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "kcal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHedefKalori
            // 
            this.lblHedefKalori.Location = new System.Drawing.Point(793, 429);
            this.lblHedefKalori.Name = "lblHedefKalori";
            this.lblHedefKalori.Size = new System.Drawing.Size(37, 23);
            this.lblHedefKalori.TabIndex = 23;
            this.lblHedefKalori.Text = "2550";
            this.lblHedefKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOgunYemekSil
            // 
            this.btnOgunYemekSil.Location = new System.Drawing.Point(435, 356);
            this.btnOgunYemekSil.Name = "btnOgunYemekSil";
            this.btnOgunYemekSil.Size = new System.Drawing.Size(119, 32);
            this.btnOgunYemekSil.TabIndex = 25;
            this.btnOgunYemekSil.Text = "YEMEK SİL";
            this.btnOgunYemekSil.UseVisualStyleBackColor = true;
            this.btnOgunYemekSil.Click += new System.EventHandler(this.btnOgunYemekSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(856, 490);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 23);
            this.btnGeri.TabIndex = 26;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblMevcutKalori
            // 
            this.lblMevcutKalori.Location = new System.Drawing.Point(151, 429);
            this.lblMevcutKalori.Name = "lblMevcutKalori";
            this.lblMevcutKalori.Size = new System.Drawing.Size(37, 23);
            this.lblMevcutKalori.TabIndex = 21;
            this.lblMevcutKalori.Text = "0";
            this.lblMevcutKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(121, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "ALINAN KALORİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(764, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "HEDEF KALORİ";
            // 
            // YemekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 525);
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
            this.Name = "YemekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YemekForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            this.gbxZaman.ResumeLayout(false);
            this.gbxZaman.PerformLayout();
            this.gbxKahvalti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabah)).EndInit();
            this.gbxOglen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgle)).EndInit();
            this.gbxAksam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksam)).EndInit();
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
    }
}