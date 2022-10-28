using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Julie
{
    public class Pizza
    {
        private int _pizzaMenuNo;
        private string _name;
        private string _ingredients;
        private double _price;

        public int PizzaMenuNo
        { get { return _pizzaMenuNo; } set { _pizzaMenuNo = value; } }

        public string Name
        { get { return _name; } set { _name = value; } }

        public string Ingredients
        { get { return _ingredients; } set { _ingredients = value; } }

        public double Price
        { get { return _price; } set { _price = value; } }

        public Pizza(int pizzaMenuNo, string name, string ingredients, double price)
        {
            _pizzaMenuNo = pizzaMenuNo;
            _name = name;
            _ingredients = ingredients;
            _price = price;
        }

        public override string ToString()
        {
            return $"Pizzaens menu nr. er {_pizzaMenuNo}, navnet er {_name}, ingredienserne er {_ingredients} og prisen er {_price} kr.";
        }
    }
}

