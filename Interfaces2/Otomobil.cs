using System;

namespace Interfaces
{
    abstract class Otomobil{
        public int KacTekerdenOlusur(){
            return 4;
        }
        public virtual Renk StandartRengiNe(){
            return Renk.Beyaz;
        }
        
    }
}