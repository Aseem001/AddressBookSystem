using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static List<Contact> contactList = new List<Contact>();
        /// <summary>
        /// Adds the new contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public void addNewContact(string firstName, string lastName, string address, string city, string state, double zip, double phoneNumber, string email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            contactList.Add(contact);
            Console.WriteLine("Contact " + firstName + " " + lastName + " added successfully");

        }
        /// <summary>
        /// Views the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
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
        /// <summary>
        /// Edits the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public void editContact(string firstName, string lastName)
        {
            foreach (var v in contactList)
            {
                if (firstName == v.firstName && lastName == v.lastName)
                {
                    Console.WriteLine("\nTo edit contact details of " + firstName + " " + lastName + " enter:");
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("1-To update first name\n2-To update last name\n3-To update address\n4-To update city\n5-To update state\n6-To update zip\n7-To update phone number\n8-To update email\n9-To exit edit portal and save updates");
                        int updatePointer = Convert.ToInt32(Console.ReadLine());
                        if (updatePointer == 9)
                        {
                            break;
                        }
                        Console.WriteLine("Enter the new value");
                        var newValue = Console.ReadLine();


                        switch (updatePointer)
                        {
                            case 1:
                                v.firstName = newValue;
                                break;
                            case 2:
                                v.lastName = newValue;
                                break;
                            case 3:
                                v.address = newValue;
                                break;
                            case 4:
                                v.city = newValue;
                                break;
                            case 5:
                                v.state = newValue;
                                break;
                            case 6:
                                v.zip = Convert.ToDouble(newValue);
                                break;
                            case 7:
                                v.phoneNumber = Convert.ToDouble(newValue);
                                break;
                            case 8:
                                v.email = newValue;
                                break;
                            case 9:
                                flag = false;
                                break;
                        }
                    }

                    Console.WriteLine("Contact details updated successfully");
                }
            }
        }
    }
}
