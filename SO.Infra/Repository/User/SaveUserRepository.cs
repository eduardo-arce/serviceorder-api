using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository.User;

namespace SO.Infra.Repository.User
{
    public class SaveUserRepository : ISaveUserRepository
    {
        private readonly DatabaseContext _dbContext;

        public SaveUserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Save(UserEntity input)
        {
            _dbContext.User.Add(input);
            await _dbContext.SaveChangesAsync();
        }
    }
}