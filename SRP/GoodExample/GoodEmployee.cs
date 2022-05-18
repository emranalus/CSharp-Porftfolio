using SRP.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.GoodExample
{
    internal class GoodEmployee
    {

        Logger logger;
        string log;
        
        public GoodEmployee()
        {
            logger = new Logger();
        }

        public void CreateEmployee(Employee calisan)
        {
            try
            {
                string yazilacakSatir = calisan.Id + ";" + calisan.Name + ";"
                    + calisan.Surname + ";" + calisan.Salary;

                logger.LogFile("Calisanlar.txt", yazilacakSatir);
                log = "Kayit Tarihi" + DateTime.Now + ";" + calisan.Id;
                logger.LogFile("Log.txt", log);
            }
            catch (Exception ex)
            {
                log = "Kayit Tarihi" + DateTime.Now + ";" + calisan.Id;
                logger.LogFile("Hata.txt", log);
            }
        }

    }
}
