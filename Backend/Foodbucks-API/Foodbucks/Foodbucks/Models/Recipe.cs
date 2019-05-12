using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodbucks.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Servings { get; set; }
        public int Calories { get; set; }
        public int CookingTime { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<InstructionStep> InstructionSteps { get; set; }
    }
}
