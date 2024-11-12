namespace PizzaFactory.Types;

public class NYStyleClamPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing NY Clam Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking NY Clam Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting NY Clam Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing NY Clam Pizza");
    }
}