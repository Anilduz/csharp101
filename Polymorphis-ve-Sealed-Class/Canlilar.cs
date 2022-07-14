using System;
namespace Inheritance_Kavrami{
   public /*sealed*/ class Canlilar{

    //sealed anahtar kelimesi class'ın kalıtım vermesini engeller.
    protected void Beslenme(){
        Console.WriteLine("canlılar beslenir");
    }
    protected void Solunum(){
        Console.WriteLine("canlılar solunum yaparlar");
    }
    protected void Bosaltim(){
        Console.WriteLine("canlılar boşaltım yaparlar");
    }

    public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlılar uyaranlara tepki verir.");    
    }
   }
}