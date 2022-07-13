using System;

namespace homework_3{
    class Program{
        public static void Main(string[] args){
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
            try
            {
                Console.WriteLine("bir pozitif sayı giriniz");

                var x = Console.ReadLine();
                bool c = int.TryParse(x, out int y);
                if(y > 0){
                    for (int i = 0; i < y; i++)
                    {
                        var text = Console.ReadLine().ToString();
                        Console.WriteLine(text.Reverse().ToArray());
                    }
                }
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
}