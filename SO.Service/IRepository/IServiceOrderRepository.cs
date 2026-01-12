using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Service.IRepository
{
    public interface IServiceOrderRepository : IRepositoryBase<ServiceOrderEntity>
    {
        Task<ServiceOrderEntity> GetFullServiceOrderById(string id);
    }
}
