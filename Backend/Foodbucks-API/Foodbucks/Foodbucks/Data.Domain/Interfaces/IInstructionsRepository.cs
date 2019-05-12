using Foodbucks.Data.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Foodbucks.Data.Domain.Interfaces
{
    public interface IInstructionsRepository : IGenericRepository<Instruction>
    {
        Task<IEnumerable<Instruction>> GetByRecipe(Guid recipeId);
        Task<IEnumerable<Instruction>> GetByRecipeAndInstructionNr(Guid recipeId, int instructionNr);
    }
}
