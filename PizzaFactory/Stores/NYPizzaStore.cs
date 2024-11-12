using PizzaFactory.Types;

namespace PizzaFactory.Stores;

public class NYPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
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