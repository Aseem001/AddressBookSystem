using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM\n");
            AddressBookMain addressBook = new AddressBookMain();
            addressBook.addNewContact("Aseem", "Anand", "NITKKR", "Kurukshetra", "Haryana", 136119, 4272755, "a@abc.com");
            addressBook.viewContact("Aseem", "Anand");
            addressBook.addNewContact("Ram", "Kumar", "Chandigarh", "Mohali", "Punjab", 194485, 7684654, "abshs@abc.com");
            addressBook.viewContact("Ram", "Kumar");
            addressBook.addNewContact("Mohan", "Kumar", "Chandigarh", "Mohali", "Punjab", 194485, 7684654, "abshs@abc.com");
            addressBook.viewContact("Mohan", "Kumar");
            //addressBook.editContact("Ram", "Kumar");
            //addressBook.viewContact("Ram", "Kumar");
            //addressBook.deleteContact("Ram", "Kumar");
            //addressBook.viewContact("Ram", "Kumar");

            Console.ReadKey();
        }
    }
}
