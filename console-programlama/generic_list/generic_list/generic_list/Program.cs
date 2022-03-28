using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Beyaz");
            renkListesi.Add("Yeşil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim.
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinden bulundu");
            }

            //Eleman ile index'e erişim

            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List'e çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?

            hayvanListesi.Clear();

            //List içerisinde nesne tutmak

            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Emre";
            kullanici1.Soyisim = "Öztürk";
            kullanici1.Yas = 24;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "ABCD";
            kullanici2.Soyisim = "EFGH";
            kullanici2.Yas = 25;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar() {
                Isim = "Merve",
                Soyisim = "Gevcxz",
                Yas = 211
            });

            foreach (var kullanıcı in kullanicilarListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaş: " + kullanıcı.Yas);

            }

        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
