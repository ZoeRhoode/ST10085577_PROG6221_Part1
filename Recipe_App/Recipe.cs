using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_App
{
    internal class Recipe
    {
        private int numingredients;
        private string[] ingredientName;
        private double[] quantity;
        private double[] unitofmeasurement;
        private int numsteps;
        private string[] stepsdescription;
        private double[] temp;


        public void EnterDetails()
        {
            //ask the user to enter the number of ingredients
            Console.WriteLine("number of ingredients:");
            int numingredients = int.Parse(Console.ReadLine());
            ingredientName = new string[numingredients];
            quantity = new double[numingredients];
            unitofmeasurement = new double[numingredients];
            temp = new double[numingredients];

            //user must enter the details for each ingredient
            for (int i = 0; i < numingredients; i++)
            {
                Console.WriteLine("Enter the details for the ingredients:");

                Console.Write("ingredientName:"[i]);
                Console.ReadLine();
                Console.Write("quantity:"[i]);
                Console.ReadLine();
                Console.Write("unit of measurements:"[i]);
                Console.ReadLine();
            }

        }
        public void DisplayRecipe()
        {
            //display the ingredients and quantity for the reciepe 
            Console.WriteLine("Display full recipe:");

            for (int i = 0; i < numingredients; i++)
            {
                Console.WriteLine($"- {quantity[i]} {unitofmeasurement[i]} of {ingredientName[i]}");
            }
            Console.WriteLine("steps:");
            for (int i = 0; i < stepsdescription.Length; i++)
            {
                Console.WriteLine($"-{stepsdescription[i]}");
            }
        }
        public void Measurements()
        {
            Console.WriteLine("Enter the measurements ( 0.5 (half), 2 (double) or 3 (triple)):");
            // declare & assign
            // if or switch
            for (int i = 0; i < quantity.Length; i++)
            {
                temp[i] = quantity[i] / 2;
            }
        }
        public void Quantities()
        {
            //quantities reset
            for (int i = 0; i < quantity.Length; i++)
            {
                temp[i] = 0;
            }
        }

        public void exit()
        {
            Environment.Exit(0);
        }
    }
}
