using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        public static List<Contact> People;
        public AddressBook()
        {
            People = new List<Contact>();
        }
    }
}
