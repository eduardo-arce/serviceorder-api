using SO.Domain.Entity;

namespace SO.Service.IRepository.User
{
    public interface IGetUserByEmailRepository
    {
        Task<UserEntity?> Get(string login);
    }
}