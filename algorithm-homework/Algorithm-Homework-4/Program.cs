using System;

namespace homework_4{
    class Program{
        public static void Main(string[] args){


            Console.Clear();

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            try
            {
                Console.WriteLine("bir cümle veya kelime giriniz");

                var x = Console.ReadLine().ToString();
                var y = x.Split(' ');
                Console.WriteLine("cümledeki kelime sayısı " + y.Length);
                int z = x.Length - y.Length;
                Console.WriteLine("cümledeki harf sayısı " + (z + 1));

                
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
}