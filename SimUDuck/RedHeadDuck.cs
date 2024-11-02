using SimUDuck.FlyingBehaviors;
using SimUDuck.QuackingBehaviors;

namespace SimUDuck;

public class RedHeadDuck : Duck
{
    public RedHeadDuck(string color,
        IFlyBehavior flyBehavior,
        IQuackBehavior quackBehavior)
        : base(color, flyBehavior, quackBehavior)
    {
    }
}