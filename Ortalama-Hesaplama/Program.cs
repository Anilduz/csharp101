using System;
namespace OrtalamaHesaplama{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Ortalama Hesaplama Programına Hoşgeldiniz");
            Console.WriteLine("Lütfen 1. Sayınızı giriniz");
            var number1 = Console.ReadLine();
            bool number1Bool = int.TryParse(number1, out int number1Out); 
            
            Console.WriteLine("Lütfen 2. sayınızı giriniz.");
            var number2 = Console.ReadLine();
            bool number2Bool = int.TryParse(number2, out int number2Out);

            Islemler islem = new Islemler();

            Console.WriteLine(islem.OrtalamaHesaplama(number1Out,number2Out));


        }
    }
    class Islemler{
        public int OrtalamaHesaplama(int sayi1, int sayi2){
            return (sayi1+sayi2)/2;
        }
    }
}