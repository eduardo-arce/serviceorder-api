using SO.Domain.DTO.User;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.User
{
    public interface ISignIn
    {
        Task<Result<SignInOutputDTO?>> Execute(SignInInputDTO input);
    }
}