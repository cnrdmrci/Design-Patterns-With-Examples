using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;

namespace DesignPatterns.BehavioralPatterns.Command.Common
{
    public class EditorCommandHistory
    {
        private readonly Stack<IEditorCommand> _editorCommandList;

        public EditorCommandHistory()
        {
            _editorCommandList = new Stack<IEditorCommand>();
        }

        public void PushToTheHistory(IEditorCommand editorCommand)
        {
            _editorCommandList.Push(editorCommand);
        }

        public IEditorCommand PopFromTheHistory()
        {
            IEditorCommand editorCommand = null;

            if(_editorCommandList.Count > 0) 
                editorCommand = _editorCommandList.Pop();

            return editorCommand;
        }

        public void Clear()
        {
            _editorCommandList.Clear();
        }
    }
}
