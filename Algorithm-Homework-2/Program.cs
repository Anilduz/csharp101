using System;

namespace homework_2{
    class Program{
        public static void Main (string[] args){
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Clear();
            try
            {
                
            Console.WriteLine("ilk sayiyi gir");
            var a = Console.ReadLine();

            Console.WriteLine("ikinci sayiyi gir");
            var b = Console.ReadLine();

            bool c = int.TryParse(a, out int n);
            bool d = int.TryParse(b, out int m);

            if(n > 0 && m > 0)
            {
                Console.WriteLine(n + " tane sayı giriniz;");
                for (int i = 1; i <= n; i++)
                {

                    Console.WriteLine(i + " .sayıyı giriniz;");
                    var e = Console.ReadLine();
                    bool h = int.TryParse(e, out int f);
                    
                    if(m % f == 0){
                        Console.WriteLine("bu sayı m'e eşit yada tam bölünüyor.");
                    }
                    else
                    {
                        Console.WriteLine("bu sayi tam bölünmüyor");
                    }
                }
            }
               
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}