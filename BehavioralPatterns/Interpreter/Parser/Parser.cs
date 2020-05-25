using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Interpreter.Abstract;
using DesignPatterns.BehavioralPatterns.Interpreter.Expression;
using DesignPatterns.BehavioralPatterns.Interpreter.Product;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Parser
{
    public class ExpressionParser
    {
        private readonly Context _context;
        private readonly List<AbstractExpression> _parseTree;
        public ExpressionParser(Context context)
        {
            _context = context;
            _parseTree = new List<AbstractExpression>();
        }

        private void parse()
        {
            foreach (string value in _context.Input.Split(' '))
            {
                if (value.Equals("+"))
                {
                    _parseTree.Add(new NonTerminalExpressionAdd());
                }
                else if (value.Equals("-"))
                {
                    _parseTree.Add(new NonTerminalExpressionSub());
                }
                else
                {
                    _parseTree.Add(new TerminalExpressionNumber(Int32.Parse(value)));
                }
            }
        }

        public Context GetResult()
        {
            parse();
            Stack<int> stack = new Stack<int>();

            foreach (AbstractExpression expression in _parseTree)
            {
                expression.Interpret(stack);
            }

            _context.Output = stack.Pop();

            return _context;
        }
    }
}
