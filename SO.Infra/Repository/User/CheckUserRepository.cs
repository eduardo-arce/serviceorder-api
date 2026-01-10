using Microsoft.EntityFrameworkCore;
using SO.Infra.Database;
using SO.Service.IRepository.User;

namespace SO.Infra.Repository.User
{
    public class CheckUserRepository : ICheckUserRepository
    {
        private readonly DatabaseContext _dbContext;

        public CheckUserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> UserExist(string userId)
        {
            var user = await _dbContext.User.FirstOrDefaultAsync(x => x.Id == userId
                && x.IsActive);

            if (user == null)
                return false;

            return true;
        }
    }
}