using System;

namespace Abstract_Kavrami;
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

        Console.WriteLine("*******************************************************");

        NewFocus newFocus = new NewFocus();
        Console.WriteLine("Marka: "+newFocus.HangiMarkaninAraci() + " /////////// " + "Standart Rengi: "+newFocus.StandartRengiNe() + " /////////// " + "teker sayısı: "+newFocus.KacTekerdenOlusur());

        NewCivic newCivic = new NewCivic();
        Console.WriteLine("Marka: "+newCivic.HangiMarkaninAraci() + " /////////// " + "Standart Rengi: "+newCivic.StandartRengiNe() + " /////////// " + "teker sayısı: "+newCivic.KacTekerdenOlusur());

        NewCorolla newCorolla = new NewCorolla();
        Console.WriteLine("Marka: "+newCorolla.HangiMarkaninAraci() + " ///////////" + "Standart Rengi: "+newCorolla.StandartRengiNe() + " /////////// " + "teker sayısı: "+newCorolla.KacTekerdenOlusur());




    }
}