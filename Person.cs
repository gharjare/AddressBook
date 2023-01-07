using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

    public class Person
    {
        public static List<Contact> person = new List<Contact>();
        Dictionary<string, List<Contact>> book = new Dictionary<string, List<Contact>>();

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
        public static void editContact()
        {
            if (person.Count != 0)
            {
                Console.WriteLine("Enter the contct to edit");
                string Edit = Console.ReadLine();

                foreach (var data in person)
                {
                    if (person.Contains(data))
                    {
                        Console.WriteLine("for edit contact enter 1.FirstName\n 2.LastNamee\n 3.Address\n 4.City\n 5.State\n 6.Zip\n 7.PhoneNumber\n");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                Console.WriteLine("Eneter the First Name");
                                data.FName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the last name");
                                data.LName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the Address");
                                data.Addresss = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the City");
                                data.Addresss = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the State");
                                data.Addresss = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the Zip");
                                data.Addresss = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the PhonenNmber");
                                data.Addresss = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Enter the valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Doest choose valid option");
                    }

                }
            }
        }
        public static void RemoveContact()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string Remove = Console.ReadLine();
            foreach (var data in person.ToList())
            {
                if (data.FName.ToUpper() == Remove.ToUpper())
                {
                    person.Remove(data);
                    Console.WriteLine("Contact is deleted");
                }
                else
                {
                    Console.WriteLine("Contact is not present");
                }
            }

        }
        public static void AddMultipleContact()
        {
            Console.WriteLine("Enter the contact you want to add");
            int contact = Convert.ToInt32(Console.ReadLine());
            while (contact > 0)
            {
                AddMultipleContact();
                contact--;
            }
        }
        public static void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                number--;
                CreateContact();
            }
            book.Add(Bookname,person.ToList());
        }
        public void DisplayList()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contact data in book[pair])
                {
                    Console.WriteLine("First Name: " + data.FName);
                    Console.WriteLine("Last Name: " + data.LName);
                    Console.WriteLine("Address: " + data.Addresss);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State: " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("Phone Number: " + data.PhoneNumber);
                    Console.WriteLine("EmailID: " + data.Email);
                }
            }
        }
    }
}
