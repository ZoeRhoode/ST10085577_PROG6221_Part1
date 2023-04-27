using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
//Troelsen, A. Japikse, P. 2021. Pro c# 9 with. Net5. 10th ed. USA: West Chester.
//C# Tutorial - Full Course for Beginners- Mike. youtube video, added by Graffe acadamy.
    //[Online]. Available at:https://www.youtube.com/watch?v=GhQdlIFylQ8&t=3163s 

namespace Recipe_App
{
    internal class Program
    {
        private const string Value = "exit program";

        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
           

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1 Enter Details:");
                Console.WriteLine("2 Display recipe:");
                Console.WriteLine("3 Unit of Measurment:");
                Console.WriteLine("4 Quantities:");
                Console.WriteLine("5 clear data");
                Console.WriteLine("6 Exit");

                int option = int.Parse (Console.ReadLine());

                switch (option)
                {
                    case 1:
                        recipe.EnterDetails();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        Console.WriteLine("Enter the measurements ( 0.5 (half), 2 (double) or 3 (triple)):");
                        double factor= double.Parse (Console.ReadLine());
                        recipe.DisplayRecipe();
                        break;
                    case 4:
                        recipe.Quantities();
                        break;
                    case 5:
                        recipe = new Recipe();
                        break;
                    case 6:
                        Console.WriteLine(Value);
                        break;
                }
            }
        }
    }
}