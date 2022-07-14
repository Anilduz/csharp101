using System;
namespace Inheritance_Kavrami{
   public class Hayvanlar : Canlilar
   {
        protected void Adaptasyon()
        {
            Console.WriteLine("hayvanlar adaptasyon kurabilir.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa cevap verir.");
        }
        public class Surungenler : Hayvanlar
        {
            public Surungenler(){
                base.Adaptasyon();
                base.Beslenme();
                base.Bosaltim();
                base.Solunum();
                base.UyaranlaraTepki();
            }
            public void SurungenHaraketEdenler()
            {
                Console.WriteLine("Sürüngenler sürünerek haraket ederler");
            }
        }
        public class Kuslar : Hayvanlar
        {
            public Kuslar(){
                base.Adaptasyon();
                base.Beslenme();
                base.Bosaltim();
                base.Solunum();
                base.UyaranlaraTepki();
            }
               public void Ucmak()
            {
                Console.WriteLine("Kuşlar uçar");
            }
        }
   }
}