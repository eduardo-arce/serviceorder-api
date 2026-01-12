using SO.Domain.DTO.CheckList;
using SO.Domain.Entity;
using SO.Shared.Util;

namespace SO.Domain.IUseCase.CheckList
{
    public interface ICreateCheckList
    {
        Task<Result<CheckListEntity>> ExecuteAsync(CheckListDTO input);
    }
}