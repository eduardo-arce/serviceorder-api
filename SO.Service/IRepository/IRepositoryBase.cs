using System.Linq.Expressions;
using SO.Shared.Util;

namespace SO.Service.IRepository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<PaginatedResult<T>> GetAllAsync(int page = 1, int PageSize = 10);
        Task<T?> GetByIdAsync(string id);
        Task CreateAsync(T entity);
        void Create(T entity);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        Task DeleteAsync(T entity);
        void Delete(T entity);
        Task<T?> FindFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<PaginatedResult<T>> GetFilteredAsync(Expression<Func<T, bool>>? predicate, int page = 1, int pageSize = 10);
    }
}
