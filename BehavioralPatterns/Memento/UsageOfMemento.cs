using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Memento.CareTaker;
using DesignPatterns.BehavioralPatterns.Memento.Originator;

namespace DesignPatterns.BehavioralPatterns.Memento
{
    public class UsageOfMemento
    {
        public static void Run()
        {
            Game game = new Game();
            game.SetSection(1,"Rock");
            Console.WriteLine(game.ToString());

            GameCareTaker careTaker = new GameCareTaker(game);
            careTaker.MakeBackup();

            game.SetSection(2,"Paper");
            Console.WriteLine(game.ToString());

            careTaker.Undo();
            Console.WriteLine(game.ToString());

            Console.Read();
        }
    }
}
