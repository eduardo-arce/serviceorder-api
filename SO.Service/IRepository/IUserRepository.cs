using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Service.IRepository
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        Task<PaginatedResult<UserListOutputDTO>?> GetAllByFilter(UserListFilterDTO input);
    }
}
