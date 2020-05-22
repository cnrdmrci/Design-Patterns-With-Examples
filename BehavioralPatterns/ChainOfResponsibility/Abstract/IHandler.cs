using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Product;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Abstract
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Operation Handle(Operation operation);
    }
}
