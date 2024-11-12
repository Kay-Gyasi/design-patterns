namespace PizzaFactory.Types;

public class ChicagoStyleClamPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Chicago Clam Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Chicago Clam Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Chicago Clam Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Chicago Clam Pizza");
    }
}