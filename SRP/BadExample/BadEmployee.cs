using SRP.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.BadExample
{
    public class BadEmployee
    {

        public void CreateEmployee(Employee calisan)
        {
            try
            {
                string yazilacakSatir = calisan.Id + ";" + calisan.Name + ";"
                    + calisan.Surname + ";" + calisan.Salary;

                string logstr = "Kayit Tarihi" + DateTime.Now + ";" + calisan.Id;

                File.WriteAllText("Log.Txt", logstr);
            }
            catch (Exception ex)
            {
                string hata = DateTime.Now + ";" + ex.Message;
                Console.WriteLine(hata);
            }
        }

    }
}
