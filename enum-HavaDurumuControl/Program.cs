using System;

namespace enum_kavrami{
    class Program{
        public static void Main(string[] args){
             
            Console.Clear();
            Console.WriteLine("hello world");
            Console.WriteLine(Gunler.Cumartesi);
            Console.WriteLine(((int)Gunler.Pazar));

            Console.WriteLine("sıcaklığı girin");
            var a = Console.ReadLine();
            bool b = int.TryParse(a, out int c);
            if (c <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarı çıkmak için havanın biraz daha ısınmasını bekleyelim");
            }
            else if(c >= (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(c >= (int)HavaDurumu.Normal && c < (int)HavaDurumu.CokSicak){
                Console.WriteLine("Hadi dışarıya çıkalım");
            }
            
        }
    }
    enum Gunler 
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar    
    }
    enum HavaDurumu
    {
        Soğuk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
} 