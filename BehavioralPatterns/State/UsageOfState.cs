using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.State.Concrete;
using DesignPatterns.BehavioralPatterns.State.Product;

namespace DesignPatterns.BehavioralPatterns.State
{
    public class UsageOfState
    {
        public static void Run()
        {
            AirConditioner airConditioner = new AirConditioner();
            
            airConditioner.Open();
            airConditioner.CoolWeather();

            if(airConditioner.IsOpen)
                airConditioner.Close();

            airConditioner.WarmWeather();
            airConditioner.Close();

        }
    }
}
