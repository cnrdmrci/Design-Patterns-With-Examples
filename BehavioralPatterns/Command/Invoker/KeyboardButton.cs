using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;

namespace DesignPatterns.BehavioralPatterns.Command.Invoker
{
    public class KeyboardButton : IButton
    {
        private IEditorCommand _command;

        public void SetCommand(IEditorCommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }

        public void Undo()
        {
            _command.Undo();
        }

        public void Redo()
        {
            _command.Redo();
        }
    }
}
