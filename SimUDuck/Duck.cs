using SimUDuck.FlyingBehaviors;
using SimUDuck.QuackingBehaviors;

namespace SimUDuck;

public abstract class Duck
{
    public string Color { get; set; }
    public IFlyBehavior FlyBehavior { get; set; }
    public IQuackBehavior QuackBehavior { get; set; }

    public Duck(
        string color,
        IFlyBehavior flyBehavior,
        IQuackBehavior quackBehavior)
    {
        Color = color;
        FlyBehavior = flyBehavior;
        QuackBehavior = quackBehavior;
    }

    public void Swim()
    {
        Console.WriteLine("Swimming");
    }

    public void Display()
    {
        Console.WriteLine("Displaying");
    }
}