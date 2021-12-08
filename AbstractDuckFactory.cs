using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System;

namespace Compound_Pattern
{
    public abstract class AbstractDuckFactory //Factory Pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created
    {
        //Define an abstract factory class that subclasses will implement to create different families       
        public abstract IQuackable CreateMallardDuck(); //Each method creates one type of duck
        public abstract IQuackable CreateRedHeadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();



    }
}
