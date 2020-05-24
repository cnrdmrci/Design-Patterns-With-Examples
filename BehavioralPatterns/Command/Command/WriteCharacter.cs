using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;

namespace DesignPatterns.BehavioralPatterns.Command.Command
{
    public class WriteCharacter : IEditorCommand
    {
        private readonly IEditor _editor;
        private readonly char _character;

        public WriteCharacter(IEditor editor,char character)
        {
            _editor = editor;
            _character = character;
        }
        public void Execute()
        {
            _editor.WriteCharacterToTheEndOfTheText(_character);
        }

        public void Undo()
        {

            _editor.DeleteLastCharacter();
        }

        public void Redo()
        {

            _editor.WriteCharacterToTheEndOfTheText(_character);
        }
    }
}
