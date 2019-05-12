using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodbucks.Models
{
    public class InstructionStep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstructionStepId { get; set; }
        public short StepNumber { get; set; }
        public string Description { get; set; }
        [ForeignKey("Recipe")]
        public int RecipeRefId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
