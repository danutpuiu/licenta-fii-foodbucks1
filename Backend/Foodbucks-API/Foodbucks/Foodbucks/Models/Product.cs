using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodbucks.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public UnitOfMeasurement UnitOfMeasure { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        [ForeignKey("Store")]
        public int StoreRefId { get; set; }
        public Store Store { get; set; }
    }
}
