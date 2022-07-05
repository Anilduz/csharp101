using System;
namespace Error_Managament{

    class Program{
        public static void Main (string[] args)
        {
            Console.Clear();
            try
            {
            Console.WriteLine("a'yı girin");
            var a = Console.ReadLine();
            int aResult=0;
            var aOut = int.TryParse(a, out aResult);
            Console.WriteLine("girmiş olduğunuz sayı: " +aOut+" "+aResult);
            
            Console.WriteLine("b'yi girin");
            var b = Console.ReadLine();
            int bResult=0;
            var bOut = int.TryParse(b, out bResult);
            Console.WriteLine("girmiş olduğunuz sayı: "+ bOut+" "+bResult);
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata mesajınız: "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("işlem gerçekleştirildi");
            }


            try
            {
                int a = int.Parse("-20000000000000");
                //int a = int.Parse("anil232");
                //int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz.");
                Console.WriteLine(ex.Message.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("girdiğiniz değer belirtilen tipte değil.");
                Console.WriteLine(ex.Message.ToString());
            }
            catch(OverflowException ex){
                Console.WriteLine("çok büyük yada çok küçük değer girdiniz");
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}