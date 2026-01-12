using Microsoft.EntityFrameworkCore;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Infra.Repository
{
    public class ServiceOrderRepository(DatabaseContext context) : RepositoryBase<ServiceOrderEntity>(context), IServiceOrderRepository
    {

        public async Task<ServiceOrderEntity?> GetFullServiceOrderById(string id)
        {
            ServiceOrderEntity? serviceOrder = await _context.ServiceOrder
                .Include(x => x.CheckListResults)
                .ThenInclude(x => x.CheckListEntity)
                .Include(x => x.Images)
                .Include(x => x.UserEntity)
                .FirstOrDefaultAsync(x => x.Id == id);

            return serviceOrder;
        }

    }
}
