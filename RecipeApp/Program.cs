﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("Select the following option:");
                Console.WriteLine("1. Would you like to add new recipe?");
                Console.WriteLine("2. Would you like to display recipe?");
                Console.WriteLine("3. Would you like to scale recipe?");
                Console.WriteLine("4. Would you like to reset quantity?");
                Console.WriteLine("5. Would you like to clear recipe?");
                Console.WriteLine("6. Exit Application");

                int command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        recipe.AddRecipe();
                        break;

                    case 2:
                        recipe.RecipeDisplay();
                        break;

                    case 3:
                        Console.Write("Type the scale factor required: ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.RecipeScale(factor);
                        break;

                    case 4:
                        recipe.QuantityReset();
                        break;

                    case 5:
                        recipe.RecipeCleared();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Input not valid!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
 }
 
