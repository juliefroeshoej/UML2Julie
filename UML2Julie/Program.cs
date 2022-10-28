
using System.Drawing;
using UML2Julie;

CustomerRepository repository = new CustomerRepository();
PizzaCatalog catalog = new PizzaCatalog();

Customer c1 = new Customer(123, "John Smith", "js@mail.com", "123 Street");
Customer c2 = new Customer(321, "Jane Harris", "jh@mail.com", "111 Road");
Customer c3 = new Customer(213, "Carl Landon", "cl@mail.com", "23 Corner");

repository.AddCustomer(c1);
repository.AddCustomer(c2);
repository.AddCustomer(c3);

Pizza p1 = new Pizza(1, "Margherita", "Tomato, cheese", 69);
Pizza p2 = new Pizza(2, "Vesuvio", "Tomato, cheese, ham", 75);
Pizza p3 = new Pizza(3, "Capricciosa", "Tomato, cheese, ham, mushrooms", 80);

catalog.AddPizza(p1);
catalog.AddPizza(p2);
catalog.AddPizza(p3);

Menu menu = new Menu(catalog, repository);
menu.Run();
Console.ReadLine();

