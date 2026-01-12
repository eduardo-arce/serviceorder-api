using System.Security.Cryptography;
using SO.Domain.DTO.CheckList;
using SO.Domain.Entity;
using SO.Domain.IUseCase.CheckList;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.CheckList
{
    public class GetCheckList : IGetCheckList
    {
        private readonly ICheckListRepository _checkListRepository;

        public GetCheckList(ICheckListRepository checkListRepository)
        {
            _checkListRepository = checkListRepository;
        }

        public async Task<Result<PaginatedResult<CheckListEntity>>> GetAllAsync(CheckListFilterInputDTO input)
        {
            var checkListAll = await _checkListRepository.GetFilteredAsync(
                input.IsActive is not null ? item => item.IsActive == input.IsActive : null,
                input.Page,
                input.PageSize
            );

            return Result<PaginatedResult<CheckListEntity>>.Ok(
                content: checkListAll,
                message: "checklist created!!!"
            );
        }
    }
}