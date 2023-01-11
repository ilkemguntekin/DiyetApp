namespace DiyetApp
{
    partial class RaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dtZaman = new System.Windows.Forms.DateTimePicker();
            this.dgvYemekler = new System.Windows.Forms.DataGridView();
            this.lblRapor = new System.Windows.Forms.Label();
            this.pgbHedef = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbYemekler = new System.Windows.Forms.ListBox();
            this.pgbYapilan = new System.Windows.Forms.ProgressBar();
            this.lblHedef = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugün Ne Yedim?";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(869, 479);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(89, 78);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dtZaman
            // 
            this.dtZaman.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtZaman.Location = new System.Drawing.Point(279, 15);
            this.dtZaman.Name = "dtZaman";
            this.dtZaman.Size = new System.Drawing.Size(219, 29);
            this.dtZaman.TabIndex = 0;
            this.dtZaman.ValueChanged += new System.EventHandler(this.dtZaman_ValueChanged);
            // 
            // dgvYemekler
            // 
            this.dgvYemekler.AllowUserToAddRows = false;
            this.dgvYemekler.AllowUserToDeleteRows = false;
            this.dgvYemekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYemekler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYemekler.BackgroundColor = System.Drawing.Color.White;
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekler.Location = new System.Drawing.Point(152, 82);
            this.dgvYemekler.MultiSelect = false;
            this.dgvYemekler.Name = "dgvYemekler";
            this.dgvYemekler.ReadOnly = true;
            this.dgvYemekler.RowHeadersWidth = 51;
            this.dgvYemekler.RowTemplate.Height = 25;
            this.dgvYemekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYemekler.Size = new System.Drawing.Size(302, 298);
            this.dgvYemekler.TabIndex = 2;
            // 
            // lblRapor
            // 
            this.lblRapor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRapor.Location = new System.Drawing.Point(6, 404);
            this.lblRapor.Name = "lblRapor";
            this.lblRapor.Size = new System.Drawing.Size(448, 68);
            this.lblRapor.TabIndex = 19;
            this.lblRapor.Text = "label2";
            this.lblRapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbHedef
            // 
            this.pgbHedef.ForeColor = System.Drawing.Color.Lime;
            this.pgbHedef.Location = new System.Drawing.Point(664, 220);
            this.pgbHedef.Name = "pgbHedef";
            this.pgbHedef.Size = new System.Drawing.Size(294, 47);
            this.pgbHedef.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbYemekler);
            this.groupBox1.Controls.Add(this.dgvYemekler);
            this.groupBox1.Controls.Add(this.lblRapor);
            this.groupBox1.Location = new System.Drawing.Point(20, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 482);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporlar";
            // 
            // lstbYemekler
            // 
            this.lstbYemekler.DisplayMember = "Ad";
            this.lstbYemekler.FormattingEnabled = true;
            this.lstbYemekler.ItemHeight = 21;
            this.lstbYemekler.Location = new System.Drawing.Point(6, 82);
            this.lstbYemekler.Name = "lstbYemekler";
            this.lstbYemekler.Size = new System.Drawing.Size(140, 298);
            this.lstbYemekler.TabIndex = 1;
            this.lstbYemekler.SelectedIndexChanged += new System.EventHandler(this.lstbYemekler_SelectedIndexChanged);
            // 
            // pgbYapilan
            // 
            this.pgbYapilan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pgbYapilan.Location = new System.Drawing.Point(664, 304);
            this.pgbYapilan.Name = "pgbYapilan";
            this.pgbYapilan.Size = new System.Drawing.Size(294, 47);
            this.pgbYapilan.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbYapilan.TabIndex = 22;
            // 
            // lblHedef
            // 
            this.lblHedef.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHedef.ForeColor = System.Drawing.Color.Teal;
            this.lblHedef.Location = new System.Drawing.Point(486, 220);
            this.lblHedef.Name = "lblHedef";
            this.lblHedef.Size = new System.Drawing.Size(156, 47);
            this.lblHedef.TabIndex = 23;
            this.lblHedef.Text = "HEDEF KALORİ";
            this.lblHedef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(480, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 47);
            this.label3.TabIndex = 24;
            this.label3.Text = "ALINAN KALORİ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(976, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHedef);
            this.Controls.Add(this.pgbYapilan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pgbHedef);
            this.Controls.Add(this.dtZaman);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalori Raporları";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnGeri;
        private DateTimePicker dtZaman;
        private DataGridView dgvYemekler;
        private Label lblRapor;
        private ProgressBar pgbHedef;
        private GroupBox groupBox1;
        private ListBox lstbYemekler;
        private ProgressBar pgbYapilan;
        private Label lblHedef;
        private Label label3;
    }
}