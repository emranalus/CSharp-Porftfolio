using System;
using System.Collections;

namespace ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1_kitapshop

            //int kitapSayisi, fiyat = 5;
            //float indirim = 0;
            //bool isStokta = true;
            //Console.Write("Satın Almak İstenilen Kitap Adetini Giriniz: ");
            //kitapSayisi = int.Parse(Console.ReadLine());

            //if (kitapSayisi < 20)
            //{
            //    indirim = fiyat * kitapSayisi * 5 / 100;
            //}
            //else if (kitapSayisi >= 20 && kitapSayisi < 50)
            //{
            //    indirim = fiyat * kitapSayisi * 10 / 100;
            //}
            //else if (kitapSayisi >= 50 && kitapSayisi < 100)
            //{
            //    indirim = fiyat * kitapSayisi * 25 / 100;
            //}
            //else if (kitapSayisi > 100)
            //{
            //    Console.WriteLine("Stokta Girilen Miktar Kadar Ürün Yok!");
            //    isStokta = false;
            //}

            //if (isStokta)
            //{
            //    Console.WriteLine($"Normal Tutar: {kitapSayisi * fiyat} ");
            //    Console.WriteLine($"Indirim Tutar: {indirim}");
            //    Console.WriteLine($"Odenecek Tutar: {(kitapSayisi * fiyat) - indirim}");
            //}


            #endregion

            #region ornek2_switchcase

            //string plaka = "";

            //Console.Write("Plaka Kodunu Giriniz: ");
            //plaka = Console.ReadLine();

            //if (plaka == "1" || plaka == "01")
            //{
            //    Console.WriteLine("Adana");
            //}
            //else if (plaka == "2" || plaka == "02")
            //{
            //    Console.WriteLine("Adiyaman");
            //}
            //else if (plaka == "3" || plaka == "03")
            //{
            //    Console.WriteLine("Afyon");
            //}
            //else if (plaka == "4" || plaka == "04")
            //{
            //    Console.WriteLine("Agri");
            //}

            //switch (plaka)
            //{
            //    case "1":
            //        Console.WriteLine("Adana");
            //        break;
            //    case "2":
            //        Console.WriteLine("Adiyaman");
            //        break;
            //    case "3":
            //        Console.WriteLine("Afyon");
            //        break;
            //    case "4":
            //        Console.WriteLine("Agri");
            //        break;
            //}

            #endregion

            #region ornek3_stingislemler

            //Console.Write("Kullanici Adi: ");
            //string username = Console.ReadLine();

            //username = username.ToLower();

            //switch (username)
            //{
            //    case "admin":
            //    case "moderator":
            //        Console.WriteLine("Hosgeldin Sahip! Yönetim Paneline Yönlendiriliyorsunuz...");
            //        break;
            //    case "guest":
            //        Console.WriteLine("Hosgeldin Üye! Üye Paneline Yönlendiriliyorsunuz...");
            //        break;
            //    default:
            //        Console.WriteLine("Bu sayfayi gorme yetkiniz yoktur!");
            //        break;
            //}

            #endregion

            #region ornek4_donguler

            // while true, yani while'a aslında gerek yok en azından while true için
            // go dili while kullanmaz
            //for (; true ;)
            //{
            //    Console.WriteLine("bö");
            //}

            //int sayac = 0;
            //do
            //{
            //    // ne olursa olsun bir kez bunu yap eğer while koşulu doğru ise 
            //    // tekar etmeye başla
            //}while (sayac <= 100);

            #endregion

            #region ornek5_gunsoru

            // ayin ilk gunu pazartesidir
            // ay 30 gundur hafta sonlarına gelen ayın günlerini basın

            //for (int i = 7; i < 30; i=i+7)
            //{

            //    Console.WriteLine(i);

            //}


            // pandemi yillarini bastirma 2020 ve 2021

            //int baslangicYili = 2020;
            //int bitisYili = 2021;

            //for (int i = 2010; i < DateTime.Now.Year; i++)
            //{
            //    if (i != baslangicYili && i != bitisYili) Console.WriteLine(i);
            //}

            #endregion

            #region ornek6_arrayler

            //string[] siniftakiler = { "Ali", "Veli", "Ayşe", "Fatma" };
            //float[] vize1 = { 30, 40, 50, 35 };
            //float[] vize2 = { 50, 40, 45, 50 };
            //float[] final = { 50, 55, 60, 50 };

            //// siniftaki herkesin tek tek vize ortalaması
            //float ortalama;
            //for (int i = 0; i < siniftakiler.Length; i++)
            //{
            //    ortalama = ((vize1[i] + vize2[i])/2*30/100 + final[i]);
            //    Console.WriteLine(siniftakiler[i] + " - " + ortalama);
            //}

            #endregion

            #region ornek7_zarat

            //Console.Write("Kac kere zar atilacagini gir: ");
            //int adet = int.Parse(Console.ReadLine());

            //Random r = new Random();

            //float turaSay = 0;
            //float yaziSay = 0;

            //for (int i = 0; i < adet; i++)
            //{

            //    if (r.Next(0, 2) == 1)
            //    {
            //        turaSay++;
            //    }
            //    else
            //    {
            //        yaziSay++;
            //    }

            //}

            //Console.WriteLine($"Gelen Yazi: {yaziSay} \nGelen Tura: {turaSay} \nOran: {yaziSay / turaSay}");

            #endregion

            #region ornek8_basketmaci

            // deneme sayisi ekrandan alinacak her atilan basket sonucu bir dizide tutulacak
            // iki takimin musabakasini yapiniz sonucuda ekrana bastiriniz

            //Random r = new Random();
            //byte denemeSayisi = 100;

            //byte[] FenerBahce = new byte[denemeSayisi];
            //byte[] GalataSaray = new byte[denemeSayisi];

            //for (int i = 0; i < denemeSayisi; i++)
            //{

            //    if (i % 15 == 0)
            //    {// hile hurda hihihi
            //        FenerBahce[i] = (byte)r.Next(0, 4);
            //        GalataSaray[i] = (byte)r.Next(2, 4);
            //    }
            //    else
            //    {
            //        FenerBahce[i] = (byte)r.Next(0, 4);
            //        GalataSaray[i] = (byte)r.Next(0, 4);
            //    }
            //}

            //int bos = 0, serbestAtis = 0, ikiliAtis = 0, ucluAtis = 0;
            //int gsbos=0, gsSerbest=0, gsikiliAtis=0, gsuAtis=0;

            //for (int i = 0; i < denemeSayisi; i++)
            //{
            //    switch (FenerBahce[i])
            //    {
            //        case 0:
            //            bos++;
            //            break;
            //        case 1:
            //            serbestAtis++;
            //            break;
            //        case 2:
            //            ikiliAtis++;
            //            break;
            //        case 3:
            //            ucluAtis++;
            //            break;
            //    }
            //    switch (GalataSaray[i])
            //    {
            //        case 0:
            //            gsbos++;
            //            break;
            //        case 1:
            //            gsSerbest++;
            //            break;
            //        case 2:
            //            gsikiliAtis++;
            //            break;
            //        case 3:
            //            gsuAtis++;
            //            break;
            //    }
            //}

            //Console.WriteLine("Cekilen Sut      Fenerbahce      Galatasaray");
            //Console.WriteLine("-----------      ----------      -----------");
            //Console.WriteLine($"Bos - 0           {bos}             {gsbos}");
            //Console.WriteLine($"Serbest - 1       {serbestAtis}             {gsSerbest}");
            //Console.WriteLine($"Ikilik - 2        {ikiliAtis}             {gsikiliAtis}");
            //Console.WriteLine($"Ucluk - 3         {ucluAtis}             {gsuAtis}");
            //Console.WriteLine(" ");
            //Console.WriteLine($"Mac Sonucu        {serbestAtis+ikiliAtis+ucluAtis}" +
            //    $"             {gsikiliAtis+gsSerbest+gsuAtis}");



            #endregion

            #region ornek9_ArrayListler

            ArrayList dizi = new ArrayList();
            dizi.Add("Adana");
            dizi.Add(1);
            dizi.Add(DateTime.Now);
            dizi.Add(true);

            foreach (object i in dizi)
            {
                Console.WriteLine(i);
            }

            #endregion
        }
    }
}
