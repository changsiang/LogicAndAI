using System;
using System.Collections;
using System.Collections.Generic;

namespace AI_LogicAndAI
{
    public abstract class Formula
    {
        public abstract bool Evaluate();
        public abstract IEnumerable<Variable> Variables();
    }
}
