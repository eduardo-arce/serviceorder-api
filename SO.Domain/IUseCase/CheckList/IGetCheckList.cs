using SO.Domain.DTO.CheckList;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.CheckList
{
    public interface IGetCheckList
    {
        Task<Result<PaginatedResult<CheckListEntity>>> GetAllAsync(CheckListFilterInputDTO input);
    }
}