using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Command.Abstract
{
    public interface IEditor
    {
        void WriteCharacterToTheEndOfTheText(char character);
        char DeleteLastCharacter();
    }
}
