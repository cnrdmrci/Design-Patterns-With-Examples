using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;

namespace DesignPatterns.BehavioralPatterns.Command.Concrete
{
    public class TextEditor : IEditor
    {
        private string _text = "";
        public void WriteCharacterToTheEndOfTheText(char character)
        {
            Console.WriteLine("Writing new character : " + character);

            _text = _text + character;

            Console.WriteLine("Modified text: " + _text);
            Console.WriteLine("------------------------------------------\n");
        }

        public char DeleteLastCharacter()
        {
            char deletingCharacter = _text[^1];
            Console.WriteLine("Deleting last character : " + deletingCharacter);

            _text = _text.Substring(0, _text.Length - 1);

            Console.WriteLine("Modified text: " + _text);
            Console.WriteLine("------------------------------------------\n");

            return deletingCharacter;
        }
    }
}
