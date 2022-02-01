using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }
        public bool add(string firstname,  string lastname,string address, string city, string state, string zipcode, string phonenumber, string email )
        {
       Address ad = new Address(firstname,lastname, address,city,state,zipcode,phonenumber,email);
            Address result = find(firstname);

            if (result == null)
            {
                addresses.Add(ad);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(string firstname, string lastname,string address, string city, string state, string zipcode, string phonenumber, string email)
        {
            Address ad = find(firstname);

            if (ad != null)
            {
                addresses.Remove(ad);
                return true;
            }
            else
            {
                return false;
            }
        }
       

        public Address find(string firstname)
        {
            Address ad = addresses.Find ( 
                delegate (Address a) {
                  return a.firstname == firstname;
              }
            );


            return ad;
        }
    }
}

