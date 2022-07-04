
using System;

namespace HesapCalculator{

public class Program{
    public static void Main(string[] args){
	
   Console.WriteLine("mealcost");
        double meal_cost = 100;
        Console.WriteLine("tip");
        double tip_percent = 15;
        Console.WriteLine("tax");
        double tax_percent = 8;

        double solved = 0;
        solve(meal_cost,tip_percent,tax_percent, ref solved);
        Console.WriteLine(solved);

    }
      public static void solve(double meal_cost, double tip_percent, double tax_percent, ref double _result)
    {
      double tip = meal_cost * tip_percent / 100;
      double tax = meal_cost * tax_percent / 100;
      double total = meal_cost + tip + tax;
	_result = total;
        
    }
}
}