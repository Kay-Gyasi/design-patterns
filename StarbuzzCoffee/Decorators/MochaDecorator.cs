namespace StarbuzzCoffee.Decorators;

public class MochaDecorator : Beverage
{
    public MochaDecorator(Beverage beverage)
    {
        Beverage = beverage;
        Description = Beverage.Description + ", Mocha";
    }

    private Beverage Beverage { get; }
    public override decimal Cost()
    {
        var baseCost = 0.20m + Beverage.Cost();

        return Beverage.Size switch
        {
            BeverageSize.Tall => baseCost,
            BeverageSize.Grande => baseCost + 0.07m,
            BeverageSize.Venti => baseCost + 0.17m,
            _ => baseCost
        };
    }
}