using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace UML2Julie
{
    public class PizzaCatalog //list      
    {
        private List<Pizza> _pizza;
        
        public PizzaCatalog()
        {
            _pizza = new List<Pizza>();
        }
    
        public int Count
        {
            get { return _pizza.Count; }
        }

        //look up pizza, if found return matching pizzaMenuNo, if not return null
        public Pizza LookupPizza(int pizzaMenuNo)
        {
            foreach (Pizza p in _pizza)
            {
                if (p.PizzaMenuNo == pizzaMenuNo)
                {
                    return p;
                }
            }
            return null;
        }

        //add pizza
        public void AddPizza(Pizza aPizza)
        {
            if (LookupPizza(aPizza.PizzaMenuNo) == null) 
                _pizza.Add(aPizza);
        }

        //delete pizza
        public void DeletePizza(int pizza)
        {
            Pizza p = LookupPizza(pizza);
            if (p != null)
            {
                _pizza.Remove(p);
            }
        }

        //print all pizzas
        public void PrintPizza()
        {
            foreach (Pizza p in _pizza)
            {
                Console.WriteLine(p);
            }
        }

        //update pizza
        public void UpdatePizza(int pizzaMenuNo, Pizza pizzaToUpdate)
        {
            int upPizzaIndex = _pizza.IndexOf(LookupPizza(pizzaMenuNo));
            _pizza[upPizzaIndex] = pizzaToUpdate;
        }

        }
    }
