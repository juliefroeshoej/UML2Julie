using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Julie
{
    public class Customer
    {
        private int _customerID;
        private string _name;
        private string _email;
        private string _address;

        public int CustomerID
        { get { return _customerID; } set { _customerID = value; } }

        public string Name
        { get { return _name; } set { _name = value; } }

        public string Email
        { get { return _email; } set { _email = value; } }

        public string Address
        { get { return _address; } set { _address = value; } }

        public Customer(int customerID, string name, string email, string address)
        {
            _customerID = customerID;
            _name = name;
            _email = email;
            _address = address;
        }
        public override string ToString()
        {
            return $"The Customers ID is {_customerID}, the name is {_name}, the mail is {_email} and the address is {_address}";
        }
    }
}

