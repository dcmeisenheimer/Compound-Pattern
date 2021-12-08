using System;

namespace Compound_Pattern //Adapter Wrapper
{
    public class GooseAdapter : IQuackable //Adapter implements the target interface
    {
        Goose goose;

        public GooseAdapter(Goose goose) //THe constructor takes the goose we are going to adapt
        {
            this.goose = goose;
        }

        public void Quack() //The adaption is made. We call the honk from quack
        {
            goose.Honk();
        }
    }
}
