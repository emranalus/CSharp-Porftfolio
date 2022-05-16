using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Abstact clasess are base classes so only thing an abstact class can do is inheritence
    // And no instancing,privatization is allowed
    internal abstract class MuzikAleti
    {

        public string Marka { get; set; }
        public string Aciklama { get; set; }

        // Abstract forces the function to be defined inside of the child class for child class
        // via override
        public abstract string Cal();

    }
}
