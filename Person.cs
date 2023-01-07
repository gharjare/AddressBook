using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Person
    {
        public static List<Contact> person = new List<Contact>();
        public static void CreateContact()
        {
            Contact conatatct = new Contact();

            Console.WriteLine("Enter first name");
            conatatct.FName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            conatatct.LName = Console.ReadLine();

            Console.WriteLine("Enter address");
            conatatct.Addresss = Console.ReadLine();

            Console.WriteLine("Enter city");
            conatatct.City = Console.ReadLine();

            Console.WriteLine("Enter state");
            conatatct.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode");
            conatatct.Zip = Console.ReadLine();

            Console.WriteLine("Enter phonenumber");
            conatatct.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter email");
            conatatct.Email = Console.ReadLine();
            person.Add(conatatct);
        }
    }
}
