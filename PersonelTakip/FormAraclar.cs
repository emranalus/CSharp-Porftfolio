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
    public enum DonanimPaketi
    {
        Full,
        FullArtiFull,
        Bos
    }
    public enum VitesTipi
    {
        Ototmatik,
        Manuel,
        YariOtomatik
    }

    struct Arraba
    {
        public string Marka;
        public string Model;
        public string Renk;
        public KasaTipi Kasa;
        public VitesTipi Vites;
        public string GuvenlikPaketi;
        public DonanimPaketi Paket;
        public string Motor;
        public YakitTipi Yakit;
    }

    class Arac
    {

        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public KasaTipi Kasa { get; set; }
        public VitesTipi Vites{ get; set; }
        public string GuvenlikPaketi { get; set; }
        public YakitTipi Yakit { get; set; }
        public int MotorGucu { get; set; }

    }

    public partial class FormAraclar : Form
    {

        string marka, model, renk, kasa, vites
            , guvenlikPaketi, donanimPaketi, motor, yakitTipi;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            Arraba arac1 = new Arraba();
            arac1.Kasa  = KasaTipi.Sedan;
            arac1.Yakit = YakitTipi.Elektrik;
            arac1.Paket = DonanimPaketi.Full;
            arac1.Vites = VitesTipi.Ototmatik;

        }

        public FormAraclar()
        {
            InitializeComponent();
        }

        private void FormAraclar_Load(object sender, EventArgs e)
        {
            cmbDonanim.Items.AddRange(Enum.GetNames(typeof(DonanimPaketi)));
            cmbDonanim.SelectedIndex = 0;

            cmbKasa.Items.AddRange(Enum.GetNames(typeof(KasaTipi)));
            cmbKasa.SelectedIndex = 0;

            cmbVites.Items.AddRange(Enum.GetNames(typeof (VitesTipi)));
            cmbVites.SelectedIndex = 0;

            cmbYakit.Items.AddRange(Enum.GetNames(typeof(VitesTipi)));
            cmbYakit.SelectedIndex = 0;
        }
    }
}
