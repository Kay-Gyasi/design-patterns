namespace SimUDuck.QuackingBehaviors;

public class Squeak : IQuackBehavior
{
    public void MakeSound()
    {
        Console.WriteLine("Squeak!");
    }
}