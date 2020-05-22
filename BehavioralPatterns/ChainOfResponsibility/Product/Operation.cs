using System;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Abstract;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Product
{
    public class Operation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public decimal Result { get; set; }
        public OperationType OperationType { get; set; }

        public override string ToString()
        {
            return $"FirstNumber : {FirstNumber} , SecondNumber : {SecondNumber} , Operation : {OperationType} , Result : {Result}";
        }
    }
}
