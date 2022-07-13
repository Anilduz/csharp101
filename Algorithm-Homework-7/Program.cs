using System;
using System.Collections;

namespace Homework_7{
    class Program{
        public static void Main(string[] args){
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
           Console.Clear();

            ArrayList harfler = new ArrayList();
            try
            {  
            Console.WriteLine("lütfen cümlenizi veya kelimenizi giriniz");
            var text = Console.ReadLine().ToString();
            char[] sesli = { 'a', 'e', 'o', 'ö', 'u', 'ü', 'ı','i','A','E','O','Ö','U','Ü','I','İ'};

            
                //karakter katarkter kontrol ediyoruz.
                foreach (var item in text)
                {
                    foreach (var item2 in sesli)
                    {
                        if (item == item2)
                        {
                            harfler.Add(item2);
                        }
                    }
                }
            

            foreach (var item in harfler)
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