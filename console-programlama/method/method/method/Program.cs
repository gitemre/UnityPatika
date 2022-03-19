using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(Topla(3,5)));

            int sonuc2 = ornek.ArttırveTopla(3, 1);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
        }

        public static int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string val1)
        {
            Console.WriteLine(val1);
        }

        public int ArttırveTopla(int deger1,int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
