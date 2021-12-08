using System.Net.Sockets;
using System;

namespace Compound_Pattern
{
    public class QuackCounter : IQuackable //Decorator Wrapper implement target interface
    {
        IQuackable duck; //Instance of Var to hold quacker were decorating

        static int numberOfQuacks; //static var to hold count

        public QuackCounter(IQuackable duck) //Get reference to IQuackable were decorating in constructor
        {
            this.duck = duck; 
        }

        public void Quack() 
        {
            duck.Quack(); //Delegate the Quack call to the instance we are decorating
            numberOfQuacks++;// add count
        }

        public static int GetNumberOfQuacks() //Method to return count
        {
            return numberOfQuacks;
        }
    }
}
