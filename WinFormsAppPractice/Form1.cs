using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> araclar = new List<string>();
            araclar.Add("80 Model Corvette");
            araclar.Add("Kia Sportage");
            araclar.Add("Rolls Royce Phantom");
            araclar.Add("Honda Civic");

            foreach (var araba in araclar)
            {
                listBox1.Items.Add(araba);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomSelect;
            for (int i = 0; i < 50; i++)
            {
                randomSelect = rand.Next(1, 51);
                if (randomSelect % 2 == 0)
                {
                    listBox1.Items.Add(randomSelect);
                }
                else
                {
                    listBox2.Items.Add(randomSelect);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            int elemanSayisi = int.Parse(deger);
            int saglama = 0;
            int[] sayilar = new int[elemanSayisi];
            int[] frekans = new int[11];
            Random rand = new Random();

            for (int i = 0; i < elemanSayisi; i++)
            {
                sayilar[i] = rand.Next(11);
            }

            for (int i = 0; i < elemanSayisi; i++)
            {
                switch (sayilar[i])
                {
                    case 1:
                        frekans[0]++;
                        break;
                    case 2:
                        frekans[1]++;
                        break;
                    case 3:
                        frekans[2]++;
                        break;
                    case 4:
                        frekans[3]++;
                        break;
                    case 5:
                        frekans[4]++;
                        break;
                    case 6:
                        frekans[5]++;
                        break;
                    case 7:
                        frekans[6]++;
                        break;
                    case 8:
                        frekans[7]++;
                        break;
                    case 9:
                        frekans[8]++;
                        break;
                    case 10:
                        frekans[9]++;
                        break;
                }
            }

            for (int i = 0; i < frekans.Length; i++)
            {
                listBox1.Items.Add(i + " => " +frekans[i]);
                saglama += frekans[i];
            }

            listBox2.Items.Add(saglama);

        }
    }
}
