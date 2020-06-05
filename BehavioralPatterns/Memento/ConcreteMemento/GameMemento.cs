using DesignPatterns.BehavioralPatterns.Memento.AbstractMemento;
using DesignPatterns.BehavioralPatterns.Memento.Originator;

namespace DesignPatterns.BehavioralPatterns.Memento.ConcreteMemento
{
    public class GameMemento : IMemento
    {
        private readonly Game _game;
        private readonly int _level;
        private readonly string _sectionName;

        public GameMemento(Game game,int level,string sectionName)
        {
            _game = game;
            _level = level;
            _sectionName = sectionName;
        }

        public int GetLevel()
        {
            return _level;
        }

        public string GetSectionName()
        {
            return _sectionName;
        }

        public void Restore()
        {
            _game.SetSection(_level, _sectionName);
        }
    }
}
