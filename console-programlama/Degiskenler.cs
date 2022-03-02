using System;

namespace console_programlama
{
    class Degiskenler
    {
        static void Main(string[] args)
        {
            byte b = 5;  //1 byte
            sbyte c = 5; //1 byte

            short s = 5; //2bute
            ushort us = 5; //2byte

            Int16 i16 = 2; //2Byte
            int i = 2; //4 byte
            int i32 = 2; //4byte
            Int64 i64 = 2; //8byte

            uint ui = 2; //4byte
            long l = 4; //8byte
            ulong ul = 4; //8 byte


            //Reel Sayılar
            float f = 5; //4 byte
            double d = 5; //8byte
            decimal de = 5; //16 byte

            char ch = 'a'; //2byte
            string str = "Emre"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "X";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Emre Öztürk";


            //integer tanımlama 

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            bool bool1 = 10 > 2;

            // Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();

            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);




        }
    }
}
