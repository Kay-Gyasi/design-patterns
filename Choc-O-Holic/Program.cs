// See https://aka.ms/new-console-template for more information

using Choc_O_Holic;

await Task.WhenAll(
    Task.Run(ChocolateBoiler.GetInstance),
    Task.Run(ChocolateBoiler.GetInstance),
    Task.Run(ChocolateBoiler.GetInstance));

Console.WriteLine();

Console.WriteLine("Eager Loaded - handling multiple threads");

// use this approach when performance is a concern

await Task.WhenAll(
    Task.Run(ChocolateBoilerEagerLoaded.GetInstance),
    Task.Run(ChocolateBoilerEagerLoaded.GetInstance),
    Task.Run(ChocolateBoilerEagerLoaded.GetInstance));

Console.WriteLine();

Console.WriteLine("Locked - handling multiple threads");

// use this approach when performance is not a concern

await Task.WhenAll(
    Task.Run(ChocolateBoilerLocked.GetInstance),
    Task.Run(ChocolateBoilerLocked.GetInstance),
    Task.Run(ChocolateBoilerLocked.GetInstance));

Console.ReadKey();