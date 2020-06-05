using System;
using System.Collections.Generic;
using DesignPatterns.BehavioralPatterns.Memento.AbstractMemento;
using DesignPatterns.BehavioralPatterns.Memento.Originator;

namespace DesignPatterns.BehavioralPatterns.Memento.CareTaker
{
    public class GameCareTaker
    {
        private readonly Game _game;
        private readonly Stack<IMemento> _backUpStack;

        private GameCareTaker()
        {}

        public GameCareTaker(Game game)
        {
            _game = game;
            _backUpStack = new Stack<IMemento>();
        }

        public void MakeBackup()
        {
            var backUp = _game.CreateSnapshot();
            _backUpStack.Push(backUp);
        }

        public void Undo()
        {
            if (_backUpStack.Count > 0)
            {
                IMemento backUp = _backUpStack.Pop();
                backUp?.Restore();
                Console.WriteLine("GameCaretaker: Restoring level to: " + backUp?.GetLevel());
            }
                
        }
    }
}
