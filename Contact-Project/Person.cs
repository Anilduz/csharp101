using System;
namespace Contact{
    public class Person{
        string name;
        string surname;
        string number;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Number { get => number; set => number = value; }

        public Person(string _name, string _surname, string _number)
        {
            Name = _name;
            Surname = _surname;
            Number = _number;
        }
        public Person(){

        }
    }
}