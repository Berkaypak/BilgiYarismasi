using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sorular = new string[]
        {
            "TÜRKİYE'DE KAÇ TANE ŞEHİR VARDIR?",
            "TÜRKİYE'NİN İLK CUMHURBAŞKANI KİMDİR?",
            "İSTANBUL HANGİ COĞRAFİ BÖLGEDE YER ALIR?",
            "TÜRKİYE'NİN BAŞKENTİ HANGİ ŞEHİRDİR?",
            "İNCE MEMED KİTABININ YAZARI KİMDİR?",
            "İLK BİGİSAYARIN ADI NEDİR?",
            "CUMHURİYET KAÇ YILINDA İLAN EDİLMİŞTİR?"
        };
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray; label1.Text = "SoruNO:"; label2.Text = "Doğru:";
            label3.Text = "Yanlış:"; label4.Text = "0"; label5.Text = "0"; label6.Text = "0";
            button1.Text = "BAŞLA"; button1.BackColor = Color.Orange;
            button2.Text = "A"; button3.Text = "B"; button4.Text = "C"; button5.Text = "D";
            button2.BackColor = Color.Orange; button4.BackColor = Color.Orange;
            button3.BackColor = Color.Orange; button5.BackColor = Color.Orange;
            textBox1.Enabled = false; BenimMetotum();
            button6.Text = "BİTİR"; button6.BackColor = Color.Orange;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true; button3.Enabled = true;
            button4.Enabled = true; button5.Enabled = true;
            label4.Text = (sayac + 1).ToString();
            button1.Text = "Sonraki Soru -->";
            textBox1.Text = sorular[sayac];
            if (sayac == 0)
            {
                button2.Text = "79"; button3.Text = "80"; button4.Text = "81"; button5.Text = "82";
            }
            else if (sayac == 1)
            {
                button2.Text = "MUSTAFA KEMAL ATATÜRK"; button3.Text = "İSMET İNÖNÜ"; button4.Text = "KAZIM KARABEKİR"; button5.Text = "FATİH SULTAN MEHMED";
            }
            else if (sayac == 2)
            {
                button2.Text = "EGE"; button3.Text = "MARMARA"; button4.Text = "AKDENİZ"; button5.Text = "KARADENİZ";
            }
            else if (sayac == 3)
            {
                button2.Text = "İSTANBUL"; button3.Text = "İZMİR"; button4.Text = "BURSA"; button5.Text = "ANKARA";
            }
            else if (sayac == 4)
            {
                button2.Text = "ORHAN KEMAL"; button3.Text = "YAŞAR KEMAL"; button4.Text = "ALİ KEMAL"; button5.Text = "MUSTAFA KEMAL";
            }
            else if (sayac == 5)
            {
                button2.Text = "İNTEL"; button3.Text = "PASCAL"; button4.Text = "ENIAC"; button5.Text = "IBM";
            }
            else if (sayac == 6)
            {
                button2.Text = "1928"; button3.Text = "1919"; button4.Text = "1923"; button5.Text = "1920";
            }
            sayac++;
            if (sayac == 7) button1.Enabled = false;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            BenimMetotum(); int l5 = L5(); int l6 = L6();
            if (sayac == 1 || sayac == 3 || sayac == 4 || sayac == 5 || sayac == 6 || sayac == 7)
            {
                l6++;
                label6.Text = l6.ToString();
            }
            else { l5++; label5.Text = l5.ToString(); }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            BenimMetotum(); int l5 = L5(); int l6 = L6(); ;
            if (sayac == 1 || sayac == 2 || sayac == 4 || sayac == 6 || sayac == 7)
            { l6++; label6.Text = l6.ToString(); }
            else { l5++; label5.Text = l5.ToString(); }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            BenimMetotum();
            int l5 = L5(); int l6 = L6();
            if (sayac == 2 || sayac == 3 || sayac == 4 || sayac == 5)
            { l6++; label6.Text = l6.ToString(); }
            else { l5++; label5.Text = l5.ToString(); }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            BenimMetotum(); int l5 = L5(); ; int l6 = L6(); ;
            if (sayac == 4)
            {
                l5++; label5.Text = l5.ToString();
            }
            else
            {
                l6++;
                label6.Text = l6.ToString();
            }
        }
        private void BenimMetotum()
        {
            button2.Enabled = false; button3.Enabled = false; button4.Enabled = false; button5.Enabled = false;
        }
        private int L5() { return Convert.ToInt32(label5.Text); }
        private int L6() { return Convert.ToInt32(label6.Text); }

        private void button6_Click(object sender, EventArgs e)
        {
            int b =7- (L5() + L6());
            MessageBox.Show("DOĞRU SAYISI : " + label5.Text + "\t YANLIŞ SAYISI : " + label6.Text + "\t BOŞ SAYISI : "+b.ToString());
            this.Close();
        }
    }
}
