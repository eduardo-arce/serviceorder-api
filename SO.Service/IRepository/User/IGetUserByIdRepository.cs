using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SO.Domain.Entity;

namespace SO.Service.IRepository.User
{
    public interface IGetUserByIdRepository
    {
        Task<UserEntity?> Get(string id);
    }
}
