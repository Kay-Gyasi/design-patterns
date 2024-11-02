using SimUDuck.FlyingBehaviors;
using SimUDuck.QuackingBehaviors;

namespace SimUDuck;

public class RubberDuck : Duck
{
    public RubberDuck(string color, IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        : base(color, flyBehavior, quackBehavior)
    {
    }
}