using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class AdressBook
    {
        string _owner;
        List<Address> _addresses = new List<Address>();

        public string Owner { get => _owner; set => _owner = value; }
        public AdressBook(string owner)
        {
            _owner = owner;
        }
        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }
        public void RemoveAdress(int index)
        {
            _addresses.RemoveAt(index);
        }
        public override string ToString()
        {
            string addressesToString = string.Join(", \n", _addresses);
            return $"Owner: {Owner}\n{addressesToString}";
        }
    }
}
