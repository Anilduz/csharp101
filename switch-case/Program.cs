using System;
namespace cases{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Hello World");
            Console.Clear();

            int month = DateTime.Now.Month;
            switch (month)
            {

                case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;

                case 2: 
                Console.WriteLine("şubat ayındasınız");
                break;

                case 3: 
                Console.WriteLine("mart ayındasınız");
                break;

                case 4:
                Console.WriteLine("nisan ayındasınız");
                break;

                case 5:
                Console.WriteLine("mayıs ayındasınız");
                break;
                
                case 6:
                Console.WriteLine("haziran ayındasınız");
                break;

                case 7:
                Console.WriteLine("temmuz ayındasınız");
                break;

                case 8:
                Console.WriteLine("ağustos ayındasınız");
                break;

                case 9:
                Console.WriteLine("eylül ayındasınız");
                break;
                
                case 10:
                Console.WriteLine("ekim ayındasınız");
                break;

                case 11:
                Console.WriteLine("kasım ayındasınız");
                break;
                
                case 12:
                Console.WriteLine("aralık ayındasınız");
                break;


                default:
                Console.WriteLine("ay bilgisi bulunamadı");
                break;    
            
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Mevsim: kış");
                break;

                case 3:
                case 4:
                case 5:
                Console.WriteLine("Mevsim: ilkbahar");
                break;

                case 6:
                case 7:
                case 8:
                Console.WriteLine("Mevsim: yaz");
                break;

                case 9:
                case 10:
                case 11:
                Console.WriteLine("Mevsim: sonbahar");
                break;

                
            }
                Console.ReadKey();

        }
    }
}