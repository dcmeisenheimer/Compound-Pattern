using System;

namespace Compound_Pattern
{
    public class CountingDuckFactory : AbstractDuckFactory //Still extends the abstract library
    {
        public override IQuackable CreateDuckCall() //Each method wraps the IQuackable with the quack counting decorator
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateMallardDuck() //Our main method doesnt need to know the difference
        {
            return new QuackCounter(new MallerdDuck());
        }

        public override IQuackable CreateRedHeadDuck() //It just knows its getting IQuackable back
        {
            return new QuackCounter(new RedHeadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
