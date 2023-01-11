namespace DiyetApp
{
    partial class AdminGorevForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBesinKaydet = new System.Windows.Forms.Button();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.txtBesinAd = new System.Windows.Forms.TextBox();
            this.lblKId = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.lblBAd = new System.Windows.Forms.Label();
            this.btnBSil = new System.Windows.Forms.Button();
            this.btnBDuzenle = new System.Windows.Forms.Button();
            this.btnBEkle = new System.Windows.Forms.Button();
            this.dgvBesinler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.lblKAd = new System.Windows.Forms.Label();
            this.btnKSil = new System.Windows.Forms.Button();
            this.btnKDuzenle = new System.Windows.Forms.Button();
            this.btnKEkle = new System.Windows.Forms.Button();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblBId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBesinKaydet);
            this.groupBox1.Controls.Add(this.txtKategoriId);
            this.groupBox1.Controls.Add(this.txtKalori);
            this.groupBox1.Controls.Add(this.txtBesinAd);
            this.groupBox1.Controls.Add(this.lblKId);
            this.groupBox1.Controls.Add(this.lblKalori);
            this.groupBox1.Controls.Add(this.lblBAd);
            this.groupBox1.Controls.Add(this.btnBSil);
            this.groupBox1.Controls.Add(this.btnBDuzenle);
            this.groupBox1.Controls.Add(this.btnBEkle);
            this.groupBox1.Controls.Add(this.dgvBesinler);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 606);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Besinleri Düzenle";
            // 
            // lblBId
            // 
            this.lblBId.AutoSize = true;
            this.lblBId.Location = new System.Drawing.Point(180, 310);
            this.lblBId.Name = "lblBId";
            this.lblBId.Size = new System.Drawing.Size(23, 28);
            this.lblBId.TabIndex = 15;
            this.lblBId.Text = "0";
            this.lblBId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID:";
            this.label4.Visible = false;
            // 
            // btnBesinKaydet
            // 
            this.btnBesinKaydet.Location = new System.Drawing.Point(180, 515);
            this.btnBesinKaydet.Name = "btnBesinKaydet";
            this.btnBesinKaydet.Size = new System.Drawing.Size(174, 44);
            this.btnBesinKaydet.TabIndex = 8;
            this.btnBesinKaydet.Text = "KAYDET";
            this.btnBesinKaydet.UseVisualStyleBackColor = true;
            this.btnBesinKaydet.Visible = false;
            this.btnBesinKaydet.Click += new System.EventHandler(this.btnBesinKaydet_Click);
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(180, 455);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(174, 34);
            this.txtKategoriId.TabIndex = 7;
            this.txtKategoriId.Visible = false;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(180, 403);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(174, 34);
            this.txtKalori.TabIndex = 6;
            this.txtKalori.Visible = false;
            // 
            // txtBesinAd
            // 
            this.txtBesinAd.Location = new System.Drawing.Point(180, 347);
            this.txtBesinAd.Name = "txtBesinAd";
            this.txtBesinAd.Size = new System.Drawing.Size(174, 34);
            this.txtBesinAd.TabIndex = 5;
            this.txtBesinAd.Visible = false;
            // 
            // lblKId
            // 
            this.lblKId.AutoSize = true;
            this.lblKId.Location = new System.Drawing.Point(43, 458);
            this.lblKId.Name = "lblKId";
            this.lblKId.Size = new System.Drawing.Size(117, 28);
            this.lblKId.TabIndex = 7;
            this.lblKId.Text = "Kategori Id:";
            this.lblKId.Visible = false;
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Location = new System.Drawing.Point(92, 406);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(68, 28);
            this.lblKalori.TabIndex = 6;
            this.lblKalori.Text = "Kalori:";
            this.lblKalori.Visible = false;
            // 
            // lblBAd
            // 
            this.lblBAd.AutoSize = true;
            this.lblBAd.Location = new System.Drawing.Point(58, 350);
            this.lblBAd.Name = "lblBAd";
            this.lblBAd.Size = new System.Drawing.Size(102, 28);
            this.lblBAd.TabIndex = 4;
            this.lblBAd.Text = "Besin Adı:";
            this.lblBAd.Visible = false;
            // 
            // btnBSil
            // 
            this.btnBSil.BackColor = System.Drawing.Color.Gold;
            this.btnBSil.ForeColor = System.Drawing.Color.White;
            this.btnBSil.Location = new System.Drawing.Point(354, 242);
            this.btnBSil.Name = "btnBSil";
            this.btnBSil.Size = new System.Drawing.Size(150, 50);
            this.btnBSil.TabIndex = 4;
            this.btnBSil.Text = "SİL";
            this.btnBSil.UseVisualStyleBackColor = false;
            this.btnBSil.Click += new System.EventHandler(this.btnBSil_Click);
            // 
            // btnBDuzenle
            // 
            this.btnBDuzenle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnBDuzenle.Location = new System.Drawing.Point(180, 242);
            this.btnBDuzenle.Name = "btnBDuzenle";
            this.btnBDuzenle.Size = new System.Drawing.Size(150, 50);
            this.btnBDuzenle.TabIndex = 3;
            this.btnBDuzenle.Text = "DÜZENLE";
            this.btnBDuzenle.UseVisualStyleBackColor = false;
            this.btnBDuzenle.Click += new System.EventHandler(this.btnBDuzenle_Click);
            // 
            // btnBEkle
            // 
            this.btnBEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBEkle.ForeColor = System.Drawing.Color.White;
            this.btnBEkle.Location = new System.Drawing.Point(6, 242);
            this.btnBEkle.Name = "btnBEkle";
            this.btnBEkle.Size = new System.Drawing.Size(150, 50);
            this.btnBEkle.TabIndex = 2;
            this.btnBEkle.Text = "EKLE";
            this.btnBEkle.UseVisualStyleBackColor = false;
            this.btnBEkle.Click += new System.EventHandler(this.btnBEkle_Click);
            // 
            // dgvBesinler
            // 
            this.dgvBesinler.AllowUserToAddRows = false;
            this.dgvBesinler.AllowUserToDeleteRows = false;
            this.dgvBesinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBesinler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBesinler.BackgroundColor = System.Drawing.Color.White;
            this.dgvBesinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinler.Location = new System.Drawing.Point(6, 58);
            this.dgvBesinler.MultiSelect = false;
            this.dgvBesinler.Name = "dgvBesinler";
            this.dgvBesinler.ReadOnly = true;
            this.dgvBesinler.RowHeadersWidth = 51;
            this.dgvBesinler.RowTemplate.Height = 25;
            this.dgvBesinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinler.Size = new System.Drawing.Size(498, 178);
            this.dgvBesinler.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblIdK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnKategoriKaydet);
            this.groupBox2.Controls.Add(this.txtKategoriAdi);
            this.groupBox2.Controls.Add(this.lblKAd);
            this.groupBox2.Controls.Add(this.btnKSil);
            this.groupBox2.Controls.Add(this.btnKDuzenle);
            this.groupBox2.Controls.Add(this.btnKEkle);
            this.groupBox2.Controls.Add(this.dgvKategoriler);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(551, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 606);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategorileri Düzenle";
            // 
            // lblIdK
            // 
            this.lblIdK.AutoSize = true;
            this.lblIdK.Location = new System.Drawing.Point(180, 350);
            this.lblIdK.Name = "lblIdK";
            this.lblIdK.Size = new System.Drawing.Size(23, 28);
            this.lblIdK.TabIndex = 13;
            this.lblIdK.Text = "0";
            this.lblIdK.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(180, 515);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(174, 44);
            this.btnKategoriKaydet.TabIndex = 5;
            this.btnKategoriKaydet.Text = "KAYDET";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Visible = false;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(180, 395);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(174, 34);
            this.txtKategoriAdi.TabIndex = 4;
            this.txtKategoriAdi.Visible = false;
            // 
            // lblKAd
            // 
            this.lblKAd.AutoSize = true;
            this.lblKAd.Location = new System.Drawing.Point(34, 398);
            this.lblKAd.Name = "lblKAd";
            this.lblKAd.Size = new System.Drawing.Size(129, 28);
            this.lblKAd.TabIndex = 9;
            this.lblKAd.Text = "Kategori Adı:";
            this.lblKAd.Visible = false;
            // 
            // btnKSil
            // 
            this.btnKSil.BackColor = System.Drawing.Color.Gold;
            this.btnKSil.ForeColor = System.Drawing.Color.White;
            this.btnKSil.Location = new System.Drawing.Point(354, 242);
            this.btnKSil.Name = "btnKSil";
            this.btnKSil.Size = new System.Drawing.Size(150, 50);
            this.btnKSil.TabIndex = 3;
            this.btnKSil.Text = "SİL";
            this.btnKSil.UseVisualStyleBackColor = false;
            this.btnKSil.Click += new System.EventHandler(this.btnKSil_Click);
            // 
            // btnKDuzenle
            // 
            this.btnKDuzenle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnKDuzenle.Location = new System.Drawing.Point(180, 242);
            this.btnKDuzenle.Name = "btnKDuzenle";
            this.btnKDuzenle.Size = new System.Drawing.Size(150, 50);
            this.btnKDuzenle.TabIndex = 2;
            this.btnKDuzenle.Text = "DÜZENLE";
            this.btnKDuzenle.UseVisualStyleBackColor = false;
            this.btnKDuzenle.Click += new System.EventHandler(this.btnKDuzenle_Click);
            // 
            // btnKEkle
            // 
            this.btnKEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKEkle.ForeColor = System.Drawing.Color.White;
            this.btnKEkle.Location = new System.Drawing.Point(6, 242);
            this.btnKEkle.Name = "btnKEkle";
            this.btnKEkle.Size = new System.Drawing.Size(150, 50);
            this.btnKEkle.TabIndex = 1;
            this.btnKEkle.Text = "EKLE";
            this.btnKEkle.UseVisualStyleBackColor = false;
            this.btnKEkle.Click += new System.EventHandler(this.btnKEkle_Click);
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.AllowUserToAddRows = false;
            this.dgvKategoriler.AllowUserToDeleteRows = false;
            this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKategoriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(6, 58);
            this.dgvKategoriler.MultiSelect = false;
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.ReadOnly = true;
            this.dgvKategoriler.RowHeadersWidth = 51;
            this.dgvKategoriler.RowTemplate.Height = 25;
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(498, 178);
            this.dgvKategoriler.TabIndex = 0;
            // 
            // AdminGorevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminGorevForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Düzenleme/Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtKategoriId;
        private TextBox txtKalori;
        private TextBox txtBesinAd;
        private Label lblKId;
        private Label lblKalori;
        private Label lblBAd;
        private Button btnBSil;
        private Button btnBDuzenle;
        private Button btnBEkle;
        private DataGridView dgvBesinler;
        private GroupBox groupBox2;
        private TextBox txtKategoriAdi;
        private Label lblKAd;
        private Button btnKSil;
        private Button btnKDuzenle;
        private Button btnKEkle;
        private DataGridView dgvKategoriler;
        private Button btnBesinKaydet;
        private Button btnKategoriKaydet;
        private Label lblBId;
        private Label label4;
        private Label lblIdK;
        private Label label1;
    }
}