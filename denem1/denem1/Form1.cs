using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace denem1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=.;Database=OTOMASYON1;Integrated Security=True;";
        private Random random = new Random();
        
        // Form sürükleme işlemi için değişkenler
        private bool dragging = false;
        private Point dragStartPoint;

        public Form1()
        {
            InitializeComponent();
            
            // Köşeleri yuvarlatma işlemleri
            YuvarlakKoseleriAyarla();
            
            KategoriComboBoxDoldur();
        }

        // Köşeleri yuvarlatma metodu
        private void YuvarlakKoseleriAyarla()
        {
            // Ana form için köşeleri yuvarlatma
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            
            // Butonlar için köşeleri yuvarlatma
            btnTarifiGoster.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTarifiGoster.Width, btnTarifiGoster.Height, 10, 10));
            btnYemekOner.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnYemekOner.Width, btnYemekOner.Height, 10, 10));
            
            // PictureBox için köşeleri yuvarlatma
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 10, 10));
            
            // Panel köşeleri yuvarlatma
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 10, 10));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 10, 10));
            
            // Textbox köşeleri yuvarlatma
            txtYemekAciklama.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtYemekAciklama.Width, txtYemekAciklama.Height, 8, 8));
        }

        // Windows API metodu köşeleri yuvarlatmak için
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        // Form yeniden boyutlandırıldığında köşeler tekrar ayarlanmalı
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            YuvarlakKoseleriAyarla();
        }

        // Form sürükleme işlemi için kullanılacak event handlerlar
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Çıkış butonu için event handler
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KategoriComboBoxDoldur()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT DISTINCT Kategori FROM Yemekler ORDER BY Kategori";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbKategoriler.Items.Add(reader["Kategori"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliKategori = cmbKategoriler.SelectedItem.ToString();
            YemekleriListele(seciliKategori);
        }

        private void YemekleriListele(string kategori)
        {
            lstYemekler.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT YemekAdi FROM Yemekler WHERE Kategori = @Kategori ORDER BY YemekAdi";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Kategori", kategori);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lstYemekler.Items.Add(reader["YemekAdi"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemekler listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void lstYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYemekler.SelectedItem != null)
            {
                string seciliYemek = lstYemekler.SelectedItem.ToString();
                YemekDetayiniGoster(seciliYemek);
            }
        }

        private void YemekDetayiniGoster(string yemekAdi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT Aciklama, Resim, Tarif FROM Yemekler WHERE YemekAdi = @YemekAdi";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@YemekAdi", yemekAdi);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtYemekAciklama.Text = reader["Aciklama"].ToString();
                        string resimYolu = reader["Resim"].ToString();
                        
                        try
                        {
                            if (File.Exists(resimYolu))
                            {
                                // Doğrudan veritabanındaki tam yolu kullan
                                pictureBox1.Image = Image.FromFile(resimYolu);
                                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            else
                            {
                                // Alternatif olarak uygulama dizininde de kontrol et
                                string uygDizini = Application.StartupPath;
                                string tamResimYolu = Path.Combine(uygDizini, "resimler", Path.GetFileName(resimYolu));
                                
                                if (File.Exists(tamResimYolu))
                                {
                                    pictureBox1.Image = Image.FromFile(tamResimYolu);
                                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    pictureBox1.Image = null;
                                    MessageBox.Show("Resim bulunamadı: " + resimYolu, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message);
                            pictureBox1.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemek detayları yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnYemekOner_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // İçecekler kategorisini hariç tutan sorgu
                    string sql = "SELECT TOP 1 YemekAdi, Kategori FROM Yemekler WHERE Kategori != 'İçecekler' ORDER BY NEWID()";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string secilenYemek = reader["YemekAdi"].ToString();
                        string kategori = reader["Kategori"].ToString();
                        
                        MessageBox.Show("Bugün şunu yemeye ne dersiniz: " + secilenYemek, "Yemek Önerisi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Seçilen yemeği listede göster
                        cmbKategoriler.SelectedItem = kategori;
                        lstYemekler.SelectedItem = secilenYemek;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemek önerisi alınırken hata oluştu: " + ex.Message);
            }
        }

        private void btnTarifiGoster_Click(object sender, EventArgs e)
        {
            if (lstYemekler.SelectedItem != null)
            {
                try
                {
                    string secilenYemek = lstYemekler.SelectedItem.ToString();
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "SELECT Tarif FROM Yemekler WHERE YemekAdi = @YemekAdi";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@YemekAdi", secilenYemek);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string tarif = reader["Tarif"].ToString();
                            MessageBox.Show(tarif, secilenYemek + " Nasıl Yapılır?", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarif bilgisi alınırken hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir yemek seçin.", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}