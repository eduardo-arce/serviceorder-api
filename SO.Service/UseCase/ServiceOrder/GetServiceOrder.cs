using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Minio.DataModel;
using SO.Domain.DTO.ServiceOrder;
using SO.Domain.Entity;
using SO.Domain.IUseCase.ServiceOrder;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.ServiceOrder
{
    public class GetServiceOrder : IGetServiceOrder
    {
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly string _bucket;

        public GetServiceOrder(IServiceOrderRepository serviceOrderRepository,
            IConfiguration configuration)
        {
            _serviceOrderRepository = serviceOrderRepository;
            _bucket = configuration["Minio:Bucket"];
        }

        public async Task<Result<ServiceOrderListingDTO>> GetById(string serviceOrderId)
        {
            ServiceOrderEntity? serviceOrder = await _serviceOrderRepository.GetFullServiceOrderById(serviceOrderId);

            if (serviceOrder == null)
            {
                return Result<ServiceOrderListingDTO>.NotFound(
                    content: null,
                    message: "service order not exist!!!"
                );
            }

            ServiceOrderListingDTO serviceOrderFull = new ServiceOrderListingDTO
            {
                Id = serviceOrder.Id,
                Description = serviceOrder.Description,
                CreatedAt = serviceOrder.CreatedAt,
                User = new ServiceOrderUserListingDTO
                {
                    Id = serviceOrder.UserEntity.Id,
                    Name = serviceOrder.UserEntity.UserName,
                    IsAdmin = serviceOrder.UserEntity.IsAdmin,
                    IsActive = serviceOrder.UserEntity.IsActive,
                },
                CheckList = serviceOrder.CheckListResults?.Select(x => new ServiceOrderCheckListResultListingDTO
                {
                    Id = x.Id,
                    Question = x.CheckListEntity?.Question,
                    IsOk = x.IsOk,
                }).ToList() ?? new List<ServiceOrderCheckListResultListingDTO>(),
                ImageList = serviceOrder.Images?.Select(x => new ServiceOrderImageListingDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Url = $"http://localhost:9000/{_bucket}/{x.HashName}",
                }).ToList() ?? new List<ServiceOrderImageListingDTO>()
            };

            return Result<ServiceOrderListingDTO>.Ok(
                content: serviceOrderFull,
                message: "service order searched!!!"
            );
        }

        public async Task<Result<PaginatedResult<ServiceOrderEntity>>> GetAll(ServiceOrderFilterInputDTO input)
        {
            PaginatedResult<ServiceOrderEntity>? serviceOrder = await _serviceOrderRepository.GetFilteredAsync(
                input.UserId is not null ? item => item.UserEntityId == input.UserId : null,
                input.Page,
                input.PageSize
            );

            return Result<PaginatedResult<ServiceOrderEntity>>.Ok(
                content: serviceOrder,
                message: "service order searched!!!"
            );
        }
    }
}
