namespace StarbuzzCoffee.ConcreteComponents;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast Coffee";
    }
    public override decimal Cost()
    {
        const decimal baseCost = 0.99m;

        return Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.10m,
            BeverageSize.Venti => baseCost + 0.15m,
            _ => baseCost
        };
    }
}