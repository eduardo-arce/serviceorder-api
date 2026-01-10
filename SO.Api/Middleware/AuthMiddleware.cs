using SO.Shared.Util;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;

namespace SO.Api.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(
            HttpContext context,
            IValidateUser validateUser
        )
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token is not null)
                await AttachUserToContext(context, validateUser, token);

            await _next(context);
        }

        private async Task AttachUserToContext(
            HttpContext context,
            IValidateUser validateUser,
            string token
        )
        {
            Result<UserEntity?> user = await validateUser.Validate(token);
            context.Items["User"] = user.Content;
        }
    }
}
