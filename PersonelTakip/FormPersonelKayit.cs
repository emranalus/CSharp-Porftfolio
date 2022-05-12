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
        
        List<Kisi> Kisiler = new List<Kisi>();

        // Struct Tanımlaması
        class Kisi
        {
            public string Ad;
            public string Soyad;
            private string TcNo 
            {

                get{ return TcNo.Substring(7); }
                set
                {
                    if (value.Length == 11)
                    {
                        TcNo = value;
                    }
                }
            
            } // Prop
            public string Gsm;
            public string Email;
            public DateTime DogumTarihi;
            public Adres adres;

           
        }

        struct Adres
        {
            public string Il;
            public string Ilce;
            public string Cadde;
            public string Sokak;
            public string KapiNo;
            public string DaireNo;
        }

        private void FormPersonelKayit_Load(object sender, EventArgs e)
        {
            // Örnek Struct Tanımlama
            Kisi ahmet = new Kisi();
            ahmet.Ad = "Ahmet";
            ahmet.Soyad = "Yilmaz";
            //ahmet.TcNo = "12345678901";
            ahmet.Email = "ahmetveli@gmail.com";
            ahmet.DogumTarihi = DateTime.Now.AddYears(-20);
            ahmet.adres.Il = "Istanbul";
            ahmet.adres.Ilce = "Bakirkoy";
            ahmet.adres.Cadde = "Ruheli";
            ahmet.adres.Sokak = "5. Sokak";
            ahmet.adres.KapiNo = "43";
            ahmet.adres.DaireNo = "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("Personel.txt");
            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split("|"); 
                //adlar.Add(veriler[0]);
                //soyadlar.Add(veriler[1]);
                //gsmler.Add(veriler[2]);
                //tcnolari.Add(veriler[3]);
                //dogumtarihleri.Add(Convert.ToDateTime(veriler[4]));
                //emailler.Add(veriler[5]);

                Kisi kisi  = new Kisi();
                kisi.Ad    = veriler[0];
                kisi.Soyad = veriler[1];
                kisi.Gsm   = veriler[2];
                kisi.Email = veriler[3];
                //kisi.TcNo  = veriler[4]; 
                //kisi.DogumTarihi = Convert.ToDateTime(veriler[5]);
            }

            for (int i = 0; i < satirlar.Length; i++)
            {
                string yazilacaksatir = adlar[i] + " - " + soyadlar[i] + " - " + gsmler[i] 
                    + " - " + tcnolari[i];
                listBox1.Items.Add(yazilacaksatir);
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
            // Yanlış Örnek
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

            // Doğru Örnek
            Kisi yeniKisi = new Kisi();
            yeniKisi.Ad = ad;
            yeniKisi.Soyad = soyad;
            //yeniKisi.TcNo = tcno;
            yeniKisi.Gsm = gsm;
            yeniKisi.Email = email;

            Kisiler.Add(yeniKisi);

            StreamWriter sw =  File.CreateText(path);
            sw.WriteLine(yeniKisi.Ad + "|" + yeniKisi.Soyad + "|" + yeniKisi.Gsm + "|" + yeniKisi.Email);
            sw.Close();

        }
    }
}
