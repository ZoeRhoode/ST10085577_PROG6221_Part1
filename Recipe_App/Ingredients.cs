using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_App
{
    internal class Ingredients
    {
        public List<Ingredients> Ingredient { get; set; }
        private List<Recipe> recipes;
        public string IngredientName { get; set; }
        public double Quantity { get; set; }
        public string UnitofMeasurments { get; set; }
        public int Calories { get; set; }
        public string FoodGroups { get; set; }
        public string Description { get; set; }
        
    }
    
   

}

