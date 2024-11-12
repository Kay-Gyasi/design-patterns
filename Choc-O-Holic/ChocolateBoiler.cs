using System.Runtime.CompilerServices;

namespace Choc_O_Holic;

public class ChocolateBoiler
{
    private bool _empty;
    private bool _boiled;

    private static ChocolateBoiler? _boiler;

    private ChocolateBoiler()
    {
        Console.WriteLine("Creating unique instance of Chocolate Boiler");

        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (_boiler is null)
        {
            _boiler = new ChocolateBoiler();
            return _boiler;
        }

        Console.WriteLine("Returning existing instance of Chocolate Boiler");
        return _boiler;
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