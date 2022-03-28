using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Emre");
            liste.Add(21);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("********************************");
            string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayılar = new List<int>() { 1, 8, 3, 4, 61, 643 };

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(liste.BinarySearch(9));

        }

    }
}
