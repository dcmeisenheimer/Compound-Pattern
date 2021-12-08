using System;

namespace Compound_Pattern
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}
