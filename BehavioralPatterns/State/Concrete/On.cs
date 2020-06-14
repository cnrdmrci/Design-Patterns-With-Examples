using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.State.Abstract;
using DesignPatterns.BehavioralPatterns.State.Product;

namespace DesignPatterns.BehavioralPatterns.State.Concrete
{
    public class On : IAirConditionerState
    {
        private readonly AirConditioner _airConditioner;

        public On(AirConditioner airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public IAirConditionerState Open()
        {
            Console.WriteLine("Air conditioner has already opened.");
            return this;
        }

        public IAirConditionerState Close()
        {
            Console.WriteLine("Air conditioner closed.");
            return new Off(_airConditioner);
        }

        public IAirConditionerState CoolWeather()
        {
            Console.WriteLine("Cooler mode run.");
            return this;
        }

        public IAirConditionerState WarmWeather()
        {
            Console.WriteLine("Warming mode run.");
            return this;
        }
    }
}
