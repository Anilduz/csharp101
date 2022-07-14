using System;
namespace Inheritance_Kavrami{
   public class Bitkiler : Canlilar
   {
        protected void Fotosentez(){
            Console.WriteLine("bitkiler fotosentez yaparlar");
        }
        public override void UyaranlaraTepki()
        {
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
        public class TohumluBitkiler : Bitkiler{
            public TohumluBitkiler(){
                base.Fotosentez();
                base.Beslenme();
                base.Bosaltim();
                base.Solunum();
                base.UyaranlaraTepki();
                
            }
            public void TohumlaCogalma()
            {
                Console.WriteLine("Tohumlu Bitkiler tohumla çoğalır");
            }
        }
        public class TohumsuzBitkiler : Bitkiler{
             public TohumsuzBitkiler(){
                base.Fotosentez();
                base.Beslenme();
                base.Bosaltim();
                base.Solunum();
                
            }
            public void SporlaCogalma()
            {
                Console.WriteLine("Tohumsuz Bitkiler sporla çoğalır");
            }
        }
   }
}