namespace StarbuzzCoffee.ConcreteComponents;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }
    public override decimal Cost()
    {
        const decimal baseCost = 0.89m;

        return Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.10m,
            BeverageSize.Venti => baseCost + 0.15m,
            _ => baseCost
        };
    }
}