using System;
using System.Collections;

namespace arrayList{
    class Program{
        public static void Main(string[] args){
           Console.Clear();
            try
            {
                //System.Collection namespace
                ArrayList liste = new ArrayList();
                /*
                list.Add("Ayşe");
                list.Add(2);
                list.Add(true);
                list.Add('A');
                
                // içerisinde verilere erişme
                Console.WriteLine(liste[1]);
                foreach (var item in liste)
                {
                    Console.WriteLine(item);
                }
                */
                //AddRange
                Console.WriteLine(("**********AddRange***********"));
                //string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
                List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

                //liste.AddRange(renkler);
                liste.AddRange(sayilar);

                foreach (var item in liste)
                {
                    Console.WriteLine(item);
                }

                //sort
                Console.WriteLine("*****Sort******");
                liste.Sort();

                foreach (var item in liste)
                {
                    Console.WriteLine(item);
                }

                //Binary Search
                Console.WriteLine(("**********Binary Search***********"));
                Console.WriteLine(liste.BinarySearch(9)); //9'un indeksini getirecek.

                //Reverse
                Console.WriteLine(("**********Reverse***********"));
                liste.Reverse();
                foreach (var item in liste)
                {
                    Console.WriteLine(item);
                }

                //Clear
                Console.WriteLine(("**********Clear***********"));
                liste.Clear();
                foreach (var item in liste)
                {
                    Console.WriteLine(item);
                }

            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(ex);
            }
        }
    }
    
}   