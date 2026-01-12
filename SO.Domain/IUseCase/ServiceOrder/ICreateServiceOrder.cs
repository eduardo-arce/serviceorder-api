using SO.Domain.DTO.ServiceOrder;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.ServiceOrder
{
    public interface ICreateServiceOrder
    {
        Task<Result<ServiceOrderEntity>> ExecuteAsync(ServiceOrderDTO input, string userId);
    }
}