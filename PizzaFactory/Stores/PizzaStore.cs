using PizzaFactory.Factories;

namespace PizzaFactory.Stores;

public abstract class PizzaStore
{
    public IPizza OrderPizza(string type)
    {
        // the creation of the pizza is the part of the code that varies thus we delegate the creation to the subclasses
        var pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    // here we are allowing the subclasses to decide how to create the pizza (factory method)
    protected abstract IPizza CreatePizza(string type);
}