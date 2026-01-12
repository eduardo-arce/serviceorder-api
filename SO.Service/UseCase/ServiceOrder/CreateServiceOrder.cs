using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SO.Domain.DTO.CheckList;
using SO.Domain.DTO.ServiceOrder;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Domain.IUseCase.ServiceOrder;
using SO.Service.IRepository;
using SO.Service.Storage;
using SO.Shared.Util;

namespace SO.Service.UseCase.ServiceOrder
{
    public class CreateServiceOrder : ICreateServiceOrder
    {
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMinioRepository _minioRepository;

        public CreateServiceOrder(IServiceOrderRepository serviceOrderRepository,
            IMinioRepository minioRepository)
        {
            _serviceOrderRepository = serviceOrderRepository;
            _minioRepository = minioRepository;
        }

        public async Task<Result<ServiceOrderEntity>> ExecuteAsync(ServiceOrderDTO input, string userId)
        {
            var newServiceOrder = new ServiceOrderEntity(
                description: input.Description,
                userEntityId: userId
            );

            foreach (var item in input.CheckListResults)
            {
                newServiceOrder.CheckListResults.Add(
                    new CheckListResultEntity(
                        checkListId: item.CheckListId,
                        serviceOrderId: newServiceOrder.Id,
                        isOk: item.IsOk
                    )
                );
            }

            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName);
                newServiceOrder.Images.Add(
                    new ImageEntity(
                        name: image.Name,
                        serviceOrderId: newServiceOrder.Id
                    )
                );
            }

            await _minioRepository.UploadAsync(input.Images);

            await _serviceOrderRepository.CreateAsync(newServiceOrder);

            return Result<ServiceOrderEntity>.Created(
                content: newServiceOrder,
                message: "service order created!!!"
            );
        }
    }
}
