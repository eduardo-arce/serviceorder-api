using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SO.Api.Middleware;
using SO.Domain.DTO.ServiceOrder;
using SO.Domain.Entity;
using SO.Domain.IUseCase.ServiceOrder;
using SO.Shared.Util;

namespace SO.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceOrderController : ControllerBase
    {
        private readonly ICreateServiceOrder _createServiceOrder;
        private readonly IGetServiceOrder _getServiceOrder;

        public ServiceOrderController(
            ICreateServiceOrder createServiceOrder,
            IGetServiceOrder getServiceOrder
        )
        {
            _createServiceOrder = createServiceOrder;
            _getServiceOrder = getServiceOrder;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult<Result<ServiceOrderEntity>>> Create([FromForm] ServiceOrderDTO input)
        {
            try
            {
                var userToken = HttpContext.Items["User"] as UserEntity;
                Result<ServiceOrderEntity> newServiceOrder = await _createServiceOrder.ExecuteAsync(input, userToken.Id);
                return StatusCode(GetHttpStatusCode.Get(newServiceOrder.Status), newServiceOrder);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }

        [HttpGet]
        public async Task<ActionResult<Result<PaginatedResult<ServiceOrderEntity>>>> GetAll([FromQuery] ServiceOrderFilterInputDTO input)
        {
            try
            {
                Result<PaginatedResult<ServiceOrderEntity>> updatedServiceOrder = await _getServiceOrder.GetAll(input);
                return StatusCode(GetHttpStatusCode.Get(updatedServiceOrder.Status), updatedServiceOrder);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }

        [HttpGet("ById/{serviceOrderId}")]
        public async Task<ActionResult<Result<ServiceOrderListingDTO>>> GetById([FromRoute] string serviceOrderId)
        {
            try
            {
                Result<ServiceOrderListingDTO> serviceOrder = await _getServiceOrder.GetById(serviceOrderId);
                return StatusCode(GetHttpStatusCode.Get(serviceOrder.Status), serviceOrder);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }


    }
}
