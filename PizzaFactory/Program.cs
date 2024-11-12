// See https://aka.ms/new-console-template for more information

using PizzaFactory.Stores;

Console.WriteLine("Demo of Factory Method Pattern");

Console.WriteLine("Creating a NY Style Pizza Store");

PizzaStore nyStore = new NYPizzaStore();
nyStore.OrderPizza("cheese");

Console.WriteLine();
Console.WriteLine("Creating a Chicago Style Pizza Store");

PizzaStore chicagoStore = new ChicagoPizzaStore();
chicagoStore.OrderPizza("cheese");

Console.WriteLine("Demo of Factory Method Pattern Complete");

Console.ReadLine();