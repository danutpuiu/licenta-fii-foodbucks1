using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodbucks.Models
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public UnitOfMeasurement UnitOfMeasure { get; set; }
        public double Quantity { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Recipe")]
        public int RecipeRefId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
