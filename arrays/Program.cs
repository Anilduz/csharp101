using System;
namespace arrays{

    class Program{
        public static void Main (string[] args){
            Console.Clear();
            
            string[] colors = new string[5];

            string[] animals = {"kedi", "köpek", "fil", "zürafa"};

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim

            colors[0] = "mavi";
            Console.WriteLine(animals[2]);
            Console.WriteLine(colors[0]);
            Console.WriteLine(dizi[3]);

            // döngüler ve dizi



            foreach (var item in animals)
            {   
                Console.WriteLine(item);
            }
            
            Console.WriteLine("");

            Console.WriteLine("dizinin eleman sayısını gir");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] array1 = new int [uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write("Lütfen {0} sayıyı giriniz.", i+1);
                array1[i] += int.Parse(Console.ReadLine());

            }

            int sum = 0;

            foreach (var sayi in array1)
            {
                sum += sayi;
                
            }
            Console.WriteLine("Ortalama : "+ sum/uzunluk);   
            
            
        }
    }
}