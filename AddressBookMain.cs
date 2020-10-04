using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        private readonly NLog nLog = new NLog();
        public List<Contact> contactList = new List<Contact>();
        string addressBookName;

        public AddressBookMain(string addressBookName)
        {
            this.addressBookName = addressBookName;
        }
       
        public void addNewContact()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city name");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zip");
            double zip = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter phone number");
            double phoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            contactList.Add(contact);
            Console.WriteLine("Contact " + firstName + " " + lastName + " added successfully");

        }
        
        public void viewContact()
        {
            bool flag = true;
            Console.WriteLine("Enter the first name of contact you want to view");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of contact you want to view");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nDetails of " + firstName + " " + lastName + ":");
            foreach (var v in contactList)
            {
                if (firstName == v.firstName && lastName == v.lastName)
                {
                    Console.WriteLine("FullName: " + v.firstName + " " + v.lastName + "\nAddress: " + v.address + "\nCity: " + v.city + "\nState: " + v.state + "\nZip: " + v.zip + "\nPhoneNumber: " + v.phoneNumber + "\nEmail: " + v.email+"\n");
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Contact not found");
                //Log Warning to enter already existing contact
                nLog.LogWarning("Warning: To view the contact it must already exist");
                //Log Error to show that entered contact does not exist
                nLog.LogError("Error: Contact does not exist");
                
            }
                
        }
       
        public void editContact()
        {
            bool flag1 = true;
            Console.WriteLine("Enter first name of the contact to edit");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            foreach (var v in contactList)
            {
                if (firstName == v.firstName && lastName == v.lastName)
                {
                    Console.WriteLine("\nTo edit contact details of " + firstName + " " + lastName + " enter:");
                    bool flag2 = true;
                    while (flag2)
                    {
                        Console.WriteLine("1-To update first name\n2-To update last name\n3-To update address\n4-To update city\n5-To update state\n6-To update zip\n7-To update phone number\n8-To update email\n9-To exit edit portal and save updates");
                        int updatePointer = Convert.ToInt32(Console.ReadLine());
                        if (updatePointer == 9)
                        {
                            //Log record if no edits or updates are done
                            nLog.LogInfo("INFO: editContact() passed but no change noticed : " + firstName + " " + lastName);                            
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
                                flag2 = false;
                                break;
                        }
                        Console.WriteLine("Contact details updated successfully");
                        flag1 = false;
                    }
                    
                }
            }
            if(flag1==true)
                Console.WriteLine("Error:Contact not found");

        }
        
        public void deleteContact()
        {
            bool flag = true;
            Console.WriteLine("Enter the first name of contact you want to delete");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of contact you want to delete");
            string lastName = Console.ReadLine();
            for (int i = 0; i < contactList.Count; i++)
            {
                if (firstName == contactList[i].firstName && lastName == contactList[i].lastName)
                {
                    contactList.RemoveAt(i);
                    //Log record to show that the contact is deleted
                    nLog.LogInfo("deleteContact() passed: to delete : " + firstName+" "+lastName);
                    Console.WriteLine("\nContact {0} {1} deleted successfully", firstName, lastName);
                    flag = false;
                }
            }
            if(flag==true)
                Console.WriteLine("Error:Contact not found");
        }
    }
}
