namespace denem1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstYemekler = new System.Windows.Forms.ListBox();
            this.lblYemekler = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnYemekOner = new System.Windows.Forms.Button();
            this.btnTarifiGoster = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYemekAciklama = new System.Windows.Forms.TextBox();
            this.lblDetaylar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 70);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExit.Location = new System.Drawing.Point(1065, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(27, 30);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBaslik.Location = new System.Drawing.Point(12, 18);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(288, 37);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YEMEK OTOMASYONU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.lblKategoriler);
            this.panel2.Controls.Add(this.cmbKategoriler);
            this.panel2.Controls.Add(this.lstYemekler);
            this.panel2.Controls.Add(this.lblYemekler);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 580);
            this.panel2.TabIndex = 1;
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriler.ForeColor = System.Drawing.Color.White;
            this.lblKategoriler.Location = new System.Drawing.Point(14, 20);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(111, 21);
            this.lblKategoriler.TabIndex = 1;
            this.lblKategoriler.Text = "KATEGORİLER";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategoriler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriler.ForeColor = System.Drawing.Color.White;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(18, 44);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(244, 28);
            this.cmbKategoriler.TabIndex = 0;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lstYemekler
            // 
            this.lstYemekler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lstYemekler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstYemekler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstYemekler.ForeColor = System.Drawing.Color.White;
            this.lstYemekler.FormattingEnabled = true;
            this.lstYemekler.ItemHeight = 20;
            this.lstYemekler.Location = new System.Drawing.Point(18, 114);
            this.lstYemekler.Name = "lstYemekler";
            this.lstYemekler.Size = new System.Drawing.Size(244, 440);
            this.lstYemekler.TabIndex = 2;
            this.lstYemekler.SelectedIndexChanged += new System.EventHandler(this.lstYemekler_SelectedIndexChanged);
            // 
            // lblYemekler
            // 
            this.lblYemekler.AutoSize = true;
            this.lblYemekler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYemekler.ForeColor = System.Drawing.Color.White;
            this.lblYemekler.Location = new System.Drawing.Point(14, 90);
            this.lblYemekler.Name = "lblYemekler";
            this.lblYemekler.Size = new System.Drawing.Size(89, 21);
            this.lblYemekler.TabIndex = 3;
            this.lblYemekler.Text = "YEMEKLER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnYemekOner);
            this.panel3.Controls.Add(this.btnTarifiGoster);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtYemekAciklama);
            this.panel3.Controls.Add(this.lblDetaylar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 580);
            this.panel3.TabIndex = 2;
            this.panel3.Padding = new System.Windows.Forms.Padding(12);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(18, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 3);
            this.panel4.TabIndex = 5;
            // 
            // btnYemekOner
            // 
            this.btnYemekOner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYemekOner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYemekOner.FlatAppearance.BorderSize = 0;
            this.btnYemekOner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYemekOner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYemekOner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekOner.ForeColor = System.Drawing.Color.White;
            this.btnYemekOner.Location = new System.Drawing.Point(418, 509);
            this.btnYemekOner.Name = "btnYemekOner";
            this.btnYemekOner.Size = new System.Drawing.Size(380, 50);
            this.btnYemekOner.TabIndex = 4;
            this.btnYemekOner.Text = "BUGÜN NE YESEM?";
            this.btnYemekOner.UseVisualStyleBackColor = false;
            this.btnYemekOner.Click += new System.EventHandler(this.btnYemekOner_Click);
            // 
            // btnTarifiGoster
            // 
            this.btnTarifiGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnTarifiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarifiGoster.FlatAppearance.BorderSize = 0;
            this.btnTarifiGoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTarifiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifiGoster.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarifiGoster.ForeColor = System.Drawing.Color.White;
            this.btnTarifiGoster.Location = new System.Drawing.Point(18, 509);
            this.btnTarifiGoster.Name = "btnTarifiGoster";
            this.btnTarifiGoster.Size = new System.Drawing.Size(380, 50);
            this.btnTarifiGoster.TabIndex = 3;
            this.btnTarifiGoster.Text = "TARİFİ GÖSTER";
            this.btnTarifiGoster.UseVisualStyleBackColor = false;
            this.btnTarifiGoster.Click += new System.EventHandler(this.btnTarifiGoster_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pictureBox1.Location = new System.Drawing.Point(418, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 425);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtYemekAciklama
            // 
            this.txtYemekAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtYemekAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYemekAciklama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYemekAciklama.ForeColor = System.Drawing.Color.White;
            this.txtYemekAciklama.Location = new System.Drawing.Point(18, 65);
            this.txtYemekAciklama.Multiline = true;
            this.txtYemekAciklama.Name = "txtYemekAciklama";
            this.txtYemekAciklama.ReadOnly = true;
            this.txtYemekAciklama.Size = new System.Drawing.Size(380, 425);
            this.txtYemekAciklama.TabIndex = 1;
            this.txtYemekAciklama.Padding = new System.Windows.Forms.Padding(10);
            // 
            // lblDetaylar
            // 
            this.lblDetaylar.AutoSize = true;
            this.lblDetaylar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetaylar.ForeColor = System.Drawing.Color.White;
            this.lblDetaylar.Location = new System.Drawing.Point(13, 20);
            this.lblDetaylar.Name = "lblDetaylar";
            this.lblDetaylar.Size = new System.Drawing.Size(175, 25);
            this.lblDetaylar.TabIndex = 0;
            this.lblDetaylar.Text = "YEMEK DETAYLARI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Otomasyonu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKategoriler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ListBox lstYemekler;
        private System.Windows.Forms.Label lblYemekler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnYemekOner;
        private System.Windows.Forms.Button btnTarifiGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtYemekAciklama;
        private System.Windows.Forms.Label lblDetaylar;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel4;
    }
}