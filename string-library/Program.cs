using System;

namespace String_Library{
    class Program{
        public static void Main(string[] args){
           Console.Clear();
            try
            {
               
                string text1= "dersimiz CSharp'a Anıl ile, Hoşgeldiniz!";
                string text2= "dersimiz";

                //length
                Console.WriteLine(text1.Length);

                //ToUpper and ToLower
                Console.WriteLine(text1.ToUpper());
                Console.WriteLine(text1.ToLower());
 
                //concat
                Console.WriteLine(string.Concat(text1, "merhaba anıl"));

                //Compare, CompareTo                            //0,1, -1
                Console.WriteLine(text1.CompareTo(text2));
                Console.WriteLine(string.Compare(text1, text2, true));
                Console.WriteLine(string.Compare(text1, text2, false));

                //Contains
                Console.WriteLine(text1.Contains(text2));
                Console.WriteLine(text1.EndsWith("Hoşgeldiniz!"));
                Console.WriteLine(text1.StartsWith("Merhaba!"));

                //IndexOf
                Console.WriteLine(text1.IndexOf("CS"));
                Console.WriteLine(text1.IndexOf("Anıl"));

                //Insert
                Console.WriteLine(text1.Insert(0, "Merhaba Anıl Düz bu bir insert işlemidir. "));
                Console.WriteLine(text1.LastIndexOf("i"));

                //PadLeft, PadRight;
                Console.WriteLine(text1 + text2.PadLeft(30));
                Console.WriteLine(text1 + text2.PadLeft(30, '?'));
                Console.WriteLine(text1.PadRight(50) + text2);
                Console.WriteLine(text1.PadRight(50, '-') + text2);

                //Remove
                Console.WriteLine(text1.Remove(10));
                Console.WriteLine(text1.Remove(5,3));
                Console.WriteLine(text1.Remove(0,1));

                //Replace
                Console.WriteLine(text1.Replace("CSharp", "C#"));
                Console.WriteLine(text1.Replace(" ", "*"));

                //Split
                Console.WriteLine(text1.Split(' ')[1]);

                //Substring
                Console.WriteLine(text1.Substring(4));
                Console.WriteLine(text1.Substring(4,6));



            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
}