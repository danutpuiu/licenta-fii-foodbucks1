﻿using Data.Domain.Interfaces;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Source: Danut Puiu, Cristian Rusu, Nicusor Turcu, Tamara Trifan https://github.com/turcunicusor/KunFooD
// Class used as generic implementation of basic operations done to the database, independently of the specified class

namespace Logic
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly DbSet<T> _entities;

        protected GenericRepository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _entities = (databaseContext as DbContext)?.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public virtual async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
            await Save();
        }

        public virtual async Task Delete(Guid id)
        {
            var itemToRemove = await GetById(id);
            if (itemToRemove != null)
            {
                _entities.Remove(itemToRemove);
                await Save();
            }
        }

        public virtual async Task Edit(T entity)
        {
            _entities.Update(entity);
            await Save();
        }

        public virtual async Task Save()
        {
            await ((DbContext)_databaseContext).SaveChangesAsync();
        }
    }
}
