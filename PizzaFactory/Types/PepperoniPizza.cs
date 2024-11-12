namespace PizzaFactory.Types;

public class PepperoniPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Pepperoni Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Pepperoni Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Pepperoni Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Pepperoni Pizza");
    }
}