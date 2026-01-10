using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;
using SO.Service.Adapter.Cryptography;
using SO.Service.IRepository.User;
using SO.Shared.Util;

namespace SO.Service.UseCase.User
{
    public class SignIn : ISignIn
    {
        private readonly IGetUserByEmailRepository _getUser;
        private ICryptography _cryptography;
        private readonly IToken _token;

        public SignIn(
            IGetUserByEmailRepository getUser,
            ICryptography cryptography,
            IToken token
        )
        {
            _getUser = getUser;
            _cryptography = cryptography;
            _token = token;
        }

        public async Task<Result<SignInOutputDTO?>> Execute(SignInInputDTO input)
        {
            UserEntity? user = await _getUser.Get(input.Login);

            if (user is null)
            {
                return Result<SignInOutputDTO?>.OperationalError(
                    null,
                    "login or password incorrect!!!"
                );
            }

            if (!user.IsActive)
            {
                return Result<SignInOutputDTO?>.Unauthorized(
                    null,
                    "user blocked!!!"
                );
            }

            bool isPasswordCorrect = _cryptography.Compare(input.Password, user.Password);

            if (isPasswordCorrect is false)
            {
                return Result<SignInOutputDTO?>.OperationalError(
                    null,
                    "login or password incorrect!!!"
                );
            }

            string acessToken = _token.Generate(user.Id);

            SignInOutputDTO signInResult = new()
            {
                Id = user.Id,
                UserName = user.UserName,
                IsAdmin = user.IsAdmin,
                AccessToken = acessToken
            };

            return Result<SignInOutputDTO?>.Ok(signInResult, "signIn success!!!");
        }
    }
}