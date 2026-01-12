using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SO.Api.Middleware;
using SO.Domain.DTO.CheckList;
using SO.Domain.Entity;
using SO.Domain.IUseCase.CheckList;
using SO.Shared.Util;

namespace SO.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckListController : ControllerBase
    {
        private readonly ICreateCheckList _createCheckList;
        private readonly IGetCheckList _getCheckList;
        private readonly IUpdateCheckList _updateCheckList;

        public CheckListController(
            ICreateCheckList createCheckList,
            IGetCheckList getCheckList,
            IUpdateCheckList updateCheckList
        )
        {
            _createCheckList = createCheckList;
            _getCheckList = getCheckList;
            _updateCheckList = updateCheckList;
        }


        [OnlyAdmin]
        [HttpPost]
        public async Task<ActionResult<Result<CheckListEntity>>> Create([FromBody] CheckListDTO input)
        {
            try
            {
                Result<CheckListEntity> newCheckList = await _createCheckList.ExecuteAsync(input);
                return StatusCode(GetHttpStatusCode.Get(newCheckList.Status), newCheckList);
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
        public async Task<ActionResult<Result<PaginatedResult<CheckListEntity>>>> GetAll([FromQuery] CheckListFilterInputDTO input)
        {
            try
            {
                Result<PaginatedResult<CheckListEntity>> checkLists = await _getCheckList.GetAllAsync(input);
                return StatusCode(GetHttpStatusCode.Get(checkLists.Status), checkLists);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }

        [OnlyAdmin]
        [HttpPut]
        public async Task<ActionResult<Result<CheckListEntity>>> Update([FromBody] CheckListUpdateInputDTO input)
        {
            try
            {
                Result<CheckListEntity> updatedCheckList = await _updateCheckList.ExecuteAsync(input);
                return StatusCode(GetHttpStatusCode.Get(updatedCheckList.Status), updatedCheckList);
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
