using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State.Abstract
{
    public interface IAirConditionerState
    {
        IAirConditionerState Open();
        IAirConditionerState Close();
        IAirConditionerState CoolWeather();
        IAirConditionerState WarmWeather();
    }
}
