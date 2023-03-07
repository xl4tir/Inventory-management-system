﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EntityFrameworkDAL.Exceptions;
using EntityFrameworkDAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDAL.Repositories.Concrete
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly InventoryManagementDbContext DbContext;

        protected readonly DbSet<TEntity> Table;
        
        protected GenericRepository(InventoryManagementDbContext dBContext)
        {
            DbContext = dBContext;
            Table = DbContext.Set<TEntity>();
        }
        
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }
        
        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id)
                   ?? throw new EntityNotFoundException(typeof(TEntity).Name, id);
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            var propInfo = entity.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(x => x.Name.Equals("Id"));

            if(propInfo != null)
                propInfo.SetValue(entity, 0);
            
            await Table.AddAsync(entity);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => Table.Update(entity));
        }

        public virtual async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            await Task.Run(() => Table.Remove(entity));
        }
    }
}