using Microsoft.EntityFrameworkCore;
using SO.Infra.Database;
using SO.Service.IRepository.User;

namespace SO.Infra.Repository.User
{
    public class CheckEmailRepository : ICheckEmailRepository
    {
        private readonly DatabaseContext _dbContext;

        public CheckEmailRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Check(string email)
        {
            var user = await _dbContext.User.FirstOrDefaultAsync(user => user.Email == email);

            return user != null;
        }
    }
}