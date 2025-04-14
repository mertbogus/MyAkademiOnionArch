namespace Onion.Application.Interfaces
{
    public  interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        Task DeleteAsync(Guid id);
    }
}
