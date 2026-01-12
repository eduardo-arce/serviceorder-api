using System.Security.Cryptography;
using SO.Domain.DTO.CheckList;
using SO.Domain.Entity;
using SO.Domain.IUseCase.CheckList;
using SO.Service.IRepository;
using SO.Shared.Util;

namespace SO.Service.UseCase.CheckList
{
    public class CreateCheckList : ICreateCheckList
    {
        private readonly ICheckListRepository _checkListRepository;

        public CreateCheckList(ICheckListRepository checkListRepository)
        {
            _checkListRepository = checkListRepository;
        }

        public async Task<Result<CheckListEntity>> ExecuteAsync(CheckListDTO input)
        {
            CheckListEntity? user = await _checkListRepository.FindFirstOrDefaultAsync(
                item => item.Question == input.Question
            );

            if (user is not null)
            {
                return Result<CheckListEntity>.OperationalError(
                    null,
                    "checklist already registered!!!"
                );
            }

            CheckListEntity newUser = new
            (
                question: input.Question,
                isActive: true
            );

            await _checkListRepository.CreateAsync(newUser);

            return Result<CheckListEntity>.Created(
                content: newUser,
                message: "checklist created!!!"
            );
        }
    }
}