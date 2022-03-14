using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = DateTime.Now.Month;

            switch (months)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz");
                break;
            }

            switch (months)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Yaz ayındasınız");
                    break;
            }
        }
    }
}
