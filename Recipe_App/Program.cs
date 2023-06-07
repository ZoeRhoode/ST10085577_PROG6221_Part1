using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
//Troelsen, A. Japikse, P. 2021. Pro c# 9 with. Net5. 10th ed. USA: West Chester.
//C# Tutorial - Full Course for Beginners- Mike. youtube video, added by Graffe acadamy.
//[Online]. Available at:https://www.youtube.com/watch?v=GhQdlIFylQ8&t=3163s 

namespace Recipe_App
{
    internal class Program
    {
        public const string Value = "exit program";

        static void Main(string[] args)
        {
            // Recipe has added fetures 

            Ingredients ingredients = new Ingredients();
            bool exit = false;            

            Recipe recipe = new Recipe();
                while (true)
                {
                //promt the user to add recipe and add calories etc.
                    Console.WriteLine("Choose option to add a recipe and proceed:");
                    Console.WriteLine("1. Add recipe:");
                    Console.WriteLine("2. Display recipe:");
                    Console.WriteLine("3. enter calories for ingredients");
                    Console.WriteLine("4. enter food group for each ingredient");
                    Console.WriteLine("5. Clear all or procceed:");
                    

                    Console.WriteLine("Options to enter details of recipe :");
                    Console.WriteLine("1 Enter Details of ingredients:");
                    Console.WriteLine("2 Display recipe:");
                    Console.WriteLine("3 Unit of Measurment for each ingredient:");
                    Console.WriteLine("4 Quantities:");
                    Console.WriteLine("5 clear data");
                    Console.WriteLine("6 Exit");
                    int option = int.Parse(Console.ReadLine());
                     
                switch (option)
                    {
                    case 1:
                        AddRecipe();
                        break;                   
                        break;                      
                    case 4:
                        ClearData();
                        break;
                    case 5:
                            recipe.EnterDetails();
                            break;
                        case 6:
                            recipe.DisplayRecipe();
                            break;
                        case 7:
                            Console.WriteLine("Enter the measurements ( 0.5 (half), 2 (double) or 3 (triple)):");
                            double factor = double.Parse(Console.ReadLine());
                            recipe.DisplayRecipe();
                            break;
                        case 8:
                            recipe.Quantities();
                            break;
                        case 9:
                            recipe = new Recipe();
                            break;
                        case 10:
                            Console.WriteLine(Value);
                            break;
                    }

                }
            
        }
        public void AddRecipe() 
        {
            Console.WriteLine("Recipe Name:");
            string Name= Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients");
            int numIngredients= int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++) 
            {
                Console.WriteLine($"Enter Ingredients name {i + 1}");
                string IngredientName = Console.ReadLine();

                Console.WriteLine($"Enter Ingredients quantity: {i + 1}");
                double quantity= double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter ingredient measurements: {i + 1}");
                double unitofmeasurements= double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the calories for the ingredient: {i+1}");
                double calories= double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the food group for each ingredient: {i + 1}");
                string foodgroup= Console.ReadLine();

            }
        }
        public void RecipeList(Recipe recipe) 
        {
            Console.WriteLine("Recipe List:");
            foreach (Recipe recipe1 in Recipe)
            {
                Console.WriteLine(recipe.Name);
            }
           
        }
        public void RecipeDetails() 
        {
            Console.WriteLine("Enter the name of the recipe wanted to desplay:");
            string name= Console.ReadLine();

            Console.WriteLine($"Total calories: {Recipe.TotalCalories}");
            if (Recipe.Calories > 300) 
            {
                Console.WriteLine("Recipe exceeds 300 calories!!");
            }
            else 
            { Console.WriteLine("Recipe is not over 300 calories."); }
        }
        public void ResetQuantities() 
        {
            Console.WriteLine("Reset all data");
            string Name = Console.ReadLine();

        }
        public void ClearData() 
        {
            Console.WriteLine("Do you want to clear all data (yes/no):");
            string answer= Console.ReadLine();

            if (answer == "yes")
            {
                Recipe.ClearRecipe();
                Console.WriteLine("Data has been cleared");
            }
            else 
            {
                Console.WriteLine("Clear data cancelled");
            }
        }
    }
    } 

