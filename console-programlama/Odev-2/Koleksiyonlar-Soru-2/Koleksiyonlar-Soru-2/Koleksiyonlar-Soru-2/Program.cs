using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] butunSayilar = new int[20];
            int[] enKucukler = new int[3];
            int[] enBuyukler = new int[3];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz.", i + 1);
                butunSayilar[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(butunSayilar);
            double kucukOrt = 0;
            for (int i = 0; i < 3; i++)
            {
                enKucukler[i] = butunSayilar[i];
            }
            Console.WriteLine("Dizideki En küçük 3 Eleman");
            foreach (var item in enKucukler)
            {
                Console.WriteLine(item);
                kucukOrt += item;
            }
            double buyukOrt = 0;
            Array.Reverse(butunSayilar);
            for (int i = 0; i < 3; i++)
            {
                enBuyukler[i] = butunSayilar[i];
            }
            Console.WriteLine("Dizideki En Büyük 3 Eleman");
            foreach (var item in enBuyukler)
            {
                Console.WriteLine(item);
                buyukOrt += item;
            }
            Console.WriteLine("Küçükler Ortalaması: " + kucukOrt / 3);
            Console.WriteLine("Büyükler Ortalaması: " + buyukOrt / 3);
            Console.WriteLine("Küçük Ortalama Toplamı " + kucukOrt);
            Console.WriteLine("Büyük Ortalama Toplamı: " + buyukOrt);
        }
    }
}
