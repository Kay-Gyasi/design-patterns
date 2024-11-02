namespace StarbuzzCoffee.ConcreteComponents;

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf Coffee";
    }
    public override decimal Cost()
    {
        const decimal baseCost = 1.05m;

        return Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.10m,
            BeverageSize.Venti => baseCost + 0.15m,
            _ => baseCost
        };
    }
}