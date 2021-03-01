using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prolab3
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ADMIN\\Desktop\\netflixDB.mdb");

        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            kayit form2 = new kayit();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris form3 = new giris();
            form3.Show();
            this.Hide();
        }
    }
}
