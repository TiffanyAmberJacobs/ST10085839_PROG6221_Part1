using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Program
    {
        private static List<Recipe> recipes = new List<Recipe>(); // A list to store all the recipes

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the following option:");
                Console.WriteLine("1. Would you like to add new recipe?");
                Console.WriteLine("2. Would you like to display recipe?");
                Console.WriteLine("3. Would you like to scale recipe?");
                Console.WriteLine("4. Would you like to reset quantity?");
                Console.WriteLine("5. Would you like to clear recipe?");
                Console.WriteLine("6. Exit Application");

                int command = int.Parse(Console.ReadLine()); // Read the user's command

                switch (command)
                {
                    case 1:
                        AddNewRecipe(); // Call the method to add a new recipe
                        break;

                    case 2:
                        DisplayAllRecipes(); // Call the method to display all recipes
                        break;

                    case 3:
                        DisplaySpecificRecipe(); // Call the method to display a specific recipe
                        break;

                    case 4:
                        Environment.Exit(0); // Exit the application
                        break;

                    default:
                        Console.WriteLine("Input not valid!"); // Inform the user of an invalid input
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void AddNewRecipe()
        {
            Recipe recipe = new Recipe(); // Create a new instance of the Recipe class

            Console.Write("Enter recipe name: ");
            recipe.Name = Console.ReadLine(); // Read the recipe name from the user

            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine()); // Read the number of ingredients from the user

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter ingredient name {i + 1}: ");
                string ingredientName = Console.ReadLine(); // Read the ingredient name from the user

                Console.Write($"Enter quantity of {ingredientName}: ");
                double quantity = double.Parse(Console.ReadLine()); // Read the quantity from the user

                Console.Write($"Enter unit of measurement for {quantity} {ingredientName}: ");
                string unit = Console.ReadLine(); // Read the unit of measurement from the user

                Console.Write($"Enter number of calories for {ingredientName}: ");
                int calories = int.Parse(Console.ReadLine()); // Read the calories from the user

                Console.Write($"Enter food group for {ingredientName}: ");
                string foodGroup = Console.ReadLine(); // Read the food group from the user

                Ingredient ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup); // Create a new instance of the Ingredient class
                recipe.AddIngredient(ingredient); // Add the ingredient to the recipe
            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine()); // Read the number of steps from the user

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                string step = Console.ReadLine(); // Read each step from the user
                recipe.AddStep(step); // Add the step to the recipe
            }

            recipes.Add(recipe); // Add the completed recipe to the list of recipes

            Console.WriteLine("Recipe added successfully!");
        }

        private static void DisplayAllRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("Recipes:");
            foreach (Recipe recipe in recipes.OrderBy(r => r.Name)) // Sort the recipes by name and iterate through them
            {
                Console.WriteLine(recipe.Name); // Display the name of each recipe
            }
        }

        private static void DisplaySpecificRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("Select a recipe to display:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}"); // Display the index and name of each recipe
            }

            int recipeIndex = int.Parse(Console.ReadLine()); // Read the selected recipe index from the user
            recipeIndex--; // Adjust the index to match the zero-based list index

            if (recipeIndex < 0 || recipeIndex >= recipes.Count)
            {
                Console.WriteLine("Invalid recipe selection.");
                return;
            }

            Recipe selectedRecipe = recipes[recipeIndex]; // Get the selected recipe from the list

            selectedRecipe.RecipeDisplay(); // Display the details of the selected recipe
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
