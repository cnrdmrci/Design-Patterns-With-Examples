using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.SeperatedBuilder
{
    public class KidMealBuilder : IMealBuilder
    {
        private readonly Meal _meal;

        public KidMealBuilder()
        {
            _meal = new Meal();
        }

        public void SetDrink()
        {
            _meal.Drink = "Kids Drink";
        }

        public void SetMain()
        {
            _meal.Main = "Kids Main";
        }

        public void SetDessert()
        {
            _meal.Dessert = "Kids Dessert";
        }

        public void SetAdditions()
        {
            _meal.Additions.Add("Kids addition 1");
            _meal.Additions.Add("Kids addition 2");
        }

        public Meal Build()
        {
            return _meal;
        }
    }
}
