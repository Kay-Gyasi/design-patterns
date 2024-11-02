// See https://aka.ms/new-console-template for more information

using StarbuzzCoffee;
using StarbuzzCoffee.ConcreteComponents;
using StarbuzzCoffee.Decorators;

Console.WriteLine("Getting cost for double mocha soy latte with whip - Venti");

Beverage beverage = new HouseBlend();
beverage.Size = BeverageSize.Venti;

beverage = new MochaDecorator(beverage);

beverage = new MochaDecorator(beverage);

beverage = new SoyDecorator(beverage);

beverage = new WhipDecorator(beverage);

Console.WriteLine($"Cost for {beverage.Description}: " + beverage.Cost());

Console.WriteLine();

Console.WriteLine("Getting cost for double mocha soy latte with whip - Grande");

Beverage grandeBeverage = new HouseBlend();
grandeBeverage.Size = BeverageSize.Grande;

grandeBeverage = new MochaDecorator(grandeBeverage);

grandeBeverage = new MochaDecorator(grandeBeverage);

grandeBeverage = new SoyDecorator(grandeBeverage);

grandeBeverage = new WhipDecorator(grandeBeverage);

Console.WriteLine($"Cost for {grandeBeverage.Description}: " + grandeBeverage.Cost());

Console.ReadKey();