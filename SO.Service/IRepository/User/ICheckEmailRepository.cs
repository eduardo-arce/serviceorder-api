namespace SO.Service.IRepository.User
{
    public interface ICheckEmailRepository
    {
        Task<bool> Check(string email);
    }
}