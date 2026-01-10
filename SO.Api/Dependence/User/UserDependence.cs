using SO.Domain.IUseCase.User;
using SO.Infra.Adapter.Cryptography;
using SO.Infra.Adapter.Validator;
using SO.Infra.Repository.User;
using SO.Service.Adapter.Cryptography;
using SO.Service.Adapter.Validator;
using SO.Service.IRepository.User;
using SO.Service.UseCase.User;

namespace SO.Api.Dependence.User
{
    public class UserDependence
    {
        public static void Initialize(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IEmailValidator, EmailValidator>();
            builder.Services.AddTransient<ICheckEmailRepository, CheckEmailRepository>();
            builder.Services.AddTransient<ICryptography, BcryptAdapter>();
            builder.Services.AddTransient<ISaveUserRepository, SaveUserRepository>();
            builder.Services.AddTransient<ICheckUserRepository, CheckUserRepository>();
            builder.Services.AddTransient<IGetUserByEmailRepository, GetUserByEmailRepository>();
            builder.Services.AddTransient<IGetUserByIdRepository, GetUserByIdRepository>();
            builder.Services.AddTransient<IToken, JwtAdapter>();
            builder.Services.AddTransient<ISignUp, SignUp>();
            builder.Services.AddTransient<ISignIn, SignIn>();
            builder.Services.AddTransient<IValidateUser, ValidateUser>();
        }
    }
}
