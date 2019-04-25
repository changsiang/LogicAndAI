using System;
using System.Collections;
using System.Collections.Generic;

namespace AI_LogicAndAI
{
    public class Not : Formula
    {
        public Formula P { get; set; }

        public Not(Formula p)
        {
            P = p;
        }

        public override bool Evaluate()
        {
            return !P.Evaluate();
        }

        public override IEnumerable<Variable> Variables()
        {
            return new List<Variable>(P.Variables());
        }
    }
}
