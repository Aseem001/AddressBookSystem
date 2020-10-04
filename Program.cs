using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {            
            AddressBookList addressBookList = new AddressBookList();            
            Console.WriteLine("WELCOME TO ADDRESS BOOK PROGRAM\n");

            bool flag1 = true;            
            while(flag1)
            {
                string currentAddressBookName = "";
                Console.WriteLine("\nEnter:\n1-To add a new address Book\n2-To access an existing address book\n3-To exit");
                int options1 = Convert.ToInt32(Console.ReadLine());
                switch(options1)
                {
                    case 1:
                        addressBookList.addNewAddressBook();
                        break;
                    case 2:
                        currentAddressBookName = addressBookList.existingAddressBook();
                        break;
                    case 3:
                        flag1 = false;
                        break;
                }
                if(currentAddressBookName!="")
                {
                    bool flag2 = true;
                    while (flag2)
                    {
                        Console.WriteLine("Current address book:" + currentAddressBookName);
                        Console.WriteLine("Enter:\n1-To add a new contact\n2-To edit an existing contact\n3-To view an existing contact\n4-To delete a contact\n5-To return to main menu");
                        int options2 = Convert.ToInt32(Console.ReadLine());
                        switch (options2)
                        {
                            case 1:
                                addressBookList.addressBookListDictionary[currentAddressBookName].addNewContact();
                                break;
                            case 2:
                                addressBookList.addressBookListDictionary[currentAddressBookName].editContact();
                                break;
                            case 3:
                                addressBookList.addressBookListDictionary[currentAddressBookName].viewContact();
                                break;
                            case 4:
                                addressBookList.addressBookListDictionary[currentAddressBookName].deleteContact();
                                break;
                            case 5:
                                flag2 = false;
                                break;
                        }
                    }                 
                }                
            }                                     
        }
    }
}
