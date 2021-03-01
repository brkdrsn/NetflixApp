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
using System.Text.RegularExpressions;

namespace prolab3
{

    public partial class anasayfa : Form
    {
        giris grs = new giris();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ADMIN\\Desktop\\netflixDB.mdb");
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
           
            


            baglanti.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox9.Show();
            pictureBox10.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();
            pictureBox15.Show();
            pictureBox20.Show();
            pictureBox21.Show();
            pictureBox22.Show();
            pictureBox19.Hide();
            pictureBox18.Hide();
            pictureBox17.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox16.Hide();
            pictureBox14.Hide();
            pictureBox26.Hide();

            //drama
            pictureBox54.Show();
            pictureBox38.Show();
            pictureBox53.Show();
            pictureBox37.Show();
            pictureBox36.Show();
            pictureBox35.Show();

            //romantik
            pictureBox56.Show();
            pictureBox32.Show();
            pictureBox55.Show();


            //komedi
            pictureBox57.Show();
            pictureBox58.Show();
            pictureBox59.Show();
            pictureBox60.Show();
            pictureBox61.Show();
            pictureBox63.Show();


            //çocuk
            pictureBox72.Show();
            pictureBox67.Show();
            pictureBox73.Show();
            pictureBox71.Show();
            pictureBox70.Show();
            pictureBox69.Show();
            pictureBox74.Show();
            pictureBox75.Show();
            pictureBox76.Show();
            pictureBox77.Show();
            pictureBox78.Show();

            //korku gerilim

            pictureBox94.Show();
            pictureBox99.Show();
            pictureBox97.Show();
            pictureBox95.Hide();
            pictureBox96.Hide();
            pictureBox98.Hide();
            pictureBox100.Hide();
            pictureBox68.Hide();
            pictureBox66.Hide();
            pictureBox65.Hide();
            pictureBox79.Hide();
            pictureBox80.Hide();
            pictureBox81.Hide();
            pictureBox82.Hide();
            pictureBox62.Hide();
            pictureBox64.Hide();
            pictureBox27.Hide();
            pictureBox31.Hide();
            pictureBox30.Hide();
            pictureBox29.Hide();
            pictureBox28.Hide();
            pictureBox34.Hide();
            pictureBox33.Hide();

            //bilim kurgu


            groupBox8.Show();
            groupBox9.Show();
            groupBox10.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
        izle izle = new izle();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\recep.jpg");

            {
                izle.programid = "1";
            }
            this.Hide();
            izle.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\394677.jpg");

            {
                izle.programid = "2";
            }
            this.Hide();
            izle.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\583881.jpg");

            {
                izle.programid = "3";
            }
            this.Hide();
            izle.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\39186.jpg");

