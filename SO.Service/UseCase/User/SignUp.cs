using System.Text.RegularExpressions;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;
using SO.Service.Adapter.Cryptography;
using SO.Service.Adapter.Validator;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.User
{
    public class SignUp : ISignUp
    {
        private IEmailValidator _emailValidator;
        private readonly IUserRepository _userRepository;
        private ICryptography _cryptography;

        public SignUp(
            IEmailValidator emailValidator,
            IUserRepository userRepository,
            ICryptography cryptography
        )
        {
            _emailValidator = emailValidator;
            _userRepository = userRepository;
            _cryptography = cryptography;
        }

        public async Task<Result<UserEntity>> Execute(SignUpInputDTO input)
        {
            bool emailIsValid = _emailValidator.Validate(input.Email);

            if (emailIsValid is false)
            {
                return Result<UserEntity>.OperationalError(
                    content: null,
                    message: "email is not valid!!!"
                );
            }

            bool isAlreadyInUse = await _userRepository.FindFirstOrDefaultAsync(
                item => item.Email == input.Email || item.UserName == input.UserName
             ) != null;

            if (isAlreadyInUse is true)
            {
                return Result<UserEntity>.OperationalError(
                    content: null,
                    message: "email already in use!!!"
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

            input.Password = hashedPassword;

            UserEntity newUser = new(
                userName: input.UserName,
                email: input.Email,
                password: input.Password,
                isAdmin: input.IsAdmin,
                isActive: true
            );

            await _userRepository.CreateAsync(newUser);

            newUser.Password = string.Empty;

            return Result<UserEntity>.Created(
                content: newUser,
                message: "user created!!!"
            );
        }
    }
}