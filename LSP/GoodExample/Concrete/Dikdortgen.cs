using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.GoodExample.Concrete
{
    internal class Dikdortgen : IYazilabilir, IOkuyabilir
    {
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
