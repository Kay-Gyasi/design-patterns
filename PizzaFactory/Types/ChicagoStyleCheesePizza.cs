namespace PizzaFactory.Types;

public class ChicagoStyleCheesePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Chicago Cheese Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Chicago Cheese Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Chicago Cheese Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Chicago Cheese Pizza");
    }
}