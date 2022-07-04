using System;
using System.Linq;

namespace ExampleLessonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try
             {
                 var speed = "5g0";

                 int speedOut;
                 var b = int.TryParse (speed, out speedOut);
                 int returnedSpeed = Convert.ToInt32(speedOut) + 10;

                 if (returnedSpeed <= 50)
                 {
                     Console.WriteLine("Düsük hız");
                     Console.ReadLine();
                 }
                 else if (returnedSpeed > 50 && returnedSpeed <= 80) {
                     Console.WriteLine("Orta Seviye hız");
                     Console.ReadLine();
                 }
                 else {
                     Console.WriteLine("Yüksek hız");
                     Console.ReadLine();
                 }
             }

             catch(Exception ex)
             {
                 Console.Write("beklenmedik bir hata ile karşılaşıldı, speed hızı istenen formatta değil");
             }

             */
            try
            {
                Console.WriteLine("Tanımlayacağınız array'in eleman sayısını girin.");
                var value1 = Console.ReadLine();
                var value1int = value1;
                int value1out = 0;
                var a = int.TryParse(value1int, out value1out);
                
                    int[] array1 = new int[value1out];

                    for (int i = 0; i < value1out; i++)
                    {
                        Random rndm = new Random();
                        array1[i] = rndm.Next(1, 10);

                    }

                    foreach(int eleman in array1)
                    {
                    Console.Write("1. array elemanları");
                    Console.WriteLine(eleman);
                    }

                
                var value2 = Console.ReadLine();
                int value2out = 0;
                var c = int.TryParse(value2, out value2out);


                
                    int[] array2 = new int[value2out];

                    for (int i = 0; i < value2out; i++)
                    {
                        Random rndm2 = new Random();
                        array2[i] = rndm2.Next(1,10);
                    }

                    foreach (int eleman in array2)
                    {
                    Console.Write("2. array elemanları");
                    Console.WriteLine(eleman);
                    }

                Console.WriteLine("");
                Console.WriteLine("array merge: ");
                int[] sonuc = new int[array1.Length + array2.Length];

                for (int i = 0; i < array1.Length; i++)
                {

                    foreach (var array1element in array1)
                    {
                        foreach (var array2element in array2)
                        {
                            if (array1element == array2element)
                            {
                                Random rndm2 = new Random();
                                sonuc[i] = rndm2.Next();
                            }
                            else
                            {
                                sonuc[i] = array1[i];
                            }
                        }
                    }
                    
                    
                }

                for (int i = 0; i < array2.Length; i++)
                {
                    foreach (var array2element in array1)
                    {
                        foreach (var array1element in array2)
                        {
                            if (array1element == array2element)
                            {
                                Random rndm2 = new Random();
                                sonuc[i] = rndm2.Next();
                            }
                            else
                            {
                                sonuc[array1.Length+i] = array2[i];
                            }
                        }
                    }
                }

                
                    foreach (var elements in sonuc)
                    {
                  
                        Console.Write("3. array elemanları");
                        Console.WriteLine(elements);
                 
                    }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
         
            Console.ReadKey();

        }

    }
}
