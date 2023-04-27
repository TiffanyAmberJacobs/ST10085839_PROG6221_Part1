using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Recipe
    {
        private string[] ingredient;
        private double[] quantity;
        private string[] unit;
        private string[] step;

        public void AddRecipe()
        {
            Console.Write("Type the amount of ingredients to be used: ");
            int numIngredient = int.Parse(Console.ReadLine());

            ingredient = new string[numIngredient];
            quantity = new double[numIngredient];
            unit = new string[numIngredient];

            for (int i = 0; i < numIngredient; i++)
            {
                Console.Write($"Type the ingredients names {i + 1}: ");
                ingredient[i] = Console.ReadLine();

                Console.Write($"Type the quantity of {ingredient[i]}: ");
                quantity[i] = double.Parse(Console.ReadLine());

                Console.Write($"Type the unit of measurement for {quantity[i]} {ingredient[i]}: ");
                unit[i] = Console.ReadLine();
            }

            Console.Write("Type the following number of steps required: ");
            int numSteps = int.Parse(Console.ReadLine());

            step = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Type step {i + 1}: ");
                step[i] = Console.ReadLine();
            }
        }

        public void RecipeDisplay()
        {
            Console.WriteLine("Ingredients required:");
            for (int i = 0; i < ingredient.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {quantity[i]} {unit[i]} {ingredient[i]}");
            }

            Console.WriteLine("Following steps required:");
            for (int i = 0; i < step.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {step[i]}");
            }
        }

        public void RecipeScale(double factor)
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] *= factor;
            }
        }

        public void QuantityReset()
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] /= 2;
            }
        }

        public void RecipeCleared()
        {
            ingredient = null;
            quantity = null;
            unit = null;
            step = null;
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
