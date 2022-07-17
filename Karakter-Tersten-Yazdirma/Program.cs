using System;

namespace TerstenYazdir{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Kelime veya Cümleyi Tersten yazdıran programa hoşgeldiniz!");
            Console.WriteLine("lütfen kelime veya cümle giriniz");
            var text = Console.ReadLine().ToString();
      
            Islemler islem = new Islemler();
            islem.Reverse(text);
            Console.ReadKey();
        }
        
    }
    class Islemler{
        public void Reverse(string str){
            
            if ((str == null) || (str.Length <= 1))
            {
            Console.Write(str); 
            }
            else
            { 
                Console.Write(str[str.Length-1]); 
                Reverse(str.Substring(0,(str.Length-1))); 
            } 
        }
    }
}