﻿using System;
using System.Collections.Generic;

namespace MethodsLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int toplam = Sum(3, 5);
            //Console.WriteLine(toplam);
            //Console.WriteLine(Sum("a","b"));

            AsalBul();

            

        }

        public static int Sum(int sayi1, int Sayi2)
        {
            return sayi1 + Sayi2;
        }

        public static int Sum(float sayi1, int sayi2)
        {
            return ((int)sayi1 + sayi2);
        }

        /// <summary>
        /// Sums up two string value
        /// </summary>
        /// <param name="a">String Tipinden İlk Değer</param>
        /// <param name="b">Second String Value</param>
        /// <returns>İki Stringi Toplar</returns>
        public static string Sum(string a, string b)
        {
            return a + b;
        }

        //Sadece 1'e ve kendine bölünebilen pozitif tam sayılara asal sayılar denir.
        //Kod ile bir sayının 1'e ve kendine bölünemediği nasıl anlaşılır
        //önce kontrol sonra basım yapılabilir

        //rastgele[i] nin içindeki her sayıyı 1 den başlayarak listenin uzunluğuna kadar olan ardaşık sayılar ile böl
        //her sayı 1'e ve kendisine bölünür
        //1 ve kendisi hariç bir sayı ile bölümü 0 eden bir sayı asal olamaz
        //her sayı 1'e bölünür
        //bir sayı ile bölümü sonucu 0 sa ve o sayı kendisi değilse o sayı asal değildir

        //4 sayısı 2 sayısı ile bölünürse asal değildir
        public static void AsalBul()
        {
            int[] rastgele = new int[50];
            List<int> asallar = new List<int>();
            
            Random rand = new Random();

            // Listenin içinin doldurulması
            for (int i = 1; i < rastgele.Length; i++)
            {
                rastgele[i] = rand.Next(1, 51);
            }

            // Listedeki değişkenlerin kontrolu
            // 1 ve kendisi hariç herhangi bir sayıya bölüneni bul o sayı asal değil elsi bas

            //for (int i = 2; i < sayi; i++)
            //{
            //    if(sayi%i==0)
            //}
            // sayiyi kontrol eden metod yaz ve sayının kendisine kadar for dön eğer bölündüğü varsa
            // asal değildir

            for (int i = 1; i < rastgele.Length; i++)
            {

                for (int j = 2; j < rastgele.Length+1; j++)
                {
                    // sayinin j ile bolumu 0 ise ve sayi j den farklı ise sayı asaldır
                    if (rastgele[i] % j == 0 && j != rastgele[i])
                    {
                        // Asal Değil Geç
                        break;
                    }
                    else
                    {
                        asallar.Add(rastgele[i]);
                        break;
                    }
                }

            }

            // Asalları Bas
            for (int i = 0; i < asallar.Count; i++)
            {
                Console.WriteLine(asallar[i]);
            }

            // Ödev 1
            // - Rastgele Sifre Ureten Metod -
            // En az 1 tane büyük harf olucak
            // En az 1 sayı olucak ve en az 8 karakter olucak

            // Ödev 2
            // - Verilen sayının asal sayı olup olmadığını belirleyen metod -



        }

    }
}
