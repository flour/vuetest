using System.Collections.Generic;
using System.Threading.Tasks;

namespace testvue.Services
{
    public interface IGenericRepo<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddOneAsync(T entity);
        Task UpdateOneAsync(T entity);

        Task RemoveByIdAsync(int id);
        Task<bool> SaveAsync();
    }
}