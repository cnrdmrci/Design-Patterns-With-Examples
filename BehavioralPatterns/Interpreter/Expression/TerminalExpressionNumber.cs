using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Interpreter.Abstract;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Expression
{
    public class TerminalExpressionNumber : AbstractExpression
    {
        private readonly int _number;

        public TerminalExpressionNumber(int number)
        {
            _number = number;
        }

        public override void Interpret(Stack<int> stack)
        {
            stack.Push(_number);
        }
    }
}
