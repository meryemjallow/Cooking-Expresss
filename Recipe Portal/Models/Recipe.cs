using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipe_Portal.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public int CookingTime { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }

    }
}