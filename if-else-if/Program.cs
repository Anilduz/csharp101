using System;
namespace if_else_if{
    class Program {
        public static void Main (string[] args){
            
            Console.Clear();
            int time = DateTime.Now.Hour;

            if(time >=6 && time < 11){
                Console.WriteLine("günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("iyi günler.");
            }
            else {
                Console.WriteLine("İyi geceler");
            }

            string sonuc = time <=18 ? "iyi günler" : "iyi geceler";

            sonuc = time >= 6 && time<11 ? "günaydın" : time <=18 ? "iyi günler" : "iyi geceler";

            Console.WriteLine(sonuc);
        }
    }
}