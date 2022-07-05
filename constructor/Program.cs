using System;

namespace LearnConstructor{

    class Car{
        public int Id{get; set;}
        public int ModelYear{ get; set;}
        public string Brand {get; set;}
        public int SalePrice{get; set;}
        public string Currency{get; set;}
        public string ProductionPlace{get; set;}


        public Car(int _id, int _modelYear, string _brand, int _salePrice, string _currency ,string _productionPlace){
            this.Id= _id;
            this.ModelYear = _modelYear;
            this.Brand= _brand;
            this.SalePrice = _salePrice;
            this.Currency = _currency;
            this.ProductionPlace = _productionPlace;
        } 
    }
    class Program{
        public static void Main(string[] args){
            Console.Clear();
            Car fiesta = new Car(1, 2002, "ford", 13000, "TRY", "TR");
            Car mustang = new Car(2, 2015, "ford", 15000,"USD","USA");
            
            Console.WriteLine(fiesta.Id +" "+ fiesta.ModelYear +" "+ fiesta.Brand +" "+fiesta.SalePrice + fiesta.Currency+" Üretim Yeri:"+fiesta.ProductionPlace);
            Console.WriteLine(mustang.Id +" "+ mustang.ModelYear +" "+ mustang.Brand +" "+mustang.SalePrice + mustang.Currency+" Üretim Yeri:"+mustang.ProductionPlace);

        }
    }
}