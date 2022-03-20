using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayının bir sonraki gireceğiniz sayıya eşit yada tam bölündüğünü merak ediyorsunuz?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Şimdi gireceğiniz sayı ise ilk girdiğiniz sayı veya sayılardan birine tam bölünüp bölünmediğini ve eşit olup olmadığını söyleyecek.");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayıları giriniz");
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı gir", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());

            }
            foreach (var i in sayilar)
            {
                if (i == m || i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
