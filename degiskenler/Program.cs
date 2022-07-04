using System;

namespace degisken
{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");

        byte b = 5; //1 byte
        sbyte c = 4; //1 byte
        short s = 5; //2 byte
        ushort us = 5; //2 byte


        Int16 i16 = 2; //2 byte
        int i = 2; //4 byte
        Int32 i32 = 2; //4 byte
        Int64 i64 = 2; //8 byte

        uint ui = 4; //4 byte
        long l = 4; //8 byte
        ulong ul = 4; //8 byte

        // Reel sayılar
        float f = 5; //4 byte
        double d = 5; //8 byte
        decimal de = 5; //16 byte

        char ch = '2'; //2 byte
        string str = "asd"; //unlimited

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now; 
        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 423.21;

        //string ifadeler
        string str1 = string.Empty;
        str1 = "anıl düz";
        string str2 = "Anıl";
        string str3 = "Düz";
        string str4 = str2 + str3;
        Console.WriteLine(str2 + " " + str3);
        Console.WriteLine(str4);
        Console.WriteLine("Str1 ; " + str1);

        //int ifadeler
        int int1 = 5;
        int int2 = 3;
        int int3 = int1 * int2;
        Console.WriteLine(int3);

        //bool ifadeler
        bool bool1 = 16>2;
        bool bool2 = 2>16;

        //değişken dönüşümleri
        string str20 = "20";
        int int20=20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger);

        int int30= 30;
        string str30= "30";
        int int60 = int30 + Convert.ToInt32(str30);
        Console.WriteLine(int60);

        
        int int22 = int20 + int.Parse(str20);
        
        //datetime formats

        string datetime = DateTime.Now.ToString();
        string datetime2 = DateTime.Now.ToString("dd.MM.yyyy");
        string datetime3 = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine(datetime);
        Console.WriteLine(datetime2);
        Console.WriteLine(datetime3);
        }
    }
}