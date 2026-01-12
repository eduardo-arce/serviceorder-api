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
    public class GetUser : IGetUser
    {
        private readonly IUserRepository _userRepository;

        public GetUser(
            IUserRepository userRepository
        )
        {
            _userRepository = userRepository;
        }        

        public async Task<Result<PaginatedResult<UserListOutputDTO>>> GetAllUsers(UserListFilterDTO input)
        {
            var users = await _userRepository.GetAllByFilter(input);

            return Result<PaginatedResult<UserListOutputDTO>>.Ok(
                content: users,
                message: "users searched!!!"
            );
        }
    }
}