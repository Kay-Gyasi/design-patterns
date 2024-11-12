namespace Choc_O_Holic;

public class ChocolateBoilerEagerLoaded
{
    private bool _empty;
    private bool _boiled;

    private static readonly ChocolateBoilerEagerLoaded Boiler = new ();

    private ChocolateBoilerEagerLoaded()
    {
        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoilerEagerLoaded GetInstance()
    {
        Console.WriteLine("Returning existing instance of Chocolate Boiler");

        return Boiler;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            _empty = false;
            _boiled = false;
            // fill the boiler with a milk/chocolate mixture
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            // drain the boiled milk and chocolate
            _empty = true;
        }
    }

    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            // bring the contents to a boil
            _boiled = true;
        }
    }

    private bool IsEmpty() => _empty;

    private bool IsBoiled() => _boiled;
}