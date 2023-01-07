using AddressBook;

namespace Addressbook
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");
            Person.CreateContact();
            Person.editContact();
            Person.RemoveContact();
            Person.NewPerson();
            Person.PrintList();
            Person.AddMultipleContact();
            Person.CheckDuplicate();
            
        }
    }
}
