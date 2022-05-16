using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyMorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseTelefon baseTelefon = new BaseTelefon();
            baseTelefon.TelefonCal();
        }

        private void btn_nok_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.TelefonCal();
        }

        private void btn_iPhon_Click(object sender, EventArgs e)
        {
            iPhone iphone = new iPhone();
            iphone.TelefonCal();
        }

        private void btn_sam_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.TelefonCal();
        }
    }
}
