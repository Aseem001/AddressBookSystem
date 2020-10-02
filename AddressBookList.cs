using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookList
    {        
        public Dictionary<string, AddressBookMain> addressBookListDictionary = new Dictionary<string, AddressBookMain>();
        public void addNewAddressBook(string addressBookName, AddressBookMain addressBook)
        {            
            addressBookListDictionary.Add(addressBookName, addressBook);
            Console.WriteLine("\nAddress Book "+addressBookName+" added successfully");
            foreach(var kvp in addressBookListDictionary)
            {
                Console.WriteLine("Updated Address Book List:\nKey: {0}, Value: {1}",kvp.Key,kvp.Value);
            }
        }
    }
}