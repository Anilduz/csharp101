using System;
namespace Contact{
    public class Process{
        List<Person>rehber = new List<Person>();
         public Process(){
           rehber.Add(new Person("Acil","Yardım","112"));
           rehber.Add(new Person("Yangın","Yardım","110"));
           rehber.Add(new Person("Polis","Yardım","155"));
           rehber.Add(new Person("Hastane","Randevu","182"));
           rehber.Add(new Person("Belediye","İLetişim","153"));
       }

        public void SaveNumber()
        {
            Console.Clear();
            Person person1 = new Person();
            int func1 = 2;
            while(func1 == 2)
            {
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("Lütfen isim giriniz              : ");
                person1.Name = Console.ReadLine();
                System.Console.WriteLine("Lütfen soyisim giriniz           : ");
                person1.Surname = Console.ReadLine();
                System.Console.WriteLine("Lütfen telefon numarası giriniz  : ");
                person1.Number = Console.ReadLine();

                rehber.Add(person1);
                Console.WriteLine("kişi rehbere eklendi");
                System.Console.WriteLine("Eklenen son kart bilgisi");
                System.Console.WriteLine(rehber[rehber.Count - 1].Name);
                System.Console.WriteLine(rehber[rehber.Count - 1].Surname);
                System.Console.WriteLine(rehber[rehber.Count - 1].Number);

                Console.WriteLine("devam etmek istiyorsanız 2, etmek istemiyorsanız 1'i tuşlayın");
                var devam = Console.ReadLine();
                bool devamMi = int.TryParse(devam, out int tekrar);
                tekrar = func1;
                

            }
        }
        public void DeleteNumber()
        {
            Console.Clear();
            
            string nameOrSurname;
            int silmeyeDevam = 2;
            while (silmeyeDevam == 2)
            {

                Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

                nameOrSurname = Console.ReadLine();

                foreach (var item in rehber)
                {
                    if ((rehber.IndexOf(item) == rehber.Count - 1) &&
                    !(nameOrSurname.ToLower() == item.Name.ToLower() ||
                    nameOrSurname.ToLower() == item.Surname.ToLower()))
                    {

                        Console.WriteLine("Aradığınız krtiterlere uygun veri bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)"); 
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        silmeyeDevam = Convert.ToInt32(Console.ReadLine());


                    }
                    else if (nameOrSurname.ToLower() == item.Name.ToLower() ||
                    nameOrSurname.ToLower() == item.Surname.ToLower())
                    {

                        Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Number + " kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Number + " kişi silindi");
                            rehber.RemoveAt(rehber.IndexOf(item));
                            Console.WriteLine();
                            silmeyeDevam = 1;

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        public void UpdateNumber()
        {
           
            Console.WriteLine("3. Program Seçildi Güncelleme");
            string nameOrSurname;
            int guncellemeyeDevam = 2;
            while (guncellemeyeDevam == 2)
            {

                System.Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");

                nameOrSurname = Console.ReadLine();

                foreach (var item in rehber)
                {
                    if ((rehber.IndexOf(item) == rehber.Count - 1) &&
                    !(nameOrSurname.ToLower() == item.Name.ToLower() ||
                    nameOrSurname.ToLower() == item.Surname.ToLower()))
                    {

                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");

                        System.Console.WriteLine("* Yeniden denemek için      : (2)");
                        guncellemeyeDevam = Convert.ToInt32(Console.ReadLine());


                    }
                    else if (nameOrSurname.ToLower() == item.Name.ToLower() ||
                    nameOrSurname.ToLower() == item.Surname.ToLower())
                    {

                        System.Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Number + " kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            Console.WriteLine("Lütfen güncel isim giriniz              : ");
                            item.Name = Console.ReadLine();
                            Console.WriteLine("Lütfen güncel soyisim giriniz           : ");
                            item.Surname = Console.ReadLine();
                            Console.WriteLine("Lütfen güncel telefon numarası giriniz  : ");
                            item.Number = Console.ReadLine();
                            Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Number + " kişi olarak güncellendi");
                            Console.WriteLine();
                            guncellemeyeDevam = 1;

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        public void ListNumbers()
        {
             Console.Clear();
            foreach(var item in rehber){
               
                Console.WriteLine(" İsmi : {0}", item.Name);
                Console.WriteLine(" Soyismi : {0}", item.Surname);
                Console.WriteLine(" Numarası : {0}", item.Number);

                Console.WriteLine("------------------------------------");

            }
        }
        public void SearchNumber()
        {
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");
            System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.:");
            System.Console.WriteLine(" ***************************************");
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int callType = Convert.ToInt32(Console.ReadLine());
            if (callType == 1)
            {
                System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için isim ya da soyisim giriniz");

                string nameOrSurname = Console.ReadLine();

                foreach (var item in rehber)
                {
                    if ((rehber.IndexOf(item) == rehber.Count - 1) &&
                    !(nameOrSurname.ToLower() == item.Name.ToLower() ||
                    nameOrSurname.ToLower() == item.Surname.ToLower()))
                    {

                        if (!rehber.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");
                    }
                    else if (nameOrSurname.ToLower() == item.Name.ToLower() ||
                    nameOrSurname.ToLower() == item.Surname.ToLower())
                    {

                        System.Console.WriteLine("İsim: " + item.Name + "\n Soyisim: " + item.Surname + "\n Telefon Numarası: " + item.Number);

                    }


                }
            }
            else if (callType == 2)
            {
                System.Console.WriteLine(" Telefon numarasına göre arama yapmak için telefon numarasını giriniz");

                string telefonNumarasi = Console.ReadLine();

                foreach (var item in rehber)
                {
                    if ((rehber.IndexOf(item) == rehber.Count - 1) &&
                    !(telefonNumarasi.ToLower() == item.Number.ToLower()))
                    {
                        if (!rehber.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");

                    }
                    else if (telefonNumarasi.ToLower() == item.Number.ToLower())
                    {

                        System.Console.WriteLine("İsim: " + item.Name + "\n Soyisim: " + item.Number + "\n Telefon Numarası: " + item.Number);                        
                


                    }

                }
            }
        }
    }
}