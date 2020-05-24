using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;

namespace DesignPatterns.BehavioralPatterns.Command.Command
{
    public class DeleteCharacter : IEditorCommand
    {
        private readonly IEditor _editor;
        private char _deletedCharacter;

        public DeleteCharacter(IEditor editor)
        {
            _editor = editor;
        }
        public void Execute()
        {
            _deletedCharacter = _editor.DeleteLastCharacter();
        }

        public void Undo()
        {

            _editor.WriteCharacterToTheEndOfTheText(_deletedCharacter);
        }

        public void Redo()
        {
            _deletedCharacter = _editor.DeleteLastCharacter();
        }
    }
}
