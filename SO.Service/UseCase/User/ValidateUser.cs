using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;
using SO.Service.Adapter.Cryptography;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.User
{
    public class ValidateUser : IValidateUser
    {
        private readonly IToken _token;
        private readonly IUserRepository _userRepository;

        public ValidateUser(
            IToken token,
            IUserRepository userRepository
        )
        {
            _token = token;
            _userRepository = userRepository;
        }

        public async Task<Result<UserEntity?>> Validate(string? accessToken)
        {
            string? userId = _token.Decode(accessToken);

            if (userId == null)
            {
                return Result<UserEntity?>.Unauthorized(
                    message: "user unauthorized!!!",
                    content: null
                );
            }

            UserEntity? user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                return Result<UserEntity?>.Unauthorized(
                    message: "user not exist!!!",
                    content: null
                );
            }

            return Result<UserEntity?>.Ok(
                    message: "user validation success!!!",
                    content: user
                ); ;
        }
    }
}
