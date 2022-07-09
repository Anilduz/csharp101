using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           //out parametreler
           string sayi1 = "99a9";

            bool sonuc = int.TryParse(sayi1, out int sayiOut);
            if (sonuc)
            {
                    Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("başarısız");
            }

           Metotlar instance = new Metotlar();
           instance.Topla(5,6, out int toplamSonuc);
           Console.WriteLine(toplamSonuc);

           //metot aşırı yükleme - Overloading
           int ifade=999;
           instance.EkranaYazdir(Convert.ToString(ifade));
           instance.EkranaYazdir(ifade);
           instance.EkranaYazdir("anıl","düz");

           //Metot Imzası
           

        }
        class Metotlar{
            public void Topla(int a, int b, out int toplam){
                toplam = a+b;
            }
            public void EkranaYazdir(string veri){
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri){
                Console.WriteLine(veri);
            }
             public void EkranaYazdir(string veri, string veri2){
                Console.WriteLine(veri + veri2);
            }
        }
    }
}