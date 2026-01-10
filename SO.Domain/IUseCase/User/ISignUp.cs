using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.User
{
    public interface ISignUp
    {
        Task<Result<UserEntity>> Execute(SignUpInputDTO input);
    }
}