using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.State.Abstract;
using DesignPatterns.BehavioralPatterns.State.Concrete;

namespace DesignPatterns.BehavioralPatterns.State.Product
{
    public class AirConditioner 
    {
        private IAirConditionerState _iAirConditionerState;
        public bool IsOpen => _iAirConditionerState is On;

        public AirConditioner()
        {
            _iAirConditionerState = new Off(this);
        }

        public void Open()
        {
            _iAirConditionerState = _iAirConditionerState.Open();
        }

        public void Close()
        {
            _iAirConditionerState = _iAirConditionerState.Close();
        }

        public void CoolWeather()
        {
            _iAirConditionerState = _iAirConditionerState.CoolWeather();
        }

        public void WarmWeather()
        {
            _iAirConditionerState = _iAirConditionerState.WarmWeather();
        }
    }
}
