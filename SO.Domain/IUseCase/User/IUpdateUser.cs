using System.Threading.Tasks;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.User
{
    public interface IUpdateUser
    {
        Task<Result<UserEntity>> Password(UpdatePasswordInputDTO input, string userId);
        Task<Result<UserEntity>> ConfigUser(UpdateConfigUserInputDTO input);
    }
}