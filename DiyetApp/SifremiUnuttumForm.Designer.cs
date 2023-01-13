namespace DiyetApp
{
    partial class SifremiUnuttumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumForm));
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGizliYanit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(164, 284);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(205, 50);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(164, 187);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(205, 29);
            this.txtMail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(46, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mail Adresi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(192, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ŞİFREMİ UNUTTUM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(24, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 95);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtGizliYanit
            // 
            this.txtGizliYanit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGizliYanit.Location = new System.Drawing.Point(164, 238);
            this.txtGizliYanit.Name = "txtGizliYanit";
            this.txtGizliYanit.Size = new System.Drawing.Size(205, 29);
            this.txtGizliYanit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(57, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gizli Yanıt :";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(405, 323);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(41, 37);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // SifremiUnuttumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 372);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtGizliYanit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SifremiUnuttumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGonder;
        private TextBox txtMail;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox txtGizliYanit;
        private Label label3;
        private Button btnGeri;
    }
}