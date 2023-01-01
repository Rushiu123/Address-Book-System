namespace AdressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================\nWelcome" +
                "To Address Book System\n=============================== ");
            Console.WriteLine("\n1. Create Contact\n");
            Console.WriteLine("\n2. Add New Contact.\n3.Edit Contact.\n4.Delete Contact.\n5.Add Mualtiple Contact\n6.Multiple Address Book \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                //UC1 - Create Contact
                case 1:
                    addressBook.CreateContacts();

                case 1:
                    addressBook.CreateContacts();
                    break;
                //UC2 - Add Contact and Display
                case 2:
                    addressBook.DisplayContact();
                    break;
                //UC3 - Exit Existing Contact
                case 3:
                    addressBook.EditContact();
                    break;
                case 4:
                    //Uc4- Delete Contact
                    addressBook.DeleteContact();
                    break;
                case 5:
                    //Uc6- Add Address Book
                    addressBook.AddNewAddressBook();
                    break;
                default:
                    Console.WriteLine("Choose from given option only!\n");
                    break;
            }
        }

    }
}
       
        
    }

}
    
