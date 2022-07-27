using System;

namespace string_tersten_yazdirma{
    class Program{
        public static void Main(string[] args){
        Console.Clear();
        
         while(true){
            Console.WriteLine();
            try
            {   
                Console.WriteLine("tersten yazılmasını istediğiniz ifadeyi giriniz");
                string text = Console.ReadLine();
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }
                
            } 
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
         }
        }
    }
}