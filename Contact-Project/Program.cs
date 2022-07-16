using System;

namespace Contact
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*
            https://app.patika.dev/courses/csharp-101/19-proje-1
            Yeni bir console uygulaması açarak telefon rehberi uygulaması yazınız. 
            Uygulamada olması gereken özellikler aşağıdaki gibidir.
            Telefon Numarası Kaydet
            Telefon Numarası Sil
            Telefon Numarası Güncelle
            Rehber Listeleme (A-Z, Z-A seçimli)
            Rehberde Arama
            Açıklama:
            Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz.
            Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.
            */

            Console.Clear();
            Process process1 = new Process();
            string programDevam = "";
            while (programDevam != "exit")
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)  \nProgramdan Çıkış için 'exit' giriniz");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Varolan Numarayı Silmek");
                System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");


                programDevam = Console.ReadLine().ToLower();
                // System.Console.WriteLine("Seçilen Program: " + programDevam);
                switch (programDevam)
                {
                    case "1":
                        process1.SaveNumber();
                        break;
                    case "2":
                        process1.DeleteNumber();
                        break;
                    case "3":
                        process1.UpdateNumber();
                        break;
                    case "4":
                        process1.ListNumbers();
                        break;
                    case "5":
                        process1.SearchNumber();
                        break;
                    case "exit": break;
                    default:
                        System.Console.WriteLine("1-5 arası program seçiniz ya da exit ile çıkınız.");
                        break;
                }
            }
        }
    }
} 
