namespace SimUDuck.QuackingBehaviors;

public class Quack : IQuackBehavior
{
    public void MakeSound()
    {
        Console.WriteLine("Quack!");
    }
}