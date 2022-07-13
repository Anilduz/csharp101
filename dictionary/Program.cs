using System;

namespace Dictionary{
    class Program{
        public static void Main(string[] args){
           Console.Clear();
            try
            {
                //system.collection.generic
                Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
                kullanicilar.Add(10,"Anıl Düz");
                kullanicilar.Add(12, "Ahmet Yılmaz");
                kullanicilar.Add(18, "Deniz Arda");
                kullanicilar.Add(20, "Özcan Deniz");
                
                //dizinin elemanlarına erişim
                Console.WriteLine("******Dizinin elemanına erişim******");
                Console.WriteLine(kullanicilar[12]); 
                foreach (var item in kullanicilar)
                Console.WriteLine(item);
                    
                //count
                Console.WriteLine("******Count******");
                Console.WriteLine(kullanicilar.Count);

                //contains
                Console.WriteLine("******Contains******");
                Console.WriteLine(kullanicilar.ContainsKey(12));
                Console.WriteLine(kullanicilar.ContainsValue("Anıl Düsz"));
                
                //Remove
                Console.WriteLine("******Remove******");
                kullanicilar.Remove(12);

                foreach (var item in kullanicilar)
                {
                    //Console.WriteLine(item.Value);
                    //Console.WriteLine(item.Key);
                    Console.WriteLine(item);
                }

                //Keys
                Console.WriteLine("******Keys******");
                foreach (var item in kullanicilar.Keys)
                {
                    Console.WriteLine(item);
                }

                //Values
                Console.WriteLine("******Values******");
                foreach (var item in kullanicilar.Values)
                {
                    Console.WriteLine(item);
                }        
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
    
}   