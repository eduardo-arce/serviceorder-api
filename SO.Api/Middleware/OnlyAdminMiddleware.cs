using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SO.Service.IRepository;

namespace SO.Api.Middleware
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class OnlyAdminAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userId = context.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "id")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                context.Result = new ForbidResult();
                return;
            }

            var userRepository = context.HttpContext.RequestServices.GetService<IUserRepository>();

            if (userRepository == null)
            {
                context.Result = new ForbidResult();
                return;
            }

            var user = await userRepository.GetByIdAsync(userId);
            if (user == null || !user.IsAdmin)
            {
                context.Result = new ForbidResult();
                return;
            }

            await next();
        }

    }
}
