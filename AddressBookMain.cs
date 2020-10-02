using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static List<Contact> contactList = new List<Contact>();
        public void addNewContact(string firstName, string lastName, string address, string city, string state, double zip, double phoneNumber, string email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            contactList.Add(contact);
            Console.WriteLine("Contact " + firstName + " " + lastName + " added successfully");

        }
        public void viewContact(string firstName, string lastName)
        {
            bool flag = true;
            Console.WriteLine("\nDetails of " + firstName + " " + lastName + ":");
            foreach (var v in contactList)
            {
                if (firstName == v.firstName && lastName == v.lastName)
                {
                    Console.WriteLine("FullName: " + v.firstName + " " + v.lastName + "\nAddress: " + v.address + "\nCity: " + v.city + "\nState: " + v.state + "\nZip: " + v.zip + "\nPhoneNumber: " + v.phoneNumber + "\nEmail: " + v.email);
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("Contact not found");
        }
    }
}
