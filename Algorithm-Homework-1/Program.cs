using System;

namespace homework_1{
    class Program{
        public static void Main (string[] args){
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Clear();
            try
            {
                Console.WriteLine("pozitif sayı giriniz");
                var x = Console.ReadLine();
                bool y = int.TryParse(x, out int n);


                if (n>0)
                {
                    for (int i = 0; i <= n; i++)
                    {
                        var a = Console.ReadLine();
                        bool b = int.TryParse(a, out int d);
                        

                        if (d % 2 == 0)
                        {
                            Console.WriteLine("Bu bir çift sayidir "+ d + " ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("lütfen pozitif bir sayı giriniz.");
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