﻿using Data.Domain.Entities.RecipeEntities;
using System.Threading.Tasks;

namespace Data.Domain.Interfaces
{
    public interface IStoresRepository : IGenericRepository<Store>
    {
        Task<bool> Exists(string name);
        Task<Store> GetByName(string name);
    }
}
