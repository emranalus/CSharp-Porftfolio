using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FormAraclar : Form
    {

        string marka, model, renk, kasa, vites
            , guvenlikPaketi, donanimPaketi, motor, yakitTipi;

        // Kasa Tipleri: Cupe,Sedan,Cabrio,Hatchbag,Station Wagon
        public enum KasaTipi
        {
            Cupe, 
            Sedan, Cabrio, 
            Hatchbag, 
            Station
        }

        public enum YakitTipi
        {
            Benzin,
            Motorin,
            Elektrik,
            Hybrit
        }

        struct Araba
        {
            public string Marka;
            public string Model;
            public string Renk;
            public KasaTipi Kasa;
            public string Vites;
            public string GuvenlikPaketi;
            public string DonanimPaketi;
            public string Motor;
            public YakitTipi YakitTipi;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Araba arac1 = new Araba();
            arac1.Kasa = KasaTipi.Sedan;

        }

        public FormAraclar()
        {
            InitializeComponent();
        }

        private void FormAraclar_Load(object sender, EventArgs e)
        {

        }
    }
}
