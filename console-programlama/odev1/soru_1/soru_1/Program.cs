using System;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çift sayı bulucu");
            Console.WriteLine("Kaç adet sayı sorgulamak istiyorsunuz?");


            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıları giriniz...Program size hangilerinin çift olduğunu söyleyecektir.");
            int[] ciftsayilar = new int[x];

            for (int i = 0; i < x; i++)
            {
                ciftsayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in ciftsayilar)
            {
                if (item % 2 == 0)
                    Console.WriteLine($"Çift olan sayı(lar) {item}", item);
                else
                    Console.WriteLine("Girdiğiniz sayıların hepsi tek!");

            }
        }
    }
}
