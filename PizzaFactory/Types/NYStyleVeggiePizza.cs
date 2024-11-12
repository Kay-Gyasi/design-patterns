namespace PizzaFactory.Types;

public class NYStyleVeggiePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing NY Veggie Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking NY Veggie Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting NY Veggie Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing NY Veggie Pizza");
    }
}