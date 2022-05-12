using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class ITPersonel : Personel
    {
        public ITTecrube Tecrube { get; set; }
        
        public ITPersonel()
        {
            switch (Tecrube)
            {
                case ITTecrube.AzTecrube:
                    Salary = "8000";
                    break;
                case ITTecrube.OrtaTecrube:
                    Salary = "12500";
                    break;
                case ITTecrube.CokTecrube:
                    Salary = "16000";
                    break;
                case ITTecrube.UstDuzeyTecrube:
                    Salary = "25000";
                    break;
                default:
                    break;
            }
        }


        public void ArizalarMudahaleEt()
        {

        }

        public void KodYaz()
        {

        }

        public void EkipToplantisiYap()
        {

        }

    }
}
