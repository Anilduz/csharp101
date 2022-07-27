using System;
namespace alan_calculator{
    class Program{
        public static void Main(string[] args){
            while (true)
            {
                
                try
                {
                    Console.WriteLine("alanını hesaplamak istediğiniz seçeneği rakam ile belirtiniz");
                    Console.WriteLine("1-kare");
                    Console.WriteLine("2-üçgen");
                    Console.WriteLine("3-dikdörtgen");
                    Console.WriteLine("4-Daire");

                    var processResult = Console.ReadLine();
                    bool result = int.TryParse(processResult, out int x);
                
                    switch (x)
                    {
                        case 1:
                        Console.WriteLine("lütfen kare şeklinize ait bir kenar uzunluğu giriniz");
                        var kare = Console.ReadLine();
                        bool kareR = int.TryParse(kare, out int kareKenar);
                        int kareAlan = kareKenar * kareKenar;
                        Console.WriteLine("kare şeklinizin alan hesaplaması: {0}",kareAlan);
                        break;

                        case 2:
                        Console.WriteLine("lütfen üçgen şeklinize ait bir taban uzunluğu giriniz");
                        var ucgenKenari1 = Console.ReadLine();
                        bool ucgenR = int.TryParse(ucgenKenari1, out int ucgenKenar1Result);

                        Console.WriteLine("lütfen üçgen şeklinize ait bir yukseklik uzunluğu giriniz");
                        var ucgenKenari2 = Console.ReadLine();
                        bool ucgenR2 = int.TryParse(ucgenKenari2, out int ucgenKenar2Result);
                        double ucgenAlan = (ucgenKenar1Result * ucgenKenar2Result) / 2;
                        Console.WriteLine("üçgen şeklinizin alan hesaplaması: {0}",ucgenAlan);
                        break;

                        case 3: 
                        Console.WriteLine("lütfen dikdörtgen şeklinize ait kısa kenarın uzunluğu giriniz");
                        var kisaKenar = Console.ReadLine();
                        bool kisaKenarBool = int.TryParse(kisaKenar, out int kisaKenarResult);

                        Console.WriteLine("lütfen dikdörtgen şeklinize ait uzun kenarın uzunluğu giriniz");
                        var uzunKenar = Console.ReadLine();
                        bool uzunKenarBool = int.TryParse(uzunKenar, out int uzunKenarResult);
                        double dikdortgenAlan = kisaKenarResult * uzunKenarResult;
                        Console.WriteLine("dikdörtgen alan hesaplaması: {0}", dikdortgenAlan);
                        
                        break;
                        
                        case 4:
                        double pi = 3.14159;
                        Console.WriteLine("lütfen daire yarıçapını giriniz. (alan hesaplanırken pi 3.14159 4olarak hesaplanacaktır)");
                        var yariCap= Console.ReadLine();
                        bool yariCapBool = double.TryParse(yariCap, out double yariCapResult);
                        double daireAlan = yariCapResult * yariCapResult * pi;
                        Console.WriteLine("daire alan hesaplaması {0}", daireAlan);
                        break;

                        default:
                        break;
                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}