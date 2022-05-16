using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    internal class iPhone : BaseTelefon
    {

        public override void TelefonCal()
        {
            string path = @"C:\Users\emirhan.alus\Downloads\Sounds\iphone.wav";
            using (SoundPlayer player = new SoundPlayer(path))
            {
                player.Play();
            }
        }

    }
}
