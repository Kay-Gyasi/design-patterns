using PizzaFactory.Types;

namespace PizzaFactory.Factories;

public class ChicagoPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
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