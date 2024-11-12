using PizzaFactory.Types;

namespace PizzaFactory.Factories;

public class NYPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        IPizza pizza = type switch
        {
            "cheese" => new NYStyleCheesePizza(),
            "pepperoni" => new NYStylePepperoniPizza(),
            "clam" => new NYStyleClamPizza(),
            "veggie" => new NYStyleVeggiePizza(),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };

        return pizza;
    }
}