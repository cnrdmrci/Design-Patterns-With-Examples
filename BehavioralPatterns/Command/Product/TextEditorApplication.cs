using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;
using DesignPatterns.BehavioralPatterns.Command.Command;
using DesignPatterns.BehavioralPatterns.Command.Common;
using DesignPatterns.BehavioralPatterns.Command.Invoker;

namespace DesignPatterns.BehavioralPatterns.Command.Product
{
    public class TextEditorApplication
    {
        private readonly IEditor _editor;
        private readonly IButton _button;
        private readonly EditorCommandHistory _editorUndoHistory;
        private readonly EditorCommandHistory _editorRedoHistory;

        public TextEditorApplication(IEditor editor,IButton button)
        {
            _editor = editor;
            _button = button;
            _editorUndoHistory = new EditorCommandHistory();
            _editorRedoHistory = new EditorCommandHistory();
        }

        public void PressAlphaNumericButton(char character)
        {
            IEditorCommand writeCharacter = new WriteCharacter(_editor, character);
            pressButton(writeCharacter);
        }

        public void PressDeleteButton()
        {
            IEditorCommand deleteCommand = new DeleteCharacter(_editor);
            pressButton(deleteCommand);
        }

        public void PressUndoButton()
        {
            undoButton();
        }

        public void PressRedoButton()
        {
            redoButton();
        }
        

        private void pressButton(IEditorCommand editorCommand)
        {
            _button.SetCommand(editorCommand);
            _button.Press();
            _editorUndoHistory.PushToTheHistory(editorCommand);
            _editorRedoHistory.Clear();
        }

        private void undoButton()
        {
            IEditorCommand editorCommand = _editorUndoHistory.PopFromTheHistory();
            if (editorCommand == null)
                return;

            _button.SetCommand(editorCommand);
            _button.Undo();
            _editorRedoHistory.PushToTheHistory(editorCommand);
        }

        private void redoButton()
        {
            IEditorCommand editorCommand = _editorRedoHistory.PopFromTheHistory();
            if (editorCommand == null)
                return;

            _button.SetCommand(editorCommand);
            _button.Redo();
            _editorUndoHistory.PushToTheHistory(editorCommand);
        }
    }
}
