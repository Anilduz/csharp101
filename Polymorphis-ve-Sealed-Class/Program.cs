using System;
using static Inheritance_Kavrami.Bitkiler;
using static Inheritance_Kavrami.Hayvanlar;

namespace Inheritance_Kavrami{
    class Program{
        public static void Main(string[] args){
            Console.Clear();
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("***********");
            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }
}