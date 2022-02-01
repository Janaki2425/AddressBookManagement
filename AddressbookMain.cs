using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressbookMain
    {
        
class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }

        static void Main(string[] args)
        {
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Select the above options:");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void displayMenu()
        {
            
            Console.WriteLine("A  or a - Add an Address");
            Console.WriteLine("D  or d - Delete an Address");
            Console.WriteLine("E or e - Edit an Address");
            Console.WriteLine("Q or q - Quit");
        }

        void performAction(string selection)


        {
            string firstname = "";
            string lastname = "";
            string address = "";
            string city = "";
            string state = "";
            string zipcode="";
            string phonenumber="";
            string email = "";


            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter FirstName: ");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Enter LastName: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    state = Console.ReadLine();
                    Console.WriteLine("Enter Zipcode: ");
                    zipcode = Console.ReadLine();
                    Console.WriteLine("Enter Phonenumber: ");
                    phonenumber=Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    email = Console.ReadLine();

                        if (book.add(firstname, lastname,address, city, state, zipcode, phonenumber, email))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", firstname);
                    }
                    break;
                case "D":

                    Console.WriteLine("Enter Firstname to Delete: ");
                    firstname = Console.ReadLine();
                    
                        if (book.remove(firstname, lastname, address, city, state, zipcode, phonenumber, email))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", firstname);
                    }
                    break;
                
                    
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    firstname = Console.ReadLine();
                    Address ad = book.find(firstname);
                    if (ad == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", firstname);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                
                            
                            ad.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", firstname);
                    }
                    break;
            }
        }
    }

}
}
