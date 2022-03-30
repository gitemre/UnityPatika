using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Emre";
            ogrenci1.Soyisim = "Öztürk";
            ogrenci1.OgrenciNo = 403;
            ogrenci1.Sinif = 0;
            ogrenci1.ogrenciBilgileriniGetir();
            ogrenci1.sinifAtlat();
            ogrenci1.ogrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",243,1);
            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();
            ogrenci2.ogrenciBilgileriniGetir();


        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if (sinif < 1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir");
                    sinif = 1;
                }
                sinif = value;
            }
                
        }

        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void ogrenciBilgileriniGetir()
        {
            Console.WriteLine("********Öğrenci Bilgileri**********");
            Console.WriteLine("Ogrenci Adi : {0}", this.isim);
            Console.WriteLine("Ogrenci Soyisim  :{0}", this.soyisim);
            Console.WriteLine("Ogrenci No :{0}", this.ogrenciNo);
            Console.WriteLine("Ogrenci Sinif : {0}", this.sinif);

        }

        public void sinifAtlat()
        {
            this.Sinif = this.sinif + 1;
        }
        public void sinifDusur()
        {
            this.Sinif = this.sinif - 1;
        }



    }
}
