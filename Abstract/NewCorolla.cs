using System;
namespace Abstract_Kavrami{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}