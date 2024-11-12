namespace PizzaFactory.Types;

public class ChicagoStylePepperoniPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Chicago Pepperoni Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Chicago Pepperoni Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Chicago Pepperoni Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Chicago Pepperoni Pizza");
    }
}