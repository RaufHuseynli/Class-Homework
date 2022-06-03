using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._Inheritance_Homework
{
    class Person

    {
        public Person()
        {
            this.Adress = new List<string>();
            this.Contact = new List<string>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Adress { get; set; }
        public List<string> Contact { get; set; }
        public string FatherName { get; set; }
        public void ChangePassword(string new_password) {
        }
        public void AddPhones(string new_PhoneNumber) {
        }
        public void AddAddress(string new_addres)
        {
            this.Adress.Add(new_addres);
        }
        public void HumanInformation()
        {

        }
    }
}
