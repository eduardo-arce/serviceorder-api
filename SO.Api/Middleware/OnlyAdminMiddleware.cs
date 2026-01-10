using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SO.Domain.Entity;
using SO.Infra.Repository;
using SO.Service.IRepository.User;

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

            var userRepository = context.HttpContext.RequestServices.GetService<IGetUserByIdRepository>();

            if (userRepository == null)
            {
                context.Result = new StatusCodeResult(500);
                return;
            }

            var user = await userRepository.Get(userId);
            if (user == null || !user.IsAdmin)
            {
                context.Result = new ForbidResult();
                return;
            }

            await next();
        }

    }
}
