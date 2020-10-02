using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM\n");
            AddressBookMain addressBook1 = new AddressBookMain();
            AddressBookMain addressBook2 = new AddressBookMain();
            AddressBookList addressBookList = new AddressBookList();
            addressBook1.addNewContact("Aseem", "Anand", "NITKKR", "Kurukshetra", "Haryana", 136119, 4272755, "a@abc.com");
            addressBook1.viewContact("Aseem", "Anand");
            addressBook2.addNewContact("Ram", "Kumar", "Chandigarh", "Mohali", "Punjab", 194485, 7684654, "abshs@abc.com");
            addressBook2.viewContact("Ram", "Kumar");
            addressBook2.editContact("Ram", "Kumar");
            addressBook2.viewContact("Ram", "Kumar");
            addressBook2.deleteContact("Ram", "Kumar");
            addressBook2.viewContact("Ram", "Kumar");
            addressBookList.addNewAddressBook("Aseem Anand", addressBook1);
            addressBookList.addNewAddressBook("Ram Kumar", addressBook2);            
            

            Console.ReadKey();
        }
    }
}
