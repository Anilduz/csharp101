using System;
using System.Collections;

namespace Homework_6{
    class Program{
        public static void Main(string[] args){
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
            //(Array sınıfını kullanarak yazınız.)
           Console.Clear();
            try
            {
              ArrayList sayilar = new ArrayList();
              ArrayList buyukSayilar = new ArrayList();
              ArrayList kucukSayilar = new ArrayList();

              for (int i = 0; i < 20; i++)
              {
                Console.WriteLine("lütfen "+ (i+1) +". sayiyi giriniz.");
                var a = Console.ReadLine();
                bool parseA = int.TryParse(a, out int aOut); 

                sayilar.Add(aOut);
                }

                sayilar.Sort();
                Console.WriteLine("sıralanmış dizi");

                for (int i = 0; i <= 2; i++)
                {

                    kucukSayilar.Add(sayilar[i]);
                   
                }
                for (int i = 17; i <= 19; i++)
                {
                   buyukSayilar.Add(sayilar[i]);
                }
                int buyukToplam = 0;
                Console.WriteLine("BÜYÜK SAYILAR DİZİSİ");
                foreach (var item in buyukSayilar)
                {
                    Console.WriteLine(item);
                    buyukToplam += Convert.ToInt32(item);
                       
                }
                int ortBuyuk = buyukToplam/3;
                Console.WriteLine("büyük sayıların ortalaması: " +ortBuyuk);


                int kucukToplam = 0;
                Console.WriteLine("Küçük SAYILAR DİZİSİ");
                foreach (var item in kucukSayilar)
                {
                    Console.WriteLine(item);
                    kucukToplam += Convert.ToInt32(item);
                }
                int ortKucuk = kucukToplam/3;
                Console.WriteLine("küçük sayıların ortalaması: " +ortKucuk);

                int tumOrt = (ortBuyuk + ortKucuk)/2;
                Console.WriteLine("büyük ve küçük ortalamaların ortalaması: " +tumOrt);
               
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }

             Console.ReadKey();
        }
    }
    
}   