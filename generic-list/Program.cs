using System;

namespace Generic_List{
    class Program{
        public static void Main(string[] args){
           Console.Clear();
            try
            {
                
                List<int> sayiListesi = new List<int>();

                sayiListesi.Add(23);
                sayiListesi.Add(10);
                sayiListesi.Add(4);
                sayiListesi.Add(5);
                sayiListesi.Add(92);
                sayiListesi.Add(34);
               

               List<string> renkListesi = new List<string>();

               renkListesi.Add("Kırmızı");
               renkListesi.Add("Mavi");
               renkListesi.Add("Turuncu");
               renkListesi.Add("Sarı");
               renkListesi.Add("Yeşil");

               //count

               Console.WriteLine("SAYI LISTESI COUNT : "+sayiListesi.Count);
               Console.WriteLine("RENK LISTESI COUNT : "+renkListesi.Count);


                Console.WriteLine("STANDART FOREACH METOTU");
                foreach (var item in sayiListesi)
                {
                    Console.WriteLine(item);
                }

                foreach (var item2 in renkListesi)
                {
                    Console.WriteLine(item2);
                }

                Console.WriteLine("SHORT FOREACH METOTU");
                sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
                renkListesi.ForEach(renk=> Console.WriteLine(renk));


                //Eleman Çıkarma
                sayiListesi.Remove(4);
                renkListesi.Remove("Yeşil");

                sayiListesi.RemoveAt(0);
                renkListesi.RemoveAt(1);

                sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
                renkListesi.ForEach(renk=> Console.WriteLine(renk));

                //List Search

                if(sayiListesi.Contains(5)){
                    Console.WriteLine("liste içerisinde 5 bulundu");
                }

                //eleman ile indexe erişme
                Console.WriteLine(renkListesi.BinarySearch("Sarı"));

                //herhangi bir diziyi list tipindeki bir listeye çevirme

                string[] hayvanlar = {"kedi", "köpek", "fil", "kuş"};

                List<string> hayvanlarListesi = new List<string>(hayvanlar);

                foreach (var item in hayvanlarListesi)
                {
                    Console.WriteLine(item);
                }

                //listeyi temizleme işlemi (Clear Metot)
                hayvanlarListesi.Clear();


                //liste içerisinde nesne tutmak
                List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

                Kullanıcılar kullanici1 =  new Kullanıcılar();
                kullanici1.Name = "Anıl";
                kullanici1.Surname = "Düz";
                kullanici1.Age = 20; 

                Kullanıcılar kullanici2 =  new Kullanıcılar();
                kullanici1.Name = "Hakan";
                kullanici1.Surname = "Düz";
                kullanici1.Age = 23;

                kullaniciListesi.Add(kullanici1);
                kullaniciListesi.Add(kullanici2);

                List<Kullanıcılar> newList = new List<Kullanıcılar>();
                newList.Add(new Kullanıcılar(){
                    Name = "Onur",
                    Surname = "Düz",
                    Age = 26
                });

                foreach (var kullanici in kullaniciListesi)
                {
                    Console.WriteLine("Name: "+kullanici.Name);
                    Console.WriteLine("Surname: "+kullanici.Surname);
                    Console.WriteLine("Age: "+kullanici.Age);

                }               
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
     public class Kullanıcılar{
        private string name ;
        private string surname;
        private int age;       

        public string Name {get => name; set => name = value;} 
        public string Surname {get => surname; set => surname = value;}          
        public int Age {get => age; set => age = value;}          

    }
}   