using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FormPersonelKayit : Form
    {

        string ad, soyad, tcno, gsm, email;
        DateTime dogum;

        List<string> adlar    = new List<string>();
        List<string> soyadlar = new List<string>();
        List<string> gsmler   = new List<string>();
        List<string> tcnolari = new List<string>();
        List<string> emailler = new List<string>();

        List<DateTime> dogumtarihleri = new List<DateTime>();

        private void FormPersonelKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("Personel.txt");
            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split("|"); 
                adlar.Add(veriler[0]);
                soyadlar.Add(veriler[1]);
                gsmler.Add(veriler[2]);
                tcnolari.Add(veriler[3]);
                dogumtarihleri.Add(Convert.ToDateTime(veriler[4]));
                emailler.Add(veriler[5]);
            }
        }

        public FormPersonelKayit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            tcno = txtTcNo.Text;
            gsm = txtGsm.Text;
            email = txtEmail.Text;

            dogum = dateTimePicker1.Value;
            string path = @"Personel.txt";
            //string seperator;

            if (ad.Length < 2)
            {
                MessageBox.Show("Ad Alani En Az İki Karakter Olmalidir!");
                return;
            }

            if (soyad.Length < 2)
            {
                MessageBox.Show("Soyad Alani En Az İki Karakter Olmalidir!");
                return;
            }

            if (gsm.Length < 10)
            {
                MessageBox.Show("Gsm Alani En Az İki Karakter Olmalidir!");
                return;
            }

            if (!(tcno.Length == 11))
            {
                MessageBox.Show("TcNo Alani İki Karakter Olmalidir!");
                return;
            }

            if (dogum.Year > 2005 && dogum.Year < DateTime.Now.Year)
            {
                MessageBox.Show("Yaşın tutmadı gülüm, büyüde gel...");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Email Duzgun Formatta Olmalidir...");
                return;
            }

            
            StreamWriter sw =  File.CreateText(path);
            sw.WriteLine(ad+"|"+soyad+ "|" + gsm + "|" + email + "|" + tcno);
            sw.Close();

        }
    }
}
