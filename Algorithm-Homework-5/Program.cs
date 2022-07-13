using System;
using System.Collections;

namespace Homework_6{
    class Program{
        public static void Main(string[] args){
           Console.Clear();
            try
            {
              ArrayList asalList = new ArrayList();
              ArrayList notAsalList = new ArrayList();
              for (int i = 0; i < 20; i++)
              {
                Console.WriteLine("lütfen "+ (i+1) +". sayiyi giriniz.");
                var a = Console.ReadLine();
                bool parseA = int.TryParse(a, out int aOut); 
                int control = 0;

                for (int x = 2; x < aOut; x++)
                {
                    if (aOut % x == 0)
                        control++;
                }

                if (control != 0 || control == 1){
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
                notAsalList.Add(aOut);
                }
                
                else{
                Console.WriteLine("Girdiğiniz sayı asaldır.");
                asalList.Add(aOut);
                
                }
              }
              Console.WriteLine("asal olan sayılar;");
              foreach (var item in asalList)
              {
                Console.WriteLine(item);
              }

              Console.WriteLine("asal olmayan sayılar;");
              foreach (var item in notAsalList)
              {
                Console.WriteLine(item);
              }
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }

             Console.ReadKey();
        }
    }
    
}   