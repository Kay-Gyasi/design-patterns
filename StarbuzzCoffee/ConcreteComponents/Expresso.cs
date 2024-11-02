namespace StarbuzzCoffee.ConcreteComponents;

public class Expresso : Beverage
{
    public Expresso()
    {
        Description = "Expresso";
    }
    public override decimal Cost()
    {
        const decimal baseCost = 1.99m;

        return Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.10m,
            BeverageSize.Venti => baseCost + 0.15m,
            _ => baseCost
        };
    }
}