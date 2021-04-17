using System;
using System.Collections.Generic;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book service");

            //UC2
            List<AddressBook> AddressBookList = new List<AddressBook>()
            {
                new AddressBook(){FirstName="Shireen",LastName="kk",address="convent",city="madikeri",state="karnataka",Zip=571201,PhNum="7349319546",email="shireen@gmail.com"},
                new AddressBook(){FirstName="nurain",LastName="aster",address="adyar",city="mangalore",state="karnataka",Zip=570020,PhNum="984567321",email="nurain@gmail.com"},
                new AddressBook(){FirstName="Rahul",LastName="jain",address="brindavan",city="mumbai",state="maharashtra",Zip=400250,PhNum="6624289157",email="rahul@gmail.com"},
                new AddressBook(){FirstName="ankit",LastName="amin",address="majestic",city="surat",state="gujarat",Zip=562002,PhNum="8853247951",email="ankit@yahoo.com"},
                new AddressBook(){FirstName="arnal",LastName="lobo",address="gama",city="panaji",state="goa",Zip=2236970,PhNum="7235698451",email="arnallobo@abc.in"}
            };

            Manage manage = new Manage();
            manage.TopRecords(AddressBookList);



        }
    }
}
