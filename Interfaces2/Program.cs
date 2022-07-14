using System;

namespace Interfaces;
class Program{
    public static void Main(string[] args)
    {
        Console.Clear();
     
        Focus focus = new Focus();
        Console.WriteLine("Marka: "+focus.HangiMarkaninAraci() + " /////////// " + "Standart Rengi: "+focus.StandartRengiNe() + " /////////// " + "teker sayısı: "+focus.KacTekerdenOlusur());

        Civic civic = new Civic();
        Console.WriteLine("Marka: "+civic.HangiMarkaninAraci() + " /////////// " + "Standart Rengi: "+civic.StandartRengiNe() + " /////////// " + "teker sayısı: "+civic.KacTekerdenOlusur());

        Corolla corolla = new Corolla();
        Console.WriteLine("Marka: "+corolla.HangiMarkaninAraci() + " ///////////" + "Standart Rengi: "+corolla.StandartRengiNe() + " /////////// " + "teker sayısı: "+corolla.KacTekerdenOlusur());




    }
}