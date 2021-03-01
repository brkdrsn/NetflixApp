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

namespace prolab3
{
    public partial class izle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ADMIN\\Desktop\\netflixDB.mdb");
        OleDbCommand oku;
        public izle()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void izle_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
        }
        int dakika = 0, saniye = 1, salise = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
            }
            label3.Text = saniye.ToString();
            saniye++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;
            }
            label4.Text = salise.ToString();
            salise++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }
       // anasayfa asd = new anasayfa();
        giris grs = new giris();
        public string programid = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            string zaman= string.Concat("00:",label2.Text,label5.Text, label3.Text);
            string sorgu = "INSERT INTO KProgram(progID,kullaniciID,i_tarihi,i_suresi,i_bolum,i_puan) VALUES (@prog,@kulla,@tarih,@sure,@bolum,@puan)";
            oku = new OleDbCommand(sorgu, baglanti);
            //int progid = asd.programid;
            Debug.WriteLine(zaman);
            oku.Parameters.Clear();
            oku.Parameters.AddWithValue ("@prog",programid);
            oku.Parameters.AddWithValue("@kulla", kullanici.kullaniciid);
            oku.Parameters.AddWithValue("@tarih", DateTime.Today);
            oku.Parameters.AddWithValue("@sure",zaman);
            oku.Parameters.AddWithValue("@bolum",1);
            oku.Parameters.AddWithValue("@puan", comboBox1.Text.ToString());
            baglanti.Open();
            oku.ExecuteNonQuery();
            baglanti.Close();
            //OleDbDataReader reader = oku.ExecuteReader();
            MessageBox.Show("Puanınız kaydedildi.", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            label2.Text = dakika.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
    }
}
