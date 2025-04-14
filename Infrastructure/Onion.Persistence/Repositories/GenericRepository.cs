using Microsoft.EntityFrameworkCore;
using Onion.Application.Interfaces;
using Onion.Persistence.Context;

namespace Onion.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _appDbContext.AddAsync(entity);
           
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            _appDbContext.Remove(entity);
            
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _appDbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _appDbContext.Update(entity);
        }
    }
}
