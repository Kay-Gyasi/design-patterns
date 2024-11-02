using SimUDuck.FlyingBehaviors;
using SimUDuck.QuackingBehaviors;

namespace SimUDuck;

public class MallardDuck : Duck
{
    public MallardDuck(string color, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        : base(color, flyBehavior, quackBehavior)
    {
    }
}