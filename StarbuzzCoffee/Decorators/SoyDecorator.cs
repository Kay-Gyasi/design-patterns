namespace StarbuzzCoffee.Decorators;

public class SoyDecorator : Beverage
{
    public SoyDecorator(Beverage beverage)
    {
        Beverage = beverage;
        Description = Beverage.Description + ", Soy";
    }

    private Beverage Beverage { get; }
    public override decimal Cost()
    {
        var baseCost = 0.15m + Beverage.Cost();

        return Beverage.Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.03m,
            BeverageSize.Venti => baseCost + 0.09m,
            _ => baseCost
        };
    }
}