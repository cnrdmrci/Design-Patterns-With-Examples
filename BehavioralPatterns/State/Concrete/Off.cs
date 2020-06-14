using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.State.Abstract;
using DesignPatterns.BehavioralPatterns.State.Product;

namespace DesignPatterns.BehavioralPatterns.State.Concrete
{
    public class Off : IAirConditionerState
    {
        private readonly AirConditioner _airConditioner;

        public Off(AirConditioner airConditioner)
        {
            _airConditioner = airConditioner;
        }
        public IAirConditionerState Open()
        {
            Console.WriteLine("Air conditioner opened.");
            return new On(_airConditioner);
        }

        public IAirConditionerState Close()
        {
            Console.WriteLine("Air conditioner has already closed.");
            return this;
        }

        public IAirConditionerState CoolWeather()
        {
            Console.WriteLine("You need to open air conditioner");
            return this;
        }

        public IAirConditionerState WarmWeather()
        {
            Console.WriteLine("You need to open air conditioner");
            return this;
        }
    }
}
