using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Recipe
    {
        private List<Ingredient> ingredients = new List<Ingredient>(); // A list to store the ingredients
        private List<string> steps = new List<string>(); // A list to store the steps

        public string Name { get; set; } // The name of the recipe

        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient); // Add the ingredient to the list of ingredients
        }

        public void AddStep(string step)
        {
            steps.Add(step); // Add the step to the list of steps
        }

        public void RecipeDisplay()
        {
            Console.WriteLine($"Recipe: {Name}"); // Display the name of the recipe

            Console.WriteLine("Ingredients required:");
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ingredients[i]}"); // Display the details of each ingredient
            }

            Console.WriteLine("Steps required:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}"); // Display each step
            }

            int totalCalories = ingredients.Sum(i => i.Calories); // Calculate the total calories of the ingredients
            Console.WriteLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Console.WriteLine("Warning: This recipe exceeds 300 calories!"); // Display a warning if the total calories exceed 300
            }
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
