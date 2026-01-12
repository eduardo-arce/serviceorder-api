using System.Linq;
using Microsoft.EntityFrameworkCore;
using Minio.DataModel;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Infra.Repository
{
    public class UserRepository(DatabaseContext context) : RepositoryBase<UserEntity>(context), IUserRepository
    {
        public async Task<PaginatedResult<UserListOutputDTO>?> GetAllByFilter(UserListFilterDTO input)
        {
            IQueryable<UserEntity> query = _context.User.AsQueryable();

            if (!string.IsNullOrEmpty(input.UserName))
            {
                query = query.Where(u => u.UserName.Contains(input.UserName));
            }

            if (!string.IsNullOrEmpty(input.Email))
            {
                query = query.Where(u => u.Email.Contains(input.Email));
            }

            if (input.IsActive.HasValue)
            {
                query = query.Where(u => u.IsActive == input.IsActive.Value);
            }

            if (input.IsAdmin.HasValue)
            {
                query = query.Where(u => u.IsAdmin == input.IsAdmin.Value);
            }

            int totalItems = await query.CountAsync();

            List<UserListOutputDTO> users = await query
                .OrderByDescending(u => u.CreatedAt)
                .Skip((input.Page - 1) * input.PageSize)
                .Take(input.PageSize)
                .Select(x => new UserListOutputDTO
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    IsAdmin = x.IsAdmin,
                    IsActive = x.IsActive
                })
                .ToListAsync();

            return new PaginatedResult<UserListOutputDTO>
            {
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling((double)totalItems / input.PageSize),
                CurrentPage = input.Page,
                PageSize = input.PageSize,
                Items = users
            };
        }
    }
}
