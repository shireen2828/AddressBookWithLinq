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
        public void RetrieveCount(List<AddressBook> listaddressbook)
        {
            var updateData = listaddressbook.GroupBy(x => x.FirstName).Select(x => new { FirstName= x.Key, Count = x.Count() });

            foreach(var names in updateData)
            {
                Console.WriteLine(names.FirstName + "---" + names.Count);
            }
        }
    }
}
