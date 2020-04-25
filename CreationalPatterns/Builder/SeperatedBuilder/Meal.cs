using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.SeperatedBuilder
{
    public class Meal
    {
        public string Drink { get; set; }
        public string Main { get; set; }
        public string Dessert { get; set; }
        public List<string> Additions { get; set; }

        public Meal()
        {
            Additions = new List<string>();
        }

        public override string ToString()
        {
            return $@"
                Meal Menu; 
                    Drink : {Drink}
                    Main : {Main} 
                    Dessert : {Dessert}
                    Additions : " + String.Join(',',Additions);
        }
    }
}
