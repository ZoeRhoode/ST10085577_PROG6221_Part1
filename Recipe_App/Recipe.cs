using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// Troelsen, A.Japikse, P. 2021.Pro c# 9 with. Net5. 10th ed. USA: West Chester.
//C# Tutorial - Full Course for Beginners- Mike. youtube video, added by Graffe acadamy.
//[Online]. Available at:https://www.youtube.com/watch?v=GhQdlIFylQ8&t=3163s 

namespace Recipe_App
{
    internal class Recipe
    {
        public string Name { get; set; }

        public List<Ingredients> Ingredients { get; set; }
        public List<Recipe> Steps { get; set; }
        public int TotalCalories { get; set; }
        

        public int numingredients;
        public string[] ingredientName;
        public double[] quantity;
        public double[] unitofmeasurement;
        public int numsteps;
        public string[] stepsdescription;
        public double[] calories;

        public Recipe()
        {
            //Empty arrays for all needed for the recipe
            ingredientName = new string[0];
            quantity = new double[0];
            unitofmeasurement = new double[0];
            stepsdescription = new string[0];
            calories= new double[0];
            
        }
        public Recipe(string name, List<Ingredients> ingredients, List<Recipe> steps)
        {
            //arrays for all needed for the recipe
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
            TotalCalories = CalculateTotalCalories();
        }

        private int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (Ingredients ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }


        public void EnterDetails()
        {
            //ask the user to enter the number of ingredients

            Console.WriteLine("number of ingredients:");
            int numingredients = int.Parse(Console.ReadLine());
            ingredientName = new string[numingredients];
            quantity = new double[numingredients];
            unitofmeasurement = new double[numingredients];


            //user must enter the details for each ingredient
            for (int i = 0; i < numingredients; i++)
            {
                Console.WriteLine("Enter the details for the ingredients:");
                Console.ReadLine();

                Console.Write("ingredientName:"[i]);
                ingredientName[i] = Console.ReadLine();

                Console.Write("quantity:"[i]);
                Console.ReadLine();

                Console.Write("unit of measurements:"[i]);
                Console.ReadLine();
            }

        }
        public void DisplayRecipe()
        {
            //display the ingredients and quantity for the reciepe 
            Console.WriteLine("Display ingredients:");
            for (int i = 0; i < ingredientName.Length; i++)
            {
                Console.WriteLine($"- {quantity[i]} {unitofmeasurement[i]} of {ingredientName[i]}");
            }
            //display steps
            Console.WriteLine("steps:");
            for (int i = 0; i < stepsdescription.Length; i++)
            {
                Console.WriteLine($"-{stepsdescription[i]}");
            }
        }
        public void Measurements(double factor)
        {
            Console.WriteLine("Enter the measurements ( 0.5 (half), 2 (double) or 3 (triple)):");

            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = quantity[i] *= factor;
            }


        }

        public void Quantities()
        {
            //quantities reset
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = quantity[i] /= 2;
            }
        }
        public void ClearRecipe() 
        {
        ingredientName= null;
        quantity= null;
        unitofmeasurement= null;        
        calories= null;

        }
    public void exit()
        {
            Environment.Exit(0);
        }
    }
}