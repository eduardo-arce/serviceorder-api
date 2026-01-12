using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.User
{
    public interface IGetUser
    {
        Task<Result<PaginatedResult<UserListOutputDTO>>> GetAllUsers(UserListFilterDTO input);
    }
}
