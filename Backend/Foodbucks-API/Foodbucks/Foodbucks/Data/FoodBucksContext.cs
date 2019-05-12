using Foodbucks.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodbucks.Data
{
    public class FoodBucksContext : DbContext
    {
        public FoodBucksContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<InstructionStep> InstructionSteps { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
