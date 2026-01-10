using Microsoft.EntityFrameworkCore;
using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository.User;

namespace SO.Infra.Repository.User
{
    public class GetUserByEmailRepository : IGetUserByEmailRepository
    {
        private readonly DatabaseContext _dbContext;

        public GetUserByEmailRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserEntity?> Get(string login)
        {
            UserEntity? user = await _dbContext.User.FirstOrDefaultAsync(x => x.Email == login ||
                x.UserName == login);

            return user;
        }
    }
}