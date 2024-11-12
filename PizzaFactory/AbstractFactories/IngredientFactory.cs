namespace PizzaFactory.AbstractFactories;

// interface defining how to create a family of related products (ingredients) - the abstract factory
public interface IIngredientFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    IVeggies[] CreateVeggies();
    IPepperoni CreatePepperoni();
    IClam CreateClam();
}

public interface IDough{}
public interface ISauce{}
public interface ICheese{}
public interface IVeggies{}
public interface IPepperoni{}
public interface IClam{}
