using System;

namespace Compound_Pattern
{
    public class DuckFactory : AbstractDuckFactory //Duck Factory extends the abstract factory
    {
        public override IQuackable CreateDuckCall() //each method creates a particular kind of IQuackable
        {
            return new DuckCall();
        }

        public override IQuackable CreateMallardDuck() //The actual type is known to the application asking for it.
        {
            return new MallerdDuck();

        }

        public override IQuackable CreateRedHeadDuck() //It just knows its getting an IQuackable
        {
            return new RedHeadDuck();

        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();

        }
    }
}
