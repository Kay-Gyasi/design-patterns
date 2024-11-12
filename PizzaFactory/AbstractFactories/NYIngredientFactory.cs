using PizzaFactory.AbstractFactories.NYIngredients;

namespace PizzaFactory.AbstractFactories;

public class NYIngredientFactory : IIngredientFactory
{
    public IDough CreateDough()
    {
        return new NYDough();
    }

    public ISauce CreateSauce()
    {
        return new NYSauce();
    }

    public ICheese CreateCheese()
    {
        return new NYCheese();
    }

    public IVeggies[] CreateVeggies()
    {
        return [new NYCarrot(), new NYOnion()];
    }

    public IPepperoni CreatePepperoni()
    {
        return new NYPepperoni();
    }

    public IClam CreateClam()
    {
        return new NYClam();
    }
}