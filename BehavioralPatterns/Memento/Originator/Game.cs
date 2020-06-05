using DesignPatterns.BehavioralPatterns.Memento.ConcreteMemento;

namespace DesignPatterns.BehavioralPatterns.Memento.Originator
{
    public class Game
    {
        private int _level;
        private string _sectionName;

        public override string ToString()
        {
            return $"Level {_level}, section name: {_sectionName}.";
        }

        public void SetSection(int level, string sectionName)
        {
            _sectionName = sectionName;
            _level = level;
        }

        public GameMemento CreateSnapshot()
        {
            return new GameMemento(this, _level, _sectionName);
        }
    }
}
