using System;

namespace enum_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hava biraz daha ısınmalı");
            }else if(sıcaklık>= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarı çıkmak için sıcak bir gün");

            }else if(sıcaklık>= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
            {

            }
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
           
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}
