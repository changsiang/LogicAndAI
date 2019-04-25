using System;

namespace AI_LogicAndAI
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Variable(false);
            var p = new Variable(false);

            var formula = new Or(new Not(p), q);
            Console.WriteLine(formula.Evaluate());

            p.Value = true;
            Console.WriteLine(formula.Evaluate());

            Console.Read();
        }
    }
}
