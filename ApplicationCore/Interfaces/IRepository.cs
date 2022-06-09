using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public interface IRepository<T> where T : class
    {
        Task<int> SaveChangesAsync();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync<Tid>(Tid id) where Tid : notnull;
        Task<T> GetByNameAsync<Tname>(Tname tname);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteByIdAsync<Tid>(Tid id);
        
    }
}
