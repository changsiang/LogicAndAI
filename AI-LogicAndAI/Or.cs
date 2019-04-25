﻿using System;
namespace AI_LogicAndAI
{
    public class Or : BinaryGate
    {
        public Or(Formula p, Formula q) : base(p, q)
        {
        }

        public override bool Evaluate()
        {
            return P.Evaluate() || Q.Evaluate();
        }
    }
}
