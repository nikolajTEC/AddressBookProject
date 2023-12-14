using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class Address
    {
        string _name;
        string _streetAdress;
        string _telephone;

        public Address(string name, string streetAdress, string telephone)
        {
            _name = name;
            _streetAdress = streetAdress;
            _telephone = telephone;
        }

        public string Name { get => _name; set => _name = value; }
        public string StreetAdress { get => _streetAdress; set => _streetAdress = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }

        public override string ToString()
        {
            return $"Name: {Name} Adress: {StreetAdress} PhoneNumber: {Telephone}";
        }
    }
}
