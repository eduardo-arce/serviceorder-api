using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository.User;

namespace SO.Infra.Repository.User
{
    public class GetUserByIdRepository : IGetUserByIdRepository
    {
        private readonly DatabaseContext _dbContext;

        public GetUserByIdRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }   

        public async Task<UserEntity?> Get(string id)
        {
            UserEntity? user = await _dbContext.User.FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }
    }
}
