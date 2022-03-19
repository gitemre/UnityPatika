using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarılı!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);

        }
    }

    class Metotlar
    {
        public void Topla(int a , int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
