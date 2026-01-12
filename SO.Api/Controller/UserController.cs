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
        private readonly IGetUser _getUser;
        private readonly IUpdateUser _updateUser;

        public UserController(
            ISignUp signUp,
            ISignIn signIn,
            IGetUser getUser,
            IUpdateUser updateUser
        )
        {
            _signUp = signUp;
            _signIn = signIn;
            _getUser = getUser;
            _updateUser = updateUser;
        }

        [AllowAnonymous]
        [HttpPost("SignIn")]  
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
        [HttpPost]
        public async Task<ActionResult<Result<UserEntity>>> Create([FromBody] SignUpInputDTO input)
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

        [OnlyAdmin]
        [HttpGet]
        public async Task<ActionResult<Result<PaginatedResult<UserListOutputDTO>>>> GetAll([FromQuery] UserListFilterDTO input)
        {
            try
            {
                Result<PaginatedResult<UserListOutputDTO>> users = await _getUser.GetAllUsers(input);
                return StatusCode(GetHttpStatusCode.Get(users.Status), users);
            }
            catch (Exception exc)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    Result<object>.InternalError(message: exc.Message, content: null)
                );
            }
        }

        [HttpPut("Password")]
        public async Task<ActionResult<Result<PaginatedResult<UserListOutputDTO>>>> UpdatePassword([FromBody] UpdatePasswordInputDTO input)
        {
            try
            {
                var userToken = HttpContext.Items["User"] as UserEntity;
                Result<UserEntity> user = await _updateUser.Password(input, userToken.Id);
                return StatusCode(GetHttpStatusCode.Get(user.Status), user);
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
        [HttpPut("Config")]
        public async Task<ActionResult<Result<UserEntity>>> UpdateUserConfig([FromBody] UpdateConfigUserInputDTO input)
        {
            try
            {
                Result<UserEntity> user = await _updateUser.ConfigUser(input);
                return StatusCode(GetHttpStatusCode.Get(user.Status), user);
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
