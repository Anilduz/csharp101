using System;

namespace arrays_2{
    class Program {
        public static void Main(string[] args){
            Console.Clear();
            Console.Clear();

            //sort
            int[] dizi1 = {23,12,4,86,72,3,11,17};

            Console.WriteLine("*********** sırasız array");
            foreach (var item1 in dizi1)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine("*********** sıralı array");
            Array.Sort(dizi1);
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);

            }

            //array clear
            Console.WriteLine("*********** array clear");
            Array.Clear(dizi1,2,2);
            foreach (var item3 in dizi1)
            {
                Console.WriteLine(item3);
            }

            //reverse
            Console.WriteLine("*********** array reverse");

            Array.Reverse(dizi1);

             foreach (var item4 in dizi1)
            {
                Console.WriteLine(item4);
            }

            //index of
            Console.WriteLine("*********** array indexof");

            int b = Array.IndexOf(dizi1,23);

            Console.WriteLine(b);

            //resize
            Console.WriteLine("*********** array resize");
            Array.Resize<int>(ref dizi1,15);

            dizi1[8] = 99;
            foreach (var item5 in dizi1)
            {
                Console.WriteLine(item5);
            }


        }
    }
}