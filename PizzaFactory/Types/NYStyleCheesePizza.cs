namespace PizzaFactory.Types;

public class NYStyleCheesePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing NY Cheese Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking NY Cheese Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting NY Cheese Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing NY Cheese Pizza");
    }
}