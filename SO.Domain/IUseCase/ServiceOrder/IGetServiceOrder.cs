using SO.Domain.DTO.ServiceOrder;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.ServiceOrder
{
    public interface IGetServiceOrder
    {
        Task<Result<ServiceOrderListingDTO>> GetById(string serviceOrderId);
        Task<Result<PaginatedResult<ServiceOrderEntity>>> GetAll(ServiceOrderFilterInputDTO input);
    }
}