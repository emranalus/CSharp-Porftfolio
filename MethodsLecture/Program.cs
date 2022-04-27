using System;

namespace MethodsLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Sum(3, 5);
            Console.WriteLine(toplam);
            Console.WriteLine(Sum("a","b"));

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
    }
}
