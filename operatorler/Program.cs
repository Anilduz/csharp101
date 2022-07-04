using System;

namespace Operators{
class Program{
  
    public static void Main(string[] args)
    {
        
        //Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
        int x = 3;
        int y = 2;

        y = y+2;
        Console.WriteLine(y);
        y += 2;
        y -= 2;
        Console.WriteLine(y);

        y/= 2;
        Console.WriteLine(y);
        y=y / 2;
        Console.WriteLine(y);

        bool isSuccess = true;
        bool isComplete = false;

        //Mantıksal Operatörler (||, &&, !)
        if (isSuccess && isComplete)
        {
            Console.WriteLine("perfect");
        }

        if (isSuccess || isComplete)
        {
            Console.WriteLine("great");
        }
        if (isSuccess && !isComplete)
        {
            Console.WriteLine("fine!");
        }

        //İlişkisel Operatörler (==,!=, <, >, >=,<=)

        Console.WriteLine("İlişkisel Operatörler (==,!=, <, >, >=,<=)");
        int a = 3;
        int b = 4;

        bool sonuc = a < b;
        Console.WriteLine(sonuc);
        sonuc = a >= b;
        Console.WriteLine(sonuc);
        sonuc = a <= b;
        Console.WriteLine(sonuc);
        sonuc = a == b;
        Console.WriteLine(sonuc);
        sonuc = a != b;
        Console.WriteLine(sonuc);

        

        //Aritmetik (+, -, *, /, %, ++, --)
        Console.WriteLine("Aritmetik (+, -, *, /, %, ++, --)");

        int sayi1 = 10;
        int sayi2 = 5;

        int sonuc2 = sayi1/sayi2;
        Console.WriteLine(sonuc2);
        sonuc2 = sayi1-sayi2;
        Console.WriteLine(sonuc2);
        sonuc2 = sayi1*sayi2;
        Console.WriteLine(sonuc2);
        sonuc2 = sayi1+sayi2;
        Console.WriteLine(sonuc2);
        sonuc2 = sayi1%sayi2;
        Console.WriteLine(sonuc2);
        sonuc2 = ++sayi1;
        Console.WriteLine(sonuc2);
        sonuc2 = --sayi2;
        Console.WriteLine(sonuc2);


    
    }
    
}

}