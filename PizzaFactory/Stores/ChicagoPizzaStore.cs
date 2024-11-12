using PizzaFactory.Types;

namespace PizzaFactory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        IPizza pizza = type switch
        {
            "cheese" => new ChicagoStyleCheesePizza(),
            "pepperoni" => new ChicagoStylePepperoniPizza(),
            "clam" => new ChicagoStyleClamPizza(),
            "veggie" => new ChicagoStyleVeggiePizza(),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };

        return pizza;
    }
}