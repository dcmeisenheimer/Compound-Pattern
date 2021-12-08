using System;

namespace Compound_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulate();
        }

        public static void Simulate()
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory(); //Create the factory object

            IQuackable mallardDuck = duckFactory.CreateMallardDuck(); //Use the factory to create the ducks instead of initiating them directly
            IQuackable redHeadDuck = duckFactory.CreateRedHeadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            //Add a goose that acts like a duck by wrapping it in the GooseAdapter
            IQuackable gooseDuck = new GooseAdapter(new Goose()); //We dont wrap goose in decorator because it doesnt quack

            //Simulate each duck
            System.Console.WriteLine("\nDuck Simulator");
            Simulate(mallardDuck);
            Simulate(redHeadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck); //After its wrapped we can treat it like any other IQuackable

            System.Console.WriteLine("The ducks quacked " + QuackCounter.GetNumberOfQuacks() + " times"); //Write out number of quacks

        }
        public static void Simulate(IQuackable duck) //Polymorphism
        {
            //Overload the simulate method to simulate just 1 duck
            //Polymorphism does its thing no matter what type of IQuackable gets passed
            duck.Quack();
        }
    }
}
