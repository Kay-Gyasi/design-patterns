namespace PizzaFactory.Types;

public class ClamPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Clam Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Clam Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Clam Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Clam Pizza");
    }
}