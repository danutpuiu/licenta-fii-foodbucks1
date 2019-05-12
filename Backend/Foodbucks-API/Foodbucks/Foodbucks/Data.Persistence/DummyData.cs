using Foodbucks.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Foodbucks.Data
{

    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<FoodBucksContext>();
                context.Database.EnsureCreated();

                if (context.Ingredients != null && context.Ingredients.Any())
                    return;

                var stores = GetStores().ToArray();
                context.Stores.AddRange(stores);
                context.SaveChanges();

                var unitOfMeasures = GetUnitOfMeasurements().ToArray();
                context.UnitOfMeasurements.AddRange(unitOfMeasures);
                context.SaveChanges();

                var products = GetProducts(context).ToArray();
                context.Products.AddRange(products);
                context.SaveChanges();

                var recipes = GetRecipes(context).ToArray();
                context.Recipes.AddRange(recipes);
                context.SaveChanges();
            }
        }

        public static List<UnitOfMeasurement> GetUnitOfMeasurements()
        {
            List<UnitOfMeasurement> unitOfMeasurements = new List<UnitOfMeasurement>(){
                new UnitOfMeasurement {Name = "tablespoon"},
                new UnitOfMeasurement {Name = "teaspoon"},
                new UnitOfMeasurement {Name = "gram"},
                new UnitOfMeasurement {Name = "kilogram"},
                new UnitOfMeasurement {Name = "milligram"},
                new UnitOfMeasurement {Name = "litre"},
                new UnitOfMeasurement {Name = "milliliter"},
                new UnitOfMeasurement {Name = "cup"},
                new UnitOfMeasurement {Name = "pint"},
                new UnitOfMeasurement {Name = "piece"},
                new UnitOfMeasurement {Name = "slice"},
                new UnitOfMeasurement {Name = "clove"}
            };
            return unitOfMeasurements;
        }

        public static List<Store> GetStores()
        {
            List<Store> stores = new List<Store>
            {
                new Store {Name = "KMart",
                    Description = "KMart is the best store.",
                    WebSiteAdress = "https://www.KMart.com"},
                new Store {Name = "Kepco",
                    Description = "Kepco is the best store.",
                    WebSiteAdress = "https://www.Kepco.com"},
                new Store {Name = "IKIA",
                    Description = "IKIA is the best store.",
                    WebSiteAdress = "https://www.IKIA.com"},
                new Store {Name = "GoShop",
                    Description = "GoShop is the best store.",
                    WebSiteAdress = "https://www.GoShop.com"},
                new Store {Name = "StartStore",
                    Description = "StartStore is the best store.",
                    WebSiteAdress = "https://www.StartStore.com"},
                new Store {Name = "AyeBay",
                    Description = "AyeBay is the best store.",
                    WebSiteAdress = "https://www.AyeBay.com"},
                new Store {Name = "NewMag",
                    Description = "NewMag is the best store.",
                    WebSiteAdress = "https://www.NewMag.com"}
            };
            return stores;
        }

        public static List<Product> GetProducts(FoodBucksContext db)
        {
            List<Product> products = new List<Product>
            {
                new Product {Name = "Flour",
                Brand = "Johnesey Cereals",
                Price = 1.89,
                Quantity = 1,
                UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "kilogram"),
                Store = db.Stores.FirstOrDefault(s => s.Name == "Kepco")},
                new Product {Name = "Sugar",
                Brand = "Margaritarus",
                Price = 1.39,
                Quantity = 1,
                UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "kilogram"),
                Store = db.Stores.FirstOrDefault(s => s.Name == "NewMag")},
                new Product {Name = "Salt",
                Brand = "Cacica's Best",
                Price = 1.00,
                Quantity = 1,
                UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "kilogram"),
                Store = db.Stores.FirstOrDefault(s => s.Name == "GoShop")},
                new Product {Name = "Egg",
                Brand = "Whole Foods Farm",
                Price = 0.5,
                Quantity = 1,
                UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "piece"),
                Store = db.Stores.FirstOrDefault(s => s.Name == "Kepco")}
            };
            return products;
        }

        public static List<Recipe> GetRecipes(FoodBucksContext db)
        {
            List<Recipe> recipes = new List<Recipe>
            {
                new Recipe {Name = "Frech Crepes",
                Description = "A good breakfast for weekends and even desserts. " +
                "Serve rolled up and filled with jam or fruit and whipped cream.",
                Servings = 12,
                Calories = 94,
                CookingTime = 35,
                Ingredients = new List<Ingredient>{
                    new Ingredient
                    {
                        Name = "Flour",
                        Quantity = 1.00,
                        UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "cup"),
                        Product = db.Products.FirstOrDefault(s => s.Name == "Flour")
                    },
                    new Ingredient
                    {
                        Name = "Sugar",
                        Quantity = 1.00,
                        UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "teaspoon"),
                        Product = db.Products.FirstOrDefault(s => s.Name == "Sugar")
                    },
                    new Ingredient
                    {
                        Name = "Egg",
                        Quantity = 3.00,
                        UnitOfMeasure = db.UnitOfMeasurements.FirstOrDefault(u => u.Name == "piece"),
                        Product = db.Products.FirstOrDefault(s => s.Name == "Egg")
                    }
                },
                InstructionSteps = new List<InstructionStep>
                {
                    new InstructionStep
                    {
                        StepNumber = 1,
                        Description = "Sift together flour, sugar and salt; set aside. In a large bowl, " +
                        "beat eggs and milk together with an electric mixer. Beat in flour mixture until smooth; stir in melted butter."
                    },
                    new InstructionStep
                    {
                        StepNumber = 2,
                        Description = "Heat a lightly oiled griddle or frying pan over medium high heat. Pour or scoop the batter onto the griddle, " +
                        "using approximately 2 tablespoons for each crepe. Tip and rotate pan to spread batter as thinly as possible. Brown on both sides and serve hot."
                    }
                }
                }
                
            };
            return recipes;
        }
    }
}
