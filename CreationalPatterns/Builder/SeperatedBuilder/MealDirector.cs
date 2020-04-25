using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.SeperatedBuilder
{
    public class MealDirector
    {
        private readonly IMealBuilder _mealBuilder;

        public MealDirector(IMealBuilder mealBuilder)
        {
            _mealBuilder = mealBuilder;
        }

        private void createMealMenu()
        {
            _mealBuilder.SetDrink();
            _mealBuilder.SetMain();
            _mealBuilder.SetDessert();
            _mealBuilder.SetAdditions();
        }

        public Meal GetMealMenu()
        {
            createMealMenu();
            return _mealBuilder.Build();
        }
    }
}
