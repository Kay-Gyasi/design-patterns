using PizzaFactory.AbstractFactories.ChicagoIngredients;

namespace PizzaFactory.AbstractFactories;

public class ChicagoIngredientFactory : IIngredientFactory
{
    public IDough CreateDough()
    {
        return new ChicagoDough();
    }

    public ISauce CreateSauce()
    {
        return new ChicagoSauce();
    }

    public ICheese CreateCheese()
    {
        return new ChicagoCheese();
    }

    public IVeggies[] CreateVeggies()
    {
        return [new ChicagoCarrot(), new ChicagoOnion()];
    }

    public IPepperoni CreatePepperoni()
    {
        return new ChicagoPepperoni();
    }

    public IClam CreateClam()
    {
        return new ChicagoClam();
    }
}