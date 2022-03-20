using System;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[sayi];
            Console.WriteLine("Lütfen girdiğiniz sayı kadar kelime giriniz");

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("{0}. kelimeyi gir.", i + 1);
                kelimeler[i] = Convert.ToString(Console.ReadLine());
            }

            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
