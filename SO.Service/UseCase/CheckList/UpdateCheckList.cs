using System.Security.Cryptography;
using SO.Domain.DTO.CheckList;
using SO.Domain.Entity;
using SO.Domain.IUseCase.CheckList;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.CheckList
{
    public class UpdateCheckList : IUpdateCheckList
    {
        private readonly ICheckListRepository _checkListRepository;

        public UpdateCheckList(ICheckListRepository checkListRepository)
        {
            _checkListRepository = checkListRepository;
        }

        public async Task<Result<CheckListEntity>> ExecuteAsync(CheckListUpdateInputDTO input)
        {
            CheckListEntity? user = await _checkListRepository.FindFirstOrDefaultAsync(x => x.Id == input.Id);

            if (user is null)
            {
                return Result<CheckListEntity>.NotFound(
                    null,
                    "checklist not found!!!"
                );
            }

            user.IsActive = input.IsActive;

            await _checkListRepository.UpdateAsync(user);

            return Result<CheckListEntity>.Ok(
                content: user,
                message: "checklist updated successfully!!!"
            );
        }
    }
}