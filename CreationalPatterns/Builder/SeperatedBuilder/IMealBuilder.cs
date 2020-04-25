using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.SeperatedBuilder
{
    public interface IMealBuilder
    {
        void SetDrink();
        void SetMain();
        void SetDessert();
        void SetAdditions();
        Meal Build();
    }
}
