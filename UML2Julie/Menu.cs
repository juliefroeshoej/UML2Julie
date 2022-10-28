using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Julie
{
    public class Menu
    {
        private PizzaCatalog _pizzaCatalog; //list
        private CustomerRepository _customerRepository; //dictonairy

        public Menu(PizzaCatalog pizzaCatalog, CustomerRepository customerRepository)
        {
            _pizzaCatalog = pizzaCatalog;
            _customerRepository = customerRepository;
        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        //show menu for pizza and customers 
        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------Pizza Menu--------------------");
            Console.WriteLine("\t1.\tTilføj pizza til ordre");
            Console.WriteLine("\t2.\tAlle pizza(er) i ordren");
            Console.WriteLine("\t3.\tSøg efter en pizza i ordren");
            Console.WriteLine("\t4.\tFjern pizza fra ordren");
            Console.WriteLine("\t5.\tOpdater pizza(er) på ordren");
            Console.WriteLine("\t---------------Customer List--------------------");
            Console.WriteLine("\t6.\tTilføj en kunde til listen");
            Console.WriteLine("\t7.\tUdskriv alle kunder fra listen");
            Console.WriteLine("\t8.\tSøg efter en kunde fra listen ud fra Customer ID");
            Console.WriteLine("\t9.\tFjern kunde fra listen");
            Console.WriteLine("\t10.\tOpdater kunder på listen");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return ReadUserChoice();
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear(); //add pizza to list
                        AddPizza();
                        break;
                    case 2: //print alle the pizzas on the list
                        Console.Clear();
                        Console.WriteLine("");
                        _pizzaCatalog.PrintPizza();
                        break;
                    case 3: // search pizza on list
                        Console.Clear();
                        LookupPizza();
                        break;
                    case 4:
                        Console.Clear(); //delete pizza from list
                        DeletePizza();
                        break;
                    case 5:
                        Console.Clear(); //update pizza list
                        UpdatePizzaList();
                        break;
                    case 6:
                        Console.Clear(); //add customer to repository
                        AddCustomer();
                        break;
                    case 7: //print all the customers in repository
                        Console.Clear();
                        Console.WriteLine("");
                        _customerRepository.PrintCustomer();
                        break;
                    case 8: // search customer in repository
                        Console.Clear();
                        LookupCustomer();
                        break;
                    case 9:
                        Console.Clear(); //delete customer from repository
                        DeleteCustomer();
                        break;
                    case 10:
                        Console.Clear(); //update customer repository
                        UpdateCustomer();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();
            }
        }

        #region Pizza 

        // add pizza
        private void AddPizza()
        {
            Console.WriteLine("Tilføj pizza");
            Console.WriteLine("Angiv menu nr.");
            int pizzaMenuNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv pizza navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv ingredienser");
            string ingredients = Console.ReadLine();
            Console.WriteLine("Angiv pris");
            int price = int.Parse(Console.ReadLine());
            Pizza p = new Pizza(pizzaMenuNo, name, ingredients, price); 
            _pizzaCatalog.AddPizza(p);
        }

        //search pizza
        private void LookupPizza()
        {
            Console.WriteLine("Søg efter en pizza");
            Console.WriteLine("Angiv menu nr.");
            int pizzaMenuNo = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaCatalog.LookupPizza(pizzaMenuNo); 
            if (pizza == null)
            {
                Console.WriteLine("Pizzaen eksisterer ikke");
            }
            else
            {
                Console.WriteLine(pizza);
            }
            Console.ReadLine();
        }

        //delete pizza
        private void DeletePizza()
        {
            Console.WriteLine("Fjern pizza");
            Console.WriteLine("Angiv pizza menu nr.");
            int pizzaMenuNo = int.Parse(Console.ReadLine()); 
            _pizzaCatalog.DeletePizza(pizzaMenuNo);
        }

        //update pizza list
        private void UpdatePizzaList()
        {
            Console.WriteLine("Updater pizzaliste");
            Console.WriteLine("Angiv menu nr. på den pizza som skal opdateres");
            int pizzaOld = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaCatalog.LookupPizza(pizzaOld);
            if (pizza == null)
            {
                Console.WriteLine("Pizzaen eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Opdater pizza");
                Console.WriteLine("Angiv menu nr.");
                int pizzaMenuNo= int.Parse(Console.ReadLine());
                Console.WriteLine("Angiv navn");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv ingredienser");
                string ingredients = Console.ReadLine();
                Console.WriteLine("Angiv pris");
                int price = int.Parse(Console.ReadLine());

                Pizza updatedPizza = new Pizza(pizzaMenuNo, name, ingredients, price);

                _pizzaCatalog.UpdatePizza(pizzaOld, updatedPizza);
                Console.WriteLine("Listen over pizza(erne) er opdateret");
                Console.ReadLine();
            }
        }
        #endregion

        #region Customer

        //add customer
        private void AddCustomer()
        {
            Console.WriteLine("Tilføj kunde");
            Console.WriteLine("Angiv kunde nr.");
            int customerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv mail");
            string email = Console.ReadLine();
            Console.WriteLine("Angiv adresse");
            string address = Console.ReadLine();
            Customer c = new Customer(customerID, name, email, address);
            _customerRepository.AddCustomer(c);
        }

        //search for customer
        private void LookupCustomer()
        {
            Console.WriteLine("Søg efter en kunde");
            Console.WriteLine("Angiv kunde nr.");
            int customerID = int.Parse(Console.ReadLine());
            Customer customer = _customerRepository.LookupCustomer(customerID);
            if (customer == null)
            {
                Console.WriteLine("Kunden eksisterer ikke");
            }
            else
            {
                Console.WriteLine(customer);
            }
            Console.ReadLine();
        }

        //delete customer
        private void DeleteCustomer()
        {
            Console.WriteLine("Slet kunde");
            Console.WriteLine("Angiv kunde nr.");
            int customerID = int.Parse(Console.ReadLine());
            _customerRepository.DeleteCustomer(customerID);
        }

        //update customer repository
        private void UpdateCustomer()
        {
            Console.WriteLine("Opdater kunde");
            Console.WriteLine("Angiv kunde nr. på kunde som skal opdateres");
            int customerIDOld = int.Parse(Console.ReadLine());
            Customer customer = _customerRepository.LookupCustomer(customerIDOld);
            if (customer == null)
            {
                Console.WriteLine("Kunden der søges efter eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Opdater kunde");
                Console.WriteLine("Angiv kunde nr.");
                int customerID = int.Parse(Console.ReadLine());
                Console.WriteLine("Angiv navn");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv email");
                string email = Console.ReadLine();
                Console.WriteLine("Angiv adresse");
                string address = Console.ReadLine();

                Customer updatedCustomer = new Customer(customerID, name, email, address);

                _customerRepository.UpdateCustomer(customerIDOld, updatedCustomer);
                Console.WriteLine("Kunden er blevet opdateret");
                Console.ReadLine();
            }
        }
        #endregion
    }
}
