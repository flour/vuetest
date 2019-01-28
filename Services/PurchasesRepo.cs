using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testvue.Models;

namespace testvue.Services
{
    public interface IPurchasesRepo : IGenericRepo<Purchase>
    {

    }

    public class PurchasesRepo : IPurchasesRepo
    {
        private readonly AppDBContext _context;

        public PurchasesRepo(AppDBContext context)
        {
            _context = context;
        }

        public async Task AddOneAsync(Purchase entity)
        {
            await _context.Purchases.AddAsync(entity);
        }

        public async Task RemoveByIdAsync(int id)
        {
            var entity = await this.GetByIdAsync(id);
            _context.Purchases.Remove(entity);
        }

        public async Task<List<Purchase>> GetAllAsync()
        {
            return await _context.Purchases.ToListAsync();
        }

        public async Task<Purchase> GetByIdAsync(int id)
        {
            return await _context.Purchases.SingleAsync(e => e.ID == id);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public async Task UpdateOneAsync(Purchase entity)
        {
            await Task.CompletedTask;
            _context.Purchases.Update(entity);
        }
    }
}