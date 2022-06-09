using ApplicationCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CharacterCollectionContext context;

        public Repository(CharacterCollectionContext context)
        {
            this.context = context;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync<Tid>(Tid id) where Tid : notnull
        {
            return await context.Set<T>().FindAsync(new object[] { id });
        }

        public async Task<T> GetByNameAsync<Tname>(Tname name)
        {
            return await context.Set<T>().FindAsync(new object[] { name });
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteByIdAsync<Tid>(Tid id)
        {
            var toDelete = await context.Set<T>().FindAsync(new object[] { id });
            await DeleteAsync(toDelete);
        }

        public async Task DeleteAsync(T entity)
        {
            context.Remove(entity);
            await SaveChangesAsync();
        }
    }
}
