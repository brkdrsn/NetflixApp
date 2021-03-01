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
namespace prolab3
{
    public partial class kayit : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ADMIN\\Desktop\\netflixDB.mdb");
        public kayit()
        {
            InitializeComponent();
           

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            baglanti.Open();
       
            OleDbCommand ekle=new OleDbCommand("insert into KullanıcıTablosu (k_adi,k_mail,k_sifre,k_dogum,favori1,favori2,favori3) values ('"+textBox1.Text.ToString()+"','"+ textBox3.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+dateTimePicker1.Value.ToShortDateString()+ "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "')", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            grs.Show();
            this.Hide();
        }

    }
}
