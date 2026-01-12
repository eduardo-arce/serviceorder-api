using SO.Shared.Util;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;

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
            var endpoint = context.GetEndpoint();

            if (endpoint?.Metadata.GetMetadata<IAllowAnonymous>() != null)
            {
                await _next(context);
                return;
            }

            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrWhiteSpace(token))
            {
                await Unauthorized(context, "Token not provided");
                return;
            }

            Result<UserEntity?> result = await validateUser.Validate(token);

            if (!result.IsSuccess || result.Content == null)
            {
                await Unauthorized(context, result.Message);
                return;
            }

            context.Items["User"] = result.Content;

            await _next(context);
        }

        private static async Task Unauthorized(
            HttpContext context,
            string message
        )
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            context.Response.ContentType = "application/json";

            var response = Result<object>.Unauthorized(
                message: message,
                content: null
            );

            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response)
            );
        }
    }
}
