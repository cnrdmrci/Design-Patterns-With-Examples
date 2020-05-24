using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Command.Abstract
{
    public interface IEditorCommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
