using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SO.Domain.Entity;
using SO.Shared.Util;


namespace SO.Domain.IUseCase.User
{
    public interface IValidateUser
    {
        Task<Result<UserEntity?>> Validate(string? accessToken);
    }
}
