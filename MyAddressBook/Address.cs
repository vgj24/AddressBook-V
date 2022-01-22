using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAddressBook
{
    internal class Address
    {
        public string name;
        public string address;

        public Address(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
