using System;

namespace Math_Library{
    class Program{
        public static void Main(string[] args){
           Console.Clear();
            try
            {
                Console.Clear();
                Console.WriteLine("**********DateTime Library**********");
                Console.WriteLine("Now : "+DateTime.Now);
                Console.WriteLine("Date : "+DateTime.Now.Date);
                Console.WriteLine("Day : "+DateTime.Now.Day);
                Console.WriteLine("Month : "+DateTime.Now.Month);
                Console.WriteLine("Year : "+DateTime.Now.Year);
                Console.WriteLine("Hour : "+DateTime.Now.Hour);
                Console.WriteLine("Minute : "+DateTime.Now.Minute);
                Console.WriteLine("Second : "+DateTime.Now.Second);
                Console.WriteLine("DayOfWeek : "+DateTime.Now.DayOfWeek);
                Console.WriteLine("DayOfYear : "+DateTime.Now.DayOfYear);
                Console.WriteLine("ToLongDateString : "+ DateTime.Now.ToLongDateString());
                Console.WriteLine("ToShortDateString : "+ DateTime.Now.ToShortDateString());
                Console.WriteLine("ToLongTimeString : "+ DateTime.Now.ToLongTimeString());
                Console.WriteLine("ToShortTimeString : "+ DateTime.Now.ToShortTimeString());
                Console.WriteLine("AddDays : "+ DateTime.Now.AddDays(2));
                Console.WriteLine("AddHours : "+ DateTime.Now.AddHours(3));
                Console.WriteLine("AddSeconds : "+ DateTime.Now.AddSeconds(30));
                Console.WriteLine("AddMonths : "+ DateTime.Now.AddMonths(5));
                Console.WriteLine("AddYears : "+ DateTime.Now.AddYears(10));
                Console.WriteLine("AddMilliseconds : "+ DateTime.Now.AddMilliseconds(50));
                Console.WriteLine("dd : "+ DateTime.Now.ToString("dd"));
                Console.WriteLine("ddd : "+ DateTime.Now.ToString("ddd"));
                Console.WriteLine("dddd : "+ DateTime.Now.ToString("dddd"));
                Console.WriteLine("MM : "+ DateTime.Now.ToString("MM"));
                Console.WriteLine("MMM : "+ DateTime.Now.ToString("MMM"));
                Console.WriteLine("MMMM : "+ DateTime.Now.ToString("MMMM"));
                Console.WriteLine("yy : "+ DateTime.Now.ToString("yy"));
                Console.WriteLine("yyyy : "+ DateTime.Now.ToString("yyyy"));
                Console.WriteLine("**********Math Library**********");
                Console.WriteLine("abs : "+Math.Abs(-25)); //mutlak değer
                Console.WriteLine("sin : "+Math.Sin(10)); //sinüs değeri karşılığı
                Console.WriteLine("Cos : "+Math.Cos(10)); //cos değeri karşılığı
                Console.WriteLine("Tan : "+Math.Tan(10)); //tan değeri karşılığı
                Console.WriteLine("Ceiling : "+Math.Ceiling(22.3)); //sayıdan büyük en yakın tam sayı değeri karşılığı,23
                Console.WriteLine("Round : "+Math.Round(22.3)); //en yakın hangi tam sayı varsa o değerin karşılığı 22
                Console.WriteLine("Floor : "+Math.Round(22.7)); //en yakın hangi tam sayı varsa o değerin karşılığı 23
                Console.WriteLine("Floor : "+Math.Floor(22.7)); // en yakın bir küçük tam sayı 22 aşağı yuvarlama
                Console.WriteLine("Max : "+Math.Max(2,6)); //max olan sayıyı döner.
                Console.WriteLine("Min : "+Math.Min(2,6)); //min olan sayıyı döner.
                Console.WriteLine("Pow : "+Math.Pow(3,4)); // üç üssü dörtün karşılığını getirir.
                Console.WriteLine("Sqrt : "+Math.Sqrt(9)); //karakök
                Console.WriteLine("Log : "+Math.Log(9)); //9'un e tabanındaki karşılığını getirir
                Console.WriteLine("Exp : "+Math.Exp(3)); //e üzeri 3'ün karşılığını getirir
                Console.WriteLine("Log10 : "+Math.Log10(10)); //10 sayısının log 10 tabanındaki karşılığını getirir


                




            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
}