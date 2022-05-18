using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.GoodExample
{
    internal class Logger
    {

        public void LogFile(string fileName, string log)
        {
            File.WriteAllText(fileName, log);
        }

    }
}
