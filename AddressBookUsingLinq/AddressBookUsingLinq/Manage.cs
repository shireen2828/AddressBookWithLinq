using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookUsingLinq
{
    class Manage
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<AddressBook> listaddressbook)
        {
            var updateData = (from AddressBooks in listaddressbook
                              where (AddressBooks.state == "goa")
                              select AddressBooks);
            foreach(var names in updateData)
            {
                Console.WriteLine("persons name is: " + names.FirstName);
            }
            
        }
    }
}
