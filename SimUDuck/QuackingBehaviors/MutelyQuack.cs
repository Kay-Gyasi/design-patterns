namespace SimUDuck.QuackingBehaviors;

public class MutelyQuack : IQuackBehavior
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}