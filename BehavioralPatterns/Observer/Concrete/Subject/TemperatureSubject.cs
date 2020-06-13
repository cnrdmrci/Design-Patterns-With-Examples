using DesignPatterns.BehavioralPatterns.Observer.Abstract;

namespace DesignPatterns.BehavioralPatterns.Observer.Concrete.Subject
{
    public class TemperatureSubject : AbstractSubject
    {
        private decimal _temperatureValue;

        public TemperatureSubject()
        {
            _temperatureValue = 0;
        }

        public decimal TemperatureValue
        {
            get => _temperatureValue;
            set
            {
                if (_temperatureValue != value)
                {
                    _temperatureValue = value;
                    NotifyObservers();
                }
            }
        }
    }
}
