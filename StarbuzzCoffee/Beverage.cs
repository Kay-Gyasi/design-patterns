namespace StarbuzzCoffee;

public abstract class Beverage
{
    public string Description { get; protected set; }
    public BeverageSize Size { get; set; } = BeverageSize.Tall;
    public abstract decimal Cost();
}

public enum BeverageSize
{
    Tall,
    Grande,
    Venti
}