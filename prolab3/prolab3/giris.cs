using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace prolab3
{
    public partial class giris : Form 
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ADMIN\\Desktop\\netflixDB.mdb");
        
        public giris()
        {
            InitializeComponent();
        }
        public int kullaniciid;
        private void button1_Click(object sender, EventArgs e)
        {
            


            baglanti.Open();
            OleDbCommand oku = new OleDbCommand("select * from KullanıcıTablosu where k_mail='" + textBox1.Text+ "' and k_sifre='" + textBox2.Text + "'", baglanti);
            OleDbDataReader reader = oku.ExecuteReader();
            anasayfa anasayfa = new anasayfa();
            
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı", "Yönlendiriliyorsunuz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kullaniciadi = reader["k_adi"].ToString();
               
                 kullaniciid = Convert.ToInt32(reader["kullaniciID"].ToString());
                izle izle = new izle();
                string favori1 = reader["favori1"].ToString();
                string favori2 = reader["favori2"].ToString();
                string favori3 = reader["favori3"].ToString();
                
                kullanici.kullaniciid = kullaniciid;
                Debug.WriteLine(kullanici.KullaniciID);
                
                
                
                //OleDbCommand okus = new OleDbCommand("select * from KullanıcıTablosu where favori1='" +favori1+ "' and favori2='" + favori2+ "' and favori3='" + favori3 + "'", baglanti);
                //OleDbDataReader reader1 = okus.ExecuteReader();
               
                anasayfa.label2.Text = kullaniciadi.ToString().ToUpper();
                anasayfa.Show();
                anasayfa.fav1 = favori1;
                anasayfa.fav2 = favori2;
                anasayfa.fav3 = favori3;

                if (favori1 == "Aksiyon ve Macera")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");
                   
                }
                if (favori2 == "Aksiyon ve Macera")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");
                   
                }
                if (favori3 == "Aksiyon ve Macera")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");
                    
                }
                if (favori1 == "Belgesel")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b2.jpg");
                }
                if (favori2 == "Belgesel")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b2.jpg");
                }
                if (favori3 == "Belgesel")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b2.jpg");
                }
                if (favori1 == "Bilim Kurgu ve Fantastik Yapımlar")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk2.jpg");
                }
                if (favori2 == "Bilim Kurgu ve Fantastik Yapımlar")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk2.jpg");
                }
                if (favori3 == "Bilim Kurgu ve Fantastik Yapımlar")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk2.jpg");
                }
                if (favori1 == "Bilim ve Doğa")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");
                }
                if (favori2 == "Bilim ve Doğa")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");
                }
                if (favori3 == "Bilim ve Doğa")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");
                }
                if (favori1 == "Çocuk ve Aile")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");
                }
                if (favori2 == "Çocuk ve Aile")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");
                }
                if (favori3 == "Çocuk ve Aile")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");
                }
                if (favori1 == "Dramalar")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");
                }
                if (favori2 == "Dramalar")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");
                }
                if (favori3 == "Dramalar")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");
                }
                if (favori1 == "Gerilim")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g2.jpg");
                }
                if (favori2 == "Gerilim")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g2.jpg");
                }
                if (favori3 == "Gerilim")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                }
                if (favori1 == "Komedi")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                }
                if (favori2 == "Komedi")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                }
                if (favori3 == "Komedi")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                }
                if (favori1 == "Korku")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");
                }
                if (favori2 == "Korku")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");
                }
                if (favori3 == "Korku")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");
                }
                if (favori1 == "Romantizm")
                {
                    anasayfa.ozelRes1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");
                    anasayfa.ozelRes2.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r2.jpg");
                }
                if (favori2 == "Romantizm")
                {
                    anasayfa.ozelRes3.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");
                    anasayfa.ozelRes4.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r2.jpg");
                }
                if (favori3 == "Romantizm")
                {
                    anasayfa.ozelRes5.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");
                    anasayfa.ozelRes6.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r2.jpg");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Giriş","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           

            // giris.ExecuteNonQuery();
            baglanti.Close();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
