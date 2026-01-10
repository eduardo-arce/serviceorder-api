using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SO.Api.Middleware;
using SO.Domain.DTO.User;
using SO.Domain.Entity;
using SO.Domain.IUseCase.User;
using SO.Shared.Util;

namespace SO.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ISignUp _signUp;
        private readonly ISignIn _signIn;

        public UserController(
            ISignUp signUp,
            ISignIn signIn
        )
        {
            _signUp = signUp;
            _signIn = signIn;
        }

        [HttpPost("signin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Result<SignInOutputDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Result<object>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(Result<object>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Result<object>))]
        public async Task<ActionResult<Result<UserEntity>>> SignIn([FromBody] SignInInputDTO input)
        {
            try
            {
                Result<SignInOutputDTO?> newUser = await _signIn.Execute(input);
                return StatusCode(GetHttpStatusCode.Get(newUser.Status), newUser);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }

        [OnlyAdmin]
        [HttpPost("signup")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Result<UserEntity>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Result<object>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Result<object>))]
        public async Task<ActionResult<Result<UserEntity>>> SignUp([FromBody] SignUpInputDTO input)
        {
            try
            {
                Result<UserEntity> newUser = await _signUp.Execute(input);
                return StatusCode(GetHttpStatusCode.Get(newUser.Status), newUser);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }

        
    }
}
