using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Abstract
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Stack<int> stack);
    }
}
