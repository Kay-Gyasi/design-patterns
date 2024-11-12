using PizzaFactory.Types;

namespace PizzaFactory.Factories;

public class SimplePizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        IPizza pizza = type switch
        {
            "cheese" => new CheesePizza(),
            "pepperoni" => new PepperoniPizza(),
            "clam" => new ClamPizza(),
            "veggie" => new VeggiePizza(),
            _ => throw new ArgumentException("Invalid type of pizza requested")
        };

        return pizza;
    }
}