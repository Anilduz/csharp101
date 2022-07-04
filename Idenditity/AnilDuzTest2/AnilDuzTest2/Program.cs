using System;
using System.Linq;
using AnilTest.Entities;

namespace AnilDuzTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           using (AppDbContext dbContext = new AppDbContext())
            {

                var user = dbContext.User.FirstOrDefault();




                /*  var book = dbContext.User.FirstOrDefault();
                  Console.WriteLine("Kitap ismi " + book.Name);
                  /*Console.WriteLine("UserID: " + data?.Id);
                 Console.WriteLine("UserName: " + data?.UserName);
                 Console.WriteLine("User password: *******");
                 Console.WriteLine("Name: " + data?.Name);
                 Console.WriteLine("Email: " + data?.Email);*/

                Console.WriteLine("Kullanıcı adınızı giriniz");
                var username = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz");
                var pass = Console.ReadLine();

                if (username == user.UserName && pass == user.Password)
                {
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    Console.WriteLine("lütfen bilgilerinizin doğru olduğundan emin olun.");
                }
            }



           




            Console.ReadKey();
        }
    }
}
