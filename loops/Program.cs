using System;

namespace loops{

    class Program{
        public static void Main (string[] args){
            Console.Clear();
           
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    
                    Console.WriteLine(i + " Tek sayı ");
                }
                else{
                    Console.WriteLine(i + " Çift sayı ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************");

            int tekSum=0;
            int ciftSum=0;  
           
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                   tekSum += i;
                } 
                else
                    ciftSum += i;
                
                
            }
            
            Console.WriteLine("Tek sayılar toplamı : " + tekSum);
            Console.WriteLine("Çift sayılar toplamı : " + ciftSum);


            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
               
            }

              for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                    
                }
                Console.WriteLine(i);
               
            }
        }
    }
}