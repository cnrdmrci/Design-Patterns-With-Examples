using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Interpreter.Abstract;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Expression
{
    public class NonTerminalExpressionSub : AbstractExpression
    {
        public override void Interpret(Stack<int> s)
        {
            int rightNumber = s.Pop();
            int leftNumber = s.Pop();
            s.Push(leftNumber - rightNumber);
        }
    }
}
