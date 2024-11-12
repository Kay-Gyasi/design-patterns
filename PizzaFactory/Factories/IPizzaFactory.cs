namespace PizzaFactory.Factories;

public interface IPizzaFactory
{
    IPizza CreatePizza(string type);
}