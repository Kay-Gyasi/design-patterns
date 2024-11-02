namespace StarbuzzCoffee.Decorators;

public class MilkDecorator : Beverage
{
    public MilkDecorator(Beverage beverage)
    {
        Beverage = beverage;
        Description = Beverage.Description + ", Milk";
    }

    private Beverage Beverage { get; }
    public override decimal Cost()
    {
        var baseCost = 0.10m + Beverage.Cost();

        return Beverage.Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.05m,
            BeverageSize.Venti => baseCost + 0.12m,
            _ => baseCost
        };
    }
}