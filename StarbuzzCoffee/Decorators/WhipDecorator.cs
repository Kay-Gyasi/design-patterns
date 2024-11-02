namespace StarbuzzCoffee.Decorators;

public class WhipDecorator : Beverage
{
    public WhipDecorator(Beverage beverage)
    {
        Beverage = beverage;
        Description = Beverage.Description + ", Whip Cream";
    }

    private Beverage Beverage { get; }
    public override decimal Cost()
    {
        var baseCost = 0.10m + Beverage.Cost();

        return Beverage.Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.05m,
            BeverageSize.Venti => baseCost + 0.10m,
            _ => baseCost
        };
    }
}