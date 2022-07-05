using System;
namespace School{


    public class Parent{
        public string Name{get; set;}
        public string Surname{get; set;}
        public string Phone{get; set;}
        
        public Parent(string _name, string _surname, string _phone)
        {
            this.Name= _name;
            this.Surname=_surname;
            this.Phone=_phone;
           
        }
    }
    public class Student{
        public int Id{get; set;}
        public string Name{get; set;}
        public string Surname {get; set;}
        public int Age {get; set;}
        public string Phone{get; set;}
        public string Mail {get; set;}

        public Student(int _id, string _name, string _surname, int _age, string _phone, string _mail){
            this.Id = _id;
            this.Name = _name;
            this.Surname = _surname;
            this.Age=_age;
            this.Phone = _phone;
            this.Mail = _mail;
        }
        
    }
    class Program{
        public static void Main (string[] args){
            Console.Clear();
            Student stu1 = new Student(1,"anıl","düz",20,"05532750043","anil_duz@outlook.com");
            Parent pr1 = new Parent("Onur","Düz","0555 555 55 55");
            Console.WriteLine(stu1.Name);

        }
    }
}