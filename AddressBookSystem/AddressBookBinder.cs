using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookBinder
    {
        public Dictionary<string, List<Contact>> Binder = new Dictionary<string, List<Contact>>();
        public void AddAddrBook(string key, List<Contact> list)
        {
            if(this.Binder.ContainsKey(key))
            {
                Console.WriteLine("Address book already exists");
            }
            else
            {
                Console.WriteLine("New address book created");
                Binder.Add(key, list);
            }
        }
    }
}
