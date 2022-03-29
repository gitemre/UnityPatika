using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sira = 1;
            int adim = 20;
            ArrayList asalolanlarListesi = new ArrayList();
            ArrayList asalolmayanlarListesi = new ArrayList();
            while (adim > 0)
            {
                Console.WriteLine("{0}. sayıyı giriniz ", sira++);
                try
                {
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi > 1)
                    {
                        for (int i = 2; i < sayi; i++)
                        {
                            if (sayi % i == 0)
                            {
                                asalolmayanlarListesi.Add(sayi);
                                break;
                            }
                        }

                        if (!asalolmayanlarListesi.Contains(sayi))
                        {
                            asalolanlarListesi.Add(sayi);
                        }
                        adim--;
                    }
                    else
                    {
                        Console.WriteLine("Negatif sayı girmeyiniz ! ");
                        sira--;
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata : " + e.Message.ToString());
                    sira--;
                }
            }
            Console.WriteLine();
            asalolanlarListesi.Sort();
            asalolmayanlarListesi.Sort();
            int asalToplam = 0;
            int asalolmayanToplam = 0;
            Console.WriteLine("ASALLAR");
            foreach (int i in asalolanlarListesi)
            {
                Console.WriteLine(i);
                asalToplam += i;
            }
            Console.WriteLine("Asal Uzunluk : " + asalolanlarListesi.Count);
            Console.WriteLine("Asal ortalaması  : " + (asalToplam / asalolanlarListesi.Count));
            Console.WriteLine("ASAL OLMAYANLAR");
            foreach (int i in asalolmayanlarListesi)
            {
                Console.WriteLine(i);
                asalolmayanToplam += i;
            }
            Console.WriteLine("Asal olmayan uzunluk  : " + asalolmayanlarListesi.Count);
            Console.WriteLine("Asal olmayan ortalaması : " + (asalolmayanToplam / asalolmayanlarListesi.Count));

        }
    }
}
