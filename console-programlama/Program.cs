// See https://aka.ms/new-console-template for more information
using System;


namespace console_programlama{

class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}
