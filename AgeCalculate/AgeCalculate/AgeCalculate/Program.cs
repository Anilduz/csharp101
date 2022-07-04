using System;

namespace AgeCalculate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("doğum yılınızı giriniz");
            var yearInput = Console.ReadLine();
            int dfYear = 0;
            var userAgeOut = int.TryParse(yearInput, out dfYear);
            string resultText = "";
            CalculateAge(dfYear, ref resultText);
            Console.WriteLine(resultText);
        }

        public static int CalculateAge(int _year, ref string _text)
        {
            var age = DateTime.Now.Year - _year;
            _text = "yaşınız: " + age + "'dir";
            if (age > 100)
            {
                _text = "lütfen doğum yılınızı kontrol edin";
                return age;
            }
            return age;
        }
    }

}

