using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodbucks.Models
{
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebSiteAdress { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
