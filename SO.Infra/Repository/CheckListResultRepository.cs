using Microsoft.EntityFrameworkCore;
using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository;

namespace SO.Infra.Repository
{
    public class CheckListResultRepository(DatabaseContext context) : RepositoryBase<CheckListResultEntity>(context), ICheckListResultRepository
    {
        
    }
}
