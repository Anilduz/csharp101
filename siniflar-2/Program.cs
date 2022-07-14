using System;

namespace sinif_kavrami_2{
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
            Calisan calisan1 = new Calisan("Anıl","Düz", 455840504, "Yazılım Geliştirme Departmanı.");
            calisan1.CalisanBilgileri();

            Console.WriteLine();
            Console.WriteLine("2. Çalışan-------------------------------");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Arda";
            calisan2.Soyad = "Kural";
            calisan2.No = 123255;
            calisan2.Departman = "İnsan Kaynakları ve İlişki Geliştirme Departmanı.";
            calisan2.CalisanBilgileri();

            Console.WriteLine("3. Çalışan-------------------------------");
            Calisan calisan3 = new Calisan("Onur","Düz");
            calisan3.CalisanBilgileri();

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

        public Calisan(string _ad, string _soyad){
            this.Ad = _ad;
            this.Soyad = _soyad;
           
        }
        public Calisan(){}

        public Calisan(string _ad, string _soyad, int _no, string _departman){
            this.Ad = _ad;
            this.Soyad = _soyad;
            this.No = _no;
            this.Departman = _departman;
        }

    }
}