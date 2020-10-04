using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookList
    {
        private readonly NLog nLog = new NLog();
        public Dictionary<string, AddressBookMain> addressBookListDictionary = new Dictionary<string, AddressBookMain>();
        public void addNewAddressBook()
        {            
            Console.WriteLine("Enter the name of address book:");
            string addressBookName = Console.ReadLine();           
            AddressBookMain addressBook = new AddressBookMain(addressBookName);
            addressBookListDictionary.Add(addressBookName, addressBook);  
            Console.WriteLine("\nAddress Book "+addressBookName+" added successfully");
            Console.WriteLine("Updated Address Book List:");
            foreach (var kvp in addressBookListDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}",kvp.Key,kvp.Value);          
                //Log record with every new address book addition to the system
                nLog.LogInfo("addNewAddressBook()) passed: to add new address book with name : " +kvp.Key );
                //Console.WriteLine(addressBookListDictionary.ElementAt[0].viewContact());
            }
            //Console.WriteLine(addressBookListDictionary["addressBookName"].Convert.toBool(viewContact("Ram", "Kumar")));
            //Debug message to show method got debugged successfully
            nLog.LogDebug("Debug Successful : addNewAddressBook()");

        }
        public string existingAddressBook()
        {
            Console.WriteLine("Enter the Address Book name");
            string addressBookName = Console.ReadLine();
            string result ="";
            bool flag = true;
            foreach(var kvp in addressBookListDictionary)
            {
                if (kvp.Key == addressBookName)
                {
                    result= addressBookName;
                    flag = false;
                    break;
                }                
            }
            if(flag==true)
            {
                Console.WriteLine("No Address Book with name "+addressBookName+" found\nPlease create a new address book");                
            }
            return result;
        }
    }
}