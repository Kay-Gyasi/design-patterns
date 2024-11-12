namespace PizzaFactory.Types;

public class NYStylePepperoniPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing NY Pepperoni Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking NY Pepperoni Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting NY Pepperoni Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing NY Pepperoni Pizza");
    }
}