using System;
using System.Collections;

namespace AI_LogicAndAI
{
    public class And : BinaryGate
    {
        public And(Formula p, Formula q) : base(p, q)
        {
        }

        public override bool Evaluate()
        {
            return P.Evaluate() && Q.Evaluate();
        }
    }
}
