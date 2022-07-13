using System;

namespace sinif_kavrami{
    class Program{
        public static void Main(string[] args){
            /*
            söz dizimi
            class SinifAdi
            {
                [erişim belirleyici] [veri tipi] OzellikAdi(Parametre Listesi)
                {
                    Metot komutları
                }
            }
            */

            //erişim belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected //sadece kalıtımların yararlanabildiği alanlar için kullanılır
            Console.Clear();
            Console.WriteLine("1. Çalışan-------------------------------");
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Anıl";
            calisan1.Soyad = "Düz";
            calisan1.No = 455840504;
            calisan1.Departman = "Yazılım Geliştirme Departmanı.";
            calisan1.CalisanBilgileri();
            Console.WriteLine();
            Console.WriteLine("2. Çalışan-------------------------------");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Arda";
            calisan2.Soyad = "Kural";
            calisan2.No = 123255;
            calisan2.Departman = "İnsan Kaynakları ve İlişki Geliştirme Departmanı.";
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){ 
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }

    }
}