using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Julie
{
    public class CustomerRepository //dictonary       
    {
        private Dictionary<int, Customer> _customer; 

        public CustomerRepository()
        {
            _customer = new Dictionary<int, Customer>();
        }
        public int Count
        {
            get { return _customer.Count; }
        }

        //add new customer
        public void AddCustomer(Customer aCus)
        {
            if (!_customer.ContainsKey(aCus.CustomerID)) 
                _customer.Add(aCus.CustomerID, aCus);
        }

        //look up customer, if found return matching cusID, if not return null
        public Customer LookupCustomer(int customerID)
        {
            if (_customer.ContainsKey(customerID))
            {
                return _customer[customerID];
            }
            return null;
        }
        
        //delete customer
        public void DeleteCustomer(int customerID)
        {
            if (_customer.ContainsKey(customerID))
                _customer.Remove(customerID);
        }

        //print all customers
        public void PrintCustomer()
        {
            foreach (Customer customer in _customer.Values)
            {
                Console.WriteLine(customer); //customer.ToString()
            }
        }

        //update customers
        public void UpdateCustomer(int customerID, Customer cusToUpdate)
        {
            if (_customer.ContainsKey(customerID))
            {
                _customer[customerID] = cusToUpdate;
            }
        }
    }
}
