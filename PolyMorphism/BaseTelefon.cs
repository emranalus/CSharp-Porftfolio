using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    internal class BaseTelefon
    {

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model{ get; set; }
        public decimal Fiyat { get; set; }

        public virtual void TelefonCal()
        {
            string path = @"C:\Users\emirhan.alus\Downloads\Sounds\default.wav";
            using (SoundPlayer player = new SoundPlayer(path))
            {
                player.Play();
            }
        }

        public string Test()
        {
            return "asd123";
        }

    }
}
