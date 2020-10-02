using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookList
    {
        private readonly NLog nLog = new NLog();
        public Dictionary<string, AddressBookMain> addressBookListDictionary = new Dictionary<string, AddressBookMain>();
        public void addNewAddressBook(string addressBookName, AddressBookMain addressBook)
        {            
            addressBookListDictionary.Add(addressBookName, addressBook);
            Console.WriteLine("\nAddress Book "+addressBookName+" added successfully");
            foreach(var kvp in addressBookListDictionary)
            {
                Console.WriteLine("Updated Address Book List:\nKey: {0}, Value: {1}",kvp.Key,kvp.Value);                
                //Log record with every new address book addition to the system
                nLog.LogInfo("addNewAddressBook()) passed: to add new address book with name : " +kvp.Key );
            }
            //Debug message to show method got debugged successfully
            nLog.LogDebug("Debug Successful : addNewAddressBook()");

        }
    }
}