using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSansur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sansür Kelimesi Ekle - Sevgi Bakanlığı
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        // Sansürle - George Orwell Style
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                textBox1.Text = textBox1.Text.Replace(item, "***", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
