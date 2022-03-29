using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümleyi girin");
            string[] girilenCumle = Console.ReadLine().Split(' ');
            string[] sesliHarfList = { "a", "e", "ı", "i", "o", "ö", "ü", "u" };
            ArrayList sesliHarf = new ArrayList();

            for (int i = 0; i < girilenCumle.Length; i++)
            {
                foreach (var item in sesliHarfList)
                {
                    if (girilenCumle[i].Contains(item))
                    {
                        sesliHarf.Add(item);
                    }
                }
            }

            Console.WriteLine("Sesli Harfler");
            foreach (var harf in sesliHarf)
            {
                Console.WriteLine(harf);
            }
        }
    }
}
