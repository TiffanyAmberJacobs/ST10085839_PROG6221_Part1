using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class Ingredient
    {
        public string Name { get; }
        public double Quantity { get; }
        public string Unit { get; }
        public int Calories { get; }
        public string FoodCatergory { get; }

        public Ingredient(string name, double quantity, string unit, int calories, string foodcatergory)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodCatergory = foodcatergory;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} {Name} ({Calories} calories)";
        }
    }
}
/*
 * Webpage name:Stackoverflow
 * Date accessed:24 April 2023
 * Website:https://stackoverflow.com/
 */

/*
 * Webpage name:W3Schools
 * Date accessed:24 April 2023
 * Website:https://www.w3schools.com/cs/index.php
 */


