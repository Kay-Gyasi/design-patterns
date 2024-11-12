namespace PizzaFactory.Types;

public class ChicagoStyleVeggiePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Chicago Veggie Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Chicago Veggie Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Chicago Veggie Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Chicago Veggie Pizza");
    }
}