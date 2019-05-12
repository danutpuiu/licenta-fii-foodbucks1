using Foodbucks.Data.Domain.Entities.RecipeEntities;
using System.Threading.Tasks;

namespace Foodbucks.Data.Domain.Interfaces
{
    public interface IStoresRepository : IGenericRepository<Store>
    {
        Task<bool> Exists(string name);
        Task<Store> GetByName(string name);
    }
}
