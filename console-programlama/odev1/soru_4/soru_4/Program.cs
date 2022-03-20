using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle gir");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(new char[] { '.', '?', '!', ' ', ',' });

            Console.WriteLine("cümlede {0} kelime var", kelimeler.Length);
            Console.WriteLine("cümlede {0} tane harf var", cumle.Length - kelimeler.Length + 1);
        }
    }
}
