using SO.Domain.Entity;

namespace SO.Service.IRepository.User
{
    public interface ISaveUserRepository
    {
        Task Save(UserEntity input);
    }
}