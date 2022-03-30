using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Emre";
            calisan1.soyad = "Öztürk";
            calisan1.no = 403;
            calisan1.departman = "QA";

            calisan1.calisanBilgiler();

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Ahmet";
            calisan2.soyad = "Öztürk";
            calisan2.no = 563;
            calisan2.departman = "Dev";

            calisan2.calisanBilgiler();  
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;
        
        public void calisanBilgiler()
        {
            Console.WriteLine("Çalışan adı:{0}", ad);
            Console.WriteLine("Çalışan soyad:{0}", soyad);
            Console.WriteLine("Çalışan no:{0}", departman);
            Console.WriteLine("Çalışan departman:{0}", departman);

        }
    }
}
