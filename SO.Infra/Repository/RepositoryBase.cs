using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SO.Infra.Database;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Infra.Repository
{
    public class RepositoryBase<T>(DatabaseContext context) : IRepositoryBase<T> where T : class
    {
        protected readonly DatabaseContext _context = context;
        private readonly DbSet<T> _dbSet = context.Set<T>();

        public async Task CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return _context.SaveChangesAsync();
        }

        public async Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet
                .Where(predicate)
                .ToListAsync();
        }

        public async Task<T?> FindFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet
                .FirstOrDefaultAsync(predicate);
        }

        public async Task<PaginatedResult<T>> GetAllAsync(int page = 1, int PageSize = 10)
        {
            var items = await _dbSet.ToListAsync();

            if (page > 0 && PageSize > 0)
                items = [.. items
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)];

            var totalItems = items.Count;

            return new()
            {
                Items = items,
                TotalItems = totalItems,
                CurrentPage = page,
                TotalPages = page > 0 && PageSize > 0
                    ? (int)Math.Ceiling((double)totalItems / PageSize)
                    : 1,
                PageSize = PageSize
            };
        }

        public async Task<T?> GetByIdAsync(string id)
        {
            return await _dbSet.FindAsync(id).AsTask();
        }

        public async Task<PaginatedResult<T>> GetFilteredAsync(Expression<Func<T, bool>>? predicate, int page = 1, int pageSize = 10)
        {
            IQueryable<T> query = _dbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            var items = await query
                .ToListAsync();

            if (page > 0 && pageSize > 0)
            {
                items = [.. items
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)];
            }

            var totalItems = items.Count;
            return new()
            {
                Items = items,
                TotalItems = totalItems,
                CurrentPage = page,
                TotalPages = page > 0 && pageSize > 0
                    ? (int)Math.Ceiling((double)totalItems / pageSize)
                    : 1,
                PageSize = pageSize
            };
        }

        public Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }
    }
}
