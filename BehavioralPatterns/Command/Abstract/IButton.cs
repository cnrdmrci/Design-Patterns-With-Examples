using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Command.Abstract
{
    public interface IButton
    {
        void SetCommand(IEditorCommand command);
        void Press();
        void Undo();
        void Redo();
    }
}
