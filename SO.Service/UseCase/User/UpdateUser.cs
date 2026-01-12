using System.Text.RegularExpressions;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;
using SO.Service.Adapter.Cryptography;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.User
{
    public class UpdateUser : IUpdateUser
    {
        private readonly IUserRepository _userRepository;
        private ICryptography _cryptography;

        public UpdateUser(
            IUserRepository userRepository,
            ICryptography cryptography
        )
        {
            _userRepository = userRepository;
            _cryptography = cryptography;
        }

        public async Task<Result<UserEntity>> Password(UpdatePasswordInputDTO input, string userId)
        {
            UserEntity? user = await _userRepository.GetByIdAsync(userId);

            if (user is null)
            {
                return Result<UserEntity>.NotFound(
                    content: null,
                    message: "user not found!!!"
                );
            }

            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input.Password) is not true)
            {
                return Result<UserEntity>.OperationalError(
                    content: null,
                    message: "password length must be higher than 8 and contain letters and numbers!!!"
                );
            }

            string hashedPassword = _cryptography.Hash(input.Password);

            user.Password = hashedPassword;
            user.Update();

            await _userRepository.UpdateAsync(user);

            user.Password = string.Empty;

            return Result<UserEntity>.Ok(
                content: user,
                message: "user updated!!!"
            );
        }

        public async Task<Result<UserEntity>> ConfigUser(UpdateConfigUserInputDTO input)
        {
            UserEntity? user = await _userRepository.GetByIdAsync(input.Id);

            if (user is null)
            {
                return Result<UserEntity>.NotFound(
                    content: null,
                    message: "user not found!!!"
                );
            }

            user.IsActive = input.IsActive;
            user.IsAdmin = input.IsAdmin;
            user.Update();

            await _userRepository.UpdateAsync(user);

            user.Password = string.Empty;

            return Result<UserEntity>.Ok(
                content: user,
                message: "user updated!!!"
            );
        }
    }
}