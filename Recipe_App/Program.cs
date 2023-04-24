using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Recipe_App
{
    internal class Program
    {
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
                        recipe.Measurements();
                        break;
                    case 4:
                        recipe.Quantities();
                        break;
                    case 5:
                        recipe = new Recipe();
                        break;
                    case 6:
                        Console.WriteLine("exit program");
                        
                       
                        break;
                }
            }
        }
    }
}