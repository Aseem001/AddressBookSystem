using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");
            AddressBookMain addressBook = new AddressBookMain();
            addressBook.addNewContact("Ram", "Kumar", "Chandigarh", "Mohali", "Punjab", 194485, 7684654, "abshs@abc.com");
            addressBook.viewContact("Ram", "Kumar");
            addressBook.editContact("Ram", "Kumar");
            addressBook.viewContact("Ram", "Kumar");
        }
    }
}
