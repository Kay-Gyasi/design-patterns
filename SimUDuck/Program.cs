// See https://aka.ms/new-console-template for more information

using SimUDuck;
using SimUDuck.FlyingBehaviors;
using SimUDuck.QuackingBehaviors;

Console.WriteLine("Running SimUDuck Using The Strategy Pattern!");

Duck mallard = new MallardDuck("Green", new FlyWithWings(), new Quack());

Console.WriteLine("Mallard Duck");

mallard.FlyBehavior.Fly();
mallard.QuackBehavior.MakeSound();

Console.ReadKey();

Duck rubberDuck = new RubberDuck("Yellow", new FlyNoWings(), new Squeak());

Console.WriteLine("Rubber Duck");

rubberDuck.FlyBehavior.Fly();
rubberDuck.QuackBehavior.MakeSound();

// dynamically change the behavior of the rubber duck
Console.WriteLine("Rubber Duck can now fly!!");
rubberDuck.FlyBehavior = new FlyWithWings();
rubberDuck.FlyBehavior.Fly();

Console.ReadKey();