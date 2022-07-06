using System;

namespace loops_2{

    class Program{
        public static void Main (string[] args){

            Console.Clear();
            Console.WriteLine("lütfen bir sayı girin");
           int sayi1 = int.Parse(Console.ReadLine());
           int sayac = 1;
           int sum = 0;
           while(sayac <= sayi1){
                sum += sayac;
                sayac++;
                
           }
           Console.WriteLine(sum/sayi1);

           Char chr = 'a';

           while (chr <= 'z')
           {
            Console.Write(chr);
            chr++;
           }
            Console.WriteLine("-------------");
            Console.WriteLine("FOREACH-------------");
            string[] cars= {"ford", "kia", "hyundai"};

           foreach (var item in cars)
           {
            Console.WriteLine(item);
           }
       
        }
    }
}