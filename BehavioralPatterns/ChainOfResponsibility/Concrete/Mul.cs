﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Abstract;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Product;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Concrete
{
    public class Mul : OperationHandler
    {
        public override Operation Handle(Operation operation)
        {
            if (operation.OperationType == OperationType.Mul)
            {
                operation.Result = operation.FirstNumber * operation.SecondNumber;
                return operation;
            }

            return base.Handle(operation);
        }
    }
}
