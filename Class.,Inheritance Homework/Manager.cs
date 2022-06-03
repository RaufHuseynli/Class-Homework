using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._Inheritance_Homework
{
    class Manager
    {
       public void PersonManager()
        {
            Person p1 = new Person();
            Console.WriteLine("Musterinin adini daxil edin:");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Musterinin soyadin daxil edin:");
            p1.Surname = Console.ReadLine();
            Console.WriteLine("Ata adini daxil edin:");
            p1.FatherName = Console.ReadLine();
            Console.WriteLine("Musterinin cinsiyyetini daxil edin (male/female) : ");
            p1.Gender = Console.ReadLine();


            Console.WriteLine("Musterinin email giriniz : ");
            p1.Email = Console.ReadLine();

            Console.WriteLine("Musterinin password giriniz: ");
            p1.Password = Console.ReadLine();

            Console.WriteLine("Musterinin telefonunu daxil edin : ");
            string response = string.Empty;
            do
            {
                string telefon = Console.ReadLine();
                p1.AddPhones(telefon);
                Console.WriteLine("Yeni telefon nomresi varmi (he/yox) : ");
                response = Console.ReadLine();

            } while (response == "he");

            Console.WriteLine("Musterinin addresini daxil edin : ");
            string responseAdress = Console.ReadLine();
            do
            {
                string Address = Console.ReadLine();
                p1.AddAddress(Address);
                Console.WriteLine("Yeni address varmi (he/yox) : ");
                responseAdress = Console.ReadLine();


            } while (responseAdress == "he");

            p1.HumanInformation();






        }
    }
}
