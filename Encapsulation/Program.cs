using System;

namespace Encapsulation{
    class Program{
        public static void Main(string[] args){
            Console.Clear();

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = "Anıl";
            ogr1.Soyad = "Düz";
            ogr1.No = 310;
            ogr1.Sinif = 11;
            ogr1.OgrenciBilgileriniGetir();

            ogr1.SinifAtlat();
            ogr1.OgrenciBilgileriniGetir();

            Console.WriteLine();
            Ogrenci og2 = new Ogrenci("Onur", "Düz", 256, 1);
            og2.SinifDusur();
            og2.SinifDusur();
            og2.OgrenciBilgileriniGetir();
            Console.WriteLine();
            
            
        }
    }

    class Ogrenci{
        private string ad;
        private string soyad;
        private int no;
        private int sinif;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int No { get => no; set => no = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("sınıf 1'den düşük olamaz");
                    sinif = 1;
                }
                else
                sinif = value;
            } 
        }

        public Ogrenci(string ad, string soyad, int no, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("*******Ogrenci Bilgileri*********");
            Console.WriteLine("Ogrenci Adı             :{0}", this.Ad);
            Console.WriteLine("Ogrenci Soyad           :{0}", this.Soyad);
            Console.WriteLine("Ogrenci No              :{0}", this.No);
            Console.WriteLine("Ogrenci Sinif           :{0}", this.Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = Sinif +1;
        }
        public void SinifDusur(){
            this.Sinif = Sinif -1; 
        }
    }
}