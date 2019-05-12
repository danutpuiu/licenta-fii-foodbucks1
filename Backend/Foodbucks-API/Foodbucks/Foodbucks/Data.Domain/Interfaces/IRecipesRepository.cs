using Foodbucks.Data.Domain.Entities;
using Foodbucks.Data.Domain.Entities.RecipeEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Foodbucks.Data.Domain.Interfaces
{
    public interface IRecipesRepository : IGenericRepository<Recipe>
    {
        Task UpdateCost();
        Task<IEnumerable<Recipe>> GetByName(string name, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByDescription(string description, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByServings(int servings, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByCalories(int calories, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByCookingTime(int cookingTime, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByLikes(int likes, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByVotes(int votes, Task<IEnumerable<Recipe>> recipes);
        Task<IEnumerable<Recipe>> GetByRating(double RecipeRatingType, Task<IEnumerable<Recipe>> recipes);
        
        Task<IEnumerable<Recipe>> GetByFilter(RecipeFilter filter);

        Task<IEnumerable<Recipe>> SortBy(string sortCriteria, string sortType);
    }
}
