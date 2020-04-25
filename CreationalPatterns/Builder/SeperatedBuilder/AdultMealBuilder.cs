using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.SeperatedBuilder
{
    public class AdultMealBuilder : IMealBuilder
    {
        private readonly Meal _meal;

        public AdultMealBuilder()
        {
            _meal = new Meal();
        }

        public void SetDrink()
        {
            _meal.Drink = "Adult Drink";
        }

        public void SetMain()
        {
            _meal.Main = "Adult Main";
        }

        public void SetDessert()
        {
            _meal.Dessert = "Adult Dessert";
        }

        public void SetAdditions()
        {
            _meal.Additions.Add("Adult addition 1");
            _meal.Additions.Add("Adult addition 2");
        }

        public Meal Build()
        {
            return _meal;
        }
    }
}
