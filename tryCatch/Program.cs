using System;

namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1
            // ekrandan kullanici adi parola girilecek
            // yanlissa girmeyecek
            // username:Admin
            // password:qweasd

            //string username, password;

            //Console.WriteLine("ADMIN GIRIS PANELI\n-------------------------------");
            //Console.Write("Kullanici adi giriniz: ");
            //username = Console.ReadLine();
            //Console.Write("Sifreyi giriniz: ");
            //password = Console.ReadLine();

            //if(username == "Admin" && password == "qweasd") 
            //{
            //    Console.WriteLine("GIRIS BASARILI!");
            //}
            //else if(username == "Admin" && password != "qweasd")
            //{
            //    Console.WriteLine("Sifre hatali");
            //}
            //else if (username != "Admin" && password == "qweasd")
            //{
            //    Console.WriteLine("Kullanici adi hatali");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanici adi ve sifre hatali");
            //}
            #endregion

            #region ornek2

            int not;

            while (true)
            {
                try
                {

                    Console.Write("Notunuzu Giriniz: ");
                    not = int.Parse(Console.ReadLine());

                    if (not >= 0 && not < 30)
                    {
                        Console.WriteLine("Notunuz FF");
                    }
                    else if (not >= 30 && not < 50)
                    {
                        Console.WriteLine("Notunuz DD");
                    }
                    else if (not >= 50 && not < 70)
                    {
                        Console.WriteLine("Notunuz BB");
                    }
                    else if (not >= 70 && not < 100)
                    {
                        Console.WriteLine("Notunuz AA");
                    }
                    else
                    {
                        Console.WriteLine("Hata! Tekrar Deneyiniz!");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata! Tekrar Deneyiniz!");
                }
            }

            #endregion

        }
    }
}