            {
                izle.programid = "4";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\5.jpg");

            {
                izle.programid = "5";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");

            {
                izle.programid = "6";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\7.jpg");

            {
                izle.programid = "7";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");

            {
                izle.programid = "8";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\9.jpg");

            {
                izle.programid = "9";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\10.jpg");

            {
                izle.programid = "10";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\11.jpg");

            {
                izle.programid = "11";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\12.jpg");

            {
                izle.programid = "12";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\13.jpg");

            {
                izle.programid = "13";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\14.jpg");

            {
                izle.programid = "14";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\15.jpg");

            {
                izle.programid = "15";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\16.jpg");

            {
                izle.programid = "26";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\17.jpg");

            {
                izle.programid = "40";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\18.jpg");

            {
                izle.programid = "51";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\19.jpg");

            {
                izle.programid = "53";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\20.jpg");

            {
                izle.programid = "53";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\21.jpg");

            {
                izle.programid = "54";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\22.jpg");

            {
                izle.programid = "59";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\23.jpg");

            {
                izle.programid = "62";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\24.jpg");

            {
                izle.programid = "67";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\25.jpg");

            {
                izle.programid = "68";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\26.jpg");

            {
                izle.programid = "69";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\4582191.jpg");

            {
                izle.programid = "24";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\394677.jpg");

            {
                izle.programid = "2";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\legend.jpg");

            {
                izle.programid = "2";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\39186.jpg");

            {
                izle.programid = "4";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\5.jpg");

            {
                izle.programid = "5";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");

            {
                izle.programid = "6";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");

            {
                izle.programid = "25";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");

            {
                izle.programid = "8";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\gr.jpg");

            {
                izle.programid = "48";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\jrp.jpg");

            {
                izle.programid = "27";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");

            {
                izle.programid = "28";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\12.jpg");

            {
                izle.programid = "12";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\16.jpg");

            {
                izle.programid = "26";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\15.jpg");

            {
                izle.programid = "15";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\11.jpg");

            {
                izle.programid = "11";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bh.jpg");

            {
                izle.programid = "44";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");

            {
                izle.programid = "45";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");

            {
                izle.programid = "46";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");

            {
                izle.programid = "47";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\gr.jpg");

            {
                izle.programid = "48";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bbs.jpg");

            {
                izle.programid = "57";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");

            {
                izle.programid = "63";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\583881.jpg");

            {
                izle.programid = "3";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");

            {
                izle.programid = "25";
            }
            this.Hide();
            izle.Show();

        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");

            {
                izle.programid = "47";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bbs.jpg");

            {
                izle.programid = "57";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\hm.jpg");

            {
                izle.programid = "55";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\lm.jpg");

            {
                izle.programid = "56";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\22.jpg");

            {
                izle.programid = "59";
            }
            this.Hide();
            izle.Show();
        }
         private void pictureBox60_Click(object sender, EventArgs e)
            {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\srn.jpg");

            {
                izle.programid = "36";
            }
            this.Hide();
            izle.Show();
        }
        private void pictureBox61_Click_1(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");

            {
                izle.programid = "37";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\Shrek.jpg");

            {
                izle.programid = "42";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");

            {
                izle.programid = "43";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");

            {
                izle.programid = "43";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\srn.jpg");

            {
                izle.programid = "36";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");

            {
                izle.programid = "37";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\Shrek.jpg");

            {
                izle.programid = "42";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");

            {
                izle.programid = "43";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");

            {
                izle.programid = "43";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\sb.jpg");

            {
                izle.programid = "61";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\sb.jpg");

            {
                izle.programid = "61";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ab.jpg");

            {
                izle.programid = "64";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ab.jpg");

            {
                izle.programid = "64";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\pok.jpg");

            {
                izle.programid = "35";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\as.jpg");

            {
                izle.programid = "38";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\sd.jpg");

            {
                izle.programid = "39";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\mrb.jpg");

            {
                izle.programid = "41";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\25.jpg");

            {
                izle.programid = "68";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\2071034.jpg");

            {
                izle.programid = "33";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\2071034.jpg");

            {
                izle.programid = "33";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\72s.jpg");

            {
                izle.programid = "30";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\72s.jpg");

            {
                izle.programid = "30";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");

            {
                izle.programid = "31";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");

            {
                izle.programid = "31";
            }
            this.Hide();
            izle.Show();

        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");

            {
                izle.programid = "32";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");

            {
                izle.programid = "32";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\pd.jpg");

            {
                izle.programid = "34";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\pd.jpg");

            {
                izle.programid = "34";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");

            {
                izle.programid = "49";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");

            {
                izle.programid = "50";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\cri.jpg");

            {
                izle.programid = "65";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\26.jpg");

            {
                izle.programid = "69";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");

            {
                izle.programid = "28";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");

            {
                izle.programid = "62";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");

            {
                izle.programid = "63";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\asd1.jpg");

            {
                izle.programid = "70";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\asd2.jpg");

            {
                izle.programid = "71";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\asd3.jpg");

            {
                izle.programid = "72";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\asd4.jpg");

            {
                izle.programid = "73";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\asd5.jpg");

            {
                izle.programid = "74";
            }
            this.Hide();
            izle.Show();
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\asd6.jpg");

            {
                izle.programid = "75";
            }
            this.Hide();
            izle.Show();
        }
        giris giris = new giris();
        public string fav1 = string.Empty;
        public string fav2 = string.Empty;
        public string fav3 = string.Empty;
        
        private void ozelRes1_Click(object sender, EventArgs e)
        {
            
            if(fav1== "Aksiyon ve Macera")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");
                izle.programid = "6";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Belgesel")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b1.jpg");
                izle.programid = "16";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");
                izle.programid = "28";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Bilim ve Doğa")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");
                izle.programid = "32";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Çocuk ve Aile")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç1.jpg");
                izle.programid = "35";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Dramalar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");
                izle.programid = "47";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Gerilim")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");
                izle.programid = "49";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Komedi")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                izle.programid = "46";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Korku")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");
                izle.programid = "63";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Romantizm")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");
                izle.programid = "25";
                this.Hide();
                izle.Show();
            }

        }

        private void ozelRes3_Click(object sender, EventArgs e)
        {
            if (fav2 == "Aksiyon ve Macera")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");
                izle.programid = "6";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Belgesel")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b1.jpg");
                izle.programid = "16";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");
                izle.programid = "28";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Bilim ve Doğa")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");
                izle.programid = "32";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Çocuk ve Aile")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç1.jpg");
                izle.programid = "35";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Dramalar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");
                izle.programid = "47";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Gerilim")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");
                izle.programid = "49";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Komedi")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                izle.programid = "46";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Korku")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");
                izle.programid = "63";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Romantizm")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");
                izle.programid = "25";
                this.Hide();
                izle.Show();
            }
        }

        private void ozelRes5_Click(object sender, EventArgs e)
        {
            if (fav3 == "Aksiyon ve Macera")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\6.jpg");
                izle.programid = "6";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Belgesel")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b1.jpg");
                izle.programid = "16";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk1.jpg");
                izle.programid = "28";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Bilim ve Doğa")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd1.jpg");
                izle.programid = "32";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Çocuk ve Aile")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç1.jpg");
                izle.programid = "35";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Dramalar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d1.jpg");
                izle.programid = "47";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Gerilim")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g1.jpg");
                izle.programid = "49";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Komedi")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k1.jpg");
                izle.programid = "46";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Korku")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko1.jpg");
                izle.programid = "63";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Romantizm")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r1.jpg");
                izle.programid = "25";
                this.Hide();
                izle.Show();
            }
        }

        private void ozelRes2_Click(object sender, EventArgs e)
        {
            if (fav1 == "Aksiyon ve Macera")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");
                izle.programid = "8";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Belgesel")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b2.jpg");
                izle.programid = "32";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk2.jpg");
                izle.programid = "24";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Bilim ve Doğa")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");
                izle.programid = "31";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Çocuk ve Aile")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");
                izle.programid = "37";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Dramalar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");
                izle.programid = "45";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Gerilim")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g2.jpg");
                izle.programid = "50";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Komedi")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                izle.programid = "43";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Korku")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");
                izle.programid = "62";
                this.Hide();
                izle.Show();
            }
            if (fav1 == "Romantizm")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r2.jpg");
                izle.programid = "55";
                this.Hide();
                izle.Show();
            }
        }

        private void ozelRes4_Click(object sender, EventArgs e)
        {
            if (fav2 == "Aksiyon ve Macera")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");
                izle.programid = "8";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Belgesel")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b2.jpg");
                izle.programid = "32";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk2.jpg");
                izle.programid = "24";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Bilim ve Doğa")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");
                izle.programid = "31";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Çocuk ve Aile")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");
                izle.programid = "37";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Dramalar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");
                izle.programid = "45";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Gerilim")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g2.jpg");
                izle.programid = "50";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Komedi")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                izle.programid = "43";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Korku")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");
                izle.programid = "62";
                this.Hide();
                izle.Show();
            }
            if (fav2 == "Romantizm")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r2.jpg");
                izle.programid = "55";
                this.Hide();
                izle.Show();
            }
        }

        private void ozelRes6_Click(object sender, EventArgs e)
        {
            if (fav3 == "Aksiyon ve Macera")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\8.jpg");
                izle.programid = "8";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Belgesel")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\b2.jpg");
                izle.programid = "32";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bk2.jpg");
                izle.programid = "24";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Bilim ve Doğa")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\bd2.jpg");
                izle.programid = "31";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Çocuk ve Aile")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ç2.jpg");
                izle.programid = "37";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Dramalar")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\d2.jpg");
                izle.programid = "45";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Gerilim")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\g2.jpg");
                izle.programid = "50";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Komedi")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\k2.jpg");
                izle.programid = "43";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Korku")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\ko2.jpg");
                izle.programid = "62";
                this.Hide();
                izle.Show();
            }
            if (fav3 == "Romantizm")
            {
                izle.pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"\\netf\\JPEG\\r2.jpg");
                izle.programid = "55";
                this.Hide();
                izle.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox15.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox19.Location = new Point(11, 3);
            pictureBox18.Location = new Point(177, 3);
            pictureBox17.Location = new Point(343, 3);
            pictureBox23.Location = new Point(509, 3);
            pictureBox24.Location = new Point(675, 3);
            pictureBox25.Location = new Point(841, 3);
            pictureBox16.Location = new Point(1007, 3);
            pictureBox14.Location = new Point(1173, 3);
            pictureBox26.Location = new Point(1339, 3);
            
            //drama
            pictureBox54.Hide();
            pictureBox38.Hide();
            pictureBox53.Hide();
            pictureBox37.Hide();
            pictureBox36.Hide();
            pictureBox35.Hide();
            pictureBox34.Location = new Point(11, 3);
            pictureBox33.Location = new Point(177, 3);
            //romantik
            pictureBox56.Hide();
            pictureBox32.Hide();
            pictureBox55.Hide();
            pictureBox31.Location = new Point(11, 3);
            pictureBox30.Location = new Point(177, 3);
            pictureBox29.Location = new Point(343, 3);
            pictureBox28.Location = new Point(509, 3);

            //komedi
            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
            pictureBox60.Hide();
            pictureBox61.Hide();
            pictureBox63.Hide();
            pictureBox62.Location = new Point(11, 3);
            pictureBox64.Location = new Point(177, 3);
            pictureBox27.Location = new Point(343, 3);

            //çocuk
            pictureBox72.Hide();
            pictureBox67.Hide();
            pictureBox73.Hide();
            pictureBox71.Hide();
            pictureBox70.Hide();
            pictureBox69.Hide();
            pictureBox74.Hide();
            pictureBox75.Hide();
            pictureBox76.Hide();
            pictureBox77.Hide();
            pictureBox78.Hide();
            pictureBox68.Location = new Point(11, 3);
            pictureBox66.Location = new Point(177, 3);
            pictureBox65.Location = new Point(343, 3);
            pictureBox79.Location = new Point(509, 3);
            pictureBox80.Location = new Point(675, 3);
            pictureBox81.Location = new Point(841, 3);
            pictureBox82.Location = new Point(1007, 3);
            //korku gerilim

            pictureBox94.Hide();
            pictureBox99.Hide();
            pictureBox97.Hide();
            pictureBox95.Location = new Point(11, 3);
            pictureBox96.Location = new Point(177, 3);
            pictureBox98.Location = new Point(343, 3);
            pictureBox100.Location = new Point(509, 3);

            //bilim kurgu
            

            groupBox8.Hide();
            groupBox9.Hide();
            groupBox10.Hide();


            pictureBox19.Show();
            pictureBox18.Show();
            pictureBox17.Show();
            pictureBox23.Show();
            pictureBox24.Show();
            pictureBox25.Show();
            pictureBox16.Show();
            pictureBox14.Show();
            pictureBox26.Show();
            pictureBox95.Show();
            pictureBox96.Show();
            pictureBox98.Show();
            pictureBox100.Show();
            pictureBox68.Show();
            pictureBox66.Show();
            pictureBox65.Show();
            pictureBox79.Show();
            pictureBox80.Show();
            pictureBox81.Show();
            pictureBox82.Show();
            pictureBox62.Show();
            pictureBox64.Show();
            pictureBox27.Show();
            pictureBox31.Show();
            pictureBox30.Show();
            pictureBox29.Show();
            pictureBox28.Show();
            pictureBox34.Show();
            pictureBox33.Show();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            

            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox9.Show();
            pictureBox10.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();
            pictureBox15.Show();
            pictureBox20.Show();
            pictureBox21.Show();
            pictureBox22.Show();
            pictureBox19.Hide();
            pictureBox18.Hide();
            pictureBox17.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox16.Hide();
            pictureBox14.Hide();
            pictureBox26.Hide();

            //drama
            pictureBox54.Show();
            pictureBox38.Show();
            pictureBox53.Show();
            pictureBox37.Show();
            pictureBox36.Show();
            pictureBox35.Show();
            
            //romantik
            pictureBox56.Show();
            pictureBox32.Show();
            pictureBox55.Show();
            

            //komedi
            pictureBox57.Show();
            pictureBox58.Show();
            pictureBox59.Show();
            pictureBox60.Show();
            pictureBox61.Show();
            pictureBox63.Show();
            

            //çocuk
            pictureBox72.Show();
            pictureBox67.Show();
            pictureBox73.Show();
            pictureBox71.Show();
            pictureBox70.Show();
            pictureBox69.Show();
            pictureBox74.Show();
            pictureBox75.Show();
            pictureBox76.Show();
            pictureBox77.Show();
            pictureBox78.Show();
            
            //korku gerilim

            pictureBox94.Show();
            pictureBox99.Show();
            pictureBox97.Show();
            pictureBox95.Hide();
            pictureBox96.Hide();
            pictureBox98.Hide();
            pictureBox100.Hide();
            pictureBox68.Hide();
            pictureBox66.Hide();
            pictureBox65.Hide();
            pictureBox79.Hide();
            pictureBox80.Hide();
            pictureBox81.Hide();
            pictureBox82.Hide();
            pictureBox62.Hide();
            pictureBox64.Hide();
            pictureBox27.Hide();
            pictureBox31.Hide();
            pictureBox30.Hide();
            pictureBox29.Hide();
            pictureBox28.Hide();
            pictureBox34.Hide();
            pictureBox33.Hide();

            //bilim kurgu
            

            groupBox8.Hide();
            groupBox9.Hide();
            groupBox10.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Aksiyon ve Macera")
            {
               // anaPanel.Hide();
                groupBox1.Show();
                groupBox1.Location = new Point(32,31);
                groupBox11.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
          /*  Aksiyon ve Macera
        Bilim Kurgu ve Fantastik Yapımlar
Drama
Romantik
Komedi
Çocuk ve Aile
Korku ve Gerilim
Belgesel
Bilim ve Doğa
Reality Program*/
            if (comboBox1.Text == "Bilim Kurgu ve Fantastik Yapımlar")
            {
                // anaPanel.Hide();
                groupBox2.Show();
                groupBox2.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Drama")
            {
                // anaPanel.Hide();
                groupBox3.Show();
                groupBox3.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Romantik")
            {
                // anaPanel.Hide();
                groupBox4.Show();
                groupBox4.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Komedi")
            {
                // anaPanel.Hide();
                groupBox5.Show();
                groupBox5.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Çocuk ve Aile")
            {
                // anaPanel.Hide();
                groupBox6.Show();
                groupBox6.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Korku ve Gerilim")
            {
                // anaPanel.Hide();
                groupBox7.Show();
                groupBox7.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Belgesel")
            {
                // anaPanel.Hide();
                groupBox8.Show();
                groupBox8.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox9.Hide();
                groupBox10.Hide();

            }

            if (comboBox1.Text == "Bilim ve Doğa")
            {
                // anaPanel.Hide();
                groupBox9.Show();
                groupBox9.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox10.Hide();

            }
            if (comboBox1.Text == "Reality Program")
            {
                // anaPanel.Hide();
                groupBox10.Show();
                groupBox10.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Recep İvedik 6")
            {
                groupBox1.Show();
                groupBox1.Location = new Point(32, 31);
                groupBox1.Text = "Recep İvedik 6";
                groupBox11.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
                pictureBox10.Hide();
                pictureBox11.Hide();
                pictureBox12.Hide();
                pictureBox13.Hide();
                pictureBox15.Hide();
                pictureBox20.Hide();
                pictureBox21.Hide();
                pictureBox22.Hide();
                pictureBox19.Hide();
                pictureBox18.Hide();
                pictureBox17.Hide();
                pictureBox23.Hide();
                pictureBox24.Hide();
                pictureBox25.Hide();
                pictureBox16.Hide();
                pictureBox14.Hide();
                pictureBox26.Hide();
            }
            else if (textBox1.Text == "Arif V 216")
            {
                groupBox2.Text = "Arif V 216";
                groupBox2.Show();
                groupBox2.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();
                pictureBox39.Hide();
                pictureBox40.Hide();
                pictureBox41.Hide();
                pictureBox42.Hide();
                pictureBox43.Hide();
                pictureBox44.Hide();
                pictureBox45.Hide();
                pictureBox46.Hide();
                pictureBox47.Hide();
                pictureBox48.Hide();
                pictureBox49.Hide();
                pictureBox50.Hide();
                pictureBox51.Hide();
               
            }
            else if (textBox1.Text == "Atiye")
            {
                // anaPanel.Hide();
                groupBox4.Text = "Atiye";
                groupBox4.Show();
                groupBox4.Location = new Point(32, 31);
                groupBox11.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();
                pictureBox28.Location = new Point(11, 3);
                pictureBox29.Hide();
                pictureBox30.Hide();
                pictureBox31.Hide();
                pictureBox32.Hide();
                pictureBox55.Hide();
                pictureBox56.Hide();

            }
            else if (textBox1.Text == "Kung Fu Panda")
            {
                groupBox1.Show();
                groupBox1.Location = new Point(32, 31);
                groupBox1.Text = "Kung Fu Panda";
                groupBox11.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
                groupBox6.Hide();
                groupBox7.Hide();
                groupBox8.Hide();
                groupBox9.Hide();
                groupBox10.Hide();
                pictureBox2.Hide();
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox9.Hide();
                pictureBox10.Hide();
                pictureBox11.Hide();
                pictureBox12.Hide();
                pictureBox13.Hide();
                pictureBox15.Hide();
                pictureBox20.Location = new Point(11, 3);
                pictureBox21.Hide();
                pictureBox22.Hide();
                pictureBox19.Hide();
                pictureBox18.Hide();
                pictureBox17.Hide();
                pictureBox23.Hide();
                pictureBox24.Hide();
                pictureBox25.Hide();
                pictureBox16.Hide();
                pictureBox14.Hide();
                pictureBox26.Location = new Point(177, 3);

            }
            else
            {
                MessageBox.Show("Böyle bir kayıt bulunamadı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

