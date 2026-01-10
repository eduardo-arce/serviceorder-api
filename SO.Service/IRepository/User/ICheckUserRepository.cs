namespace SO.Service.IRepository.User
{
    public interface ICheckUserRepository
    {
        Task<bool> UserExist(string userId);
    }
}