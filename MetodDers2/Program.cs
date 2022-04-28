using System;

namespace MetodDers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OrnekIndexOf();
            //OrnekRemove();
            //OrnekReplace();
            OrnekSplit();
        }

        //public static void Ornek

        public static void OrnekSplit()
        {
            string ornekMetin = "jahndsjahskjldh83y2 hkljuafkjahsdlf 8372834 njdhfkasdf";
            string[] kelimeler = ornekMetin.Split(" ");

            Console.WriteLine(kelimeler.Length);

            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
            
        }

        public static void OrnekReplace()
        {
            string ornekMetin = "bugun hava cok guzel";
            string yeniMetin = ornekMetin.Replace("guzel", "berbat");

            Console.WriteLine(ornekMetin);
            Console.WriteLine(yeniMetin);
        }

        public static void OrnekRemove()
        {
            string metin1 = "havaaaacokgusel";
            string metin2 = metin1.Remove(5);
            Console.WriteLine(metin1);
            Console.WriteLine(metin2);
        }

        public static void OrnekIndexOf()
        {
            string metin = "asdasdu";
            int index = metin.IndexOf('u');
            Console.WriteLine("Index Number: " + index);
        }

    }
}
