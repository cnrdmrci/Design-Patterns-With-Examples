using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Command.Abstract;
using DesignPatterns.BehavioralPatterns.Command.Command;
using DesignPatterns.BehavioralPatterns.Command.Common;
using DesignPatterns.BehavioralPatterns.Command.Concrete;
using DesignPatterns.BehavioralPatterns.Command.Invoker;
using DesignPatterns.BehavioralPatterns.Command.Product;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class UsageOfCommand
    {
        public static void Run()
        {
            IEditor editor = new TextEditor();
            IButton button = new KeyboardButton();
            TextEditorApplication app = new TextEditorApplication(editor, button);

            app.PressAlphaNumericButton('A');
            app.PressAlphaNumericButton('B');
            app.PressAlphaNumericButton('C');

            app.PressDeleteButton();
            app.PressDeleteButton();

            app.PressUndoButton();
            app.PressUndoButton();
            app.PressUndoButton();
            app.PressUndoButton();
            app.PressUndoButton();
            app.PressUndoButton();
            app.PressUndoButton();

            app.PressRedoButton();
            app.PressRedoButton();
            app.PressRedoButton();
            app.PressRedoButton();
            app.PressRedoButton();
            app.PressRedoButton();
            app.PressRedoButton();

        }
    }
}
