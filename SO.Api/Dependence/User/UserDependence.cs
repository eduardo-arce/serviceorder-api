using SO.Domain.IUseCase.CheckList;
using SO.Domain.IUseCase.ServiceOrder;
using SO.Domain.IUseCase.User;
using SO.Infra.Adapter.Cryptography;
using SO.Infra.Adapter.Validator;
using SO.Infra.Repository;
using SO.Service.Adapter.Cryptography;
using SO.Service.Adapter.Validator;
using SO.Service.IRepository;
using SO.Service.UseCase.CheckList;
using SO.Service.UseCase.ServiceOrder;
using SO.Service.UseCase.User;

namespace SO.Api.Dependence.User
{
    public class UserDependence
    {
        public static void Initialize(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ICheckListRepository, CheckListRepository>();
            builder.Services.AddTransient<ICheckListResultRepository, CheckListResultRepository>();
            builder.Services.AddTransient<IImageRepository, ImageRepository>();
            builder.Services.AddTransient<IServiceOrderRepository, ServiceOrderRepository>();
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IEmailValidator, EmailValidator>();
            builder.Services.AddTransient<ICryptography, BcryptAdapter>();
            builder.Services.AddTransient<IToken, JwtAdapter>();
            builder.Services.AddTransient<ISignUp, SignUp>();
            builder.Services.AddTransient<ISignIn, SignIn>();
            builder.Services.AddTransient<IValidateUser, ValidateUser>();
            builder.Services.AddTransient<IGetUser, GetUser>();
            builder.Services.AddTransient<IUpdateUser, UpdateUser>();
            builder.Services.AddTransient<IGetCheckList, GetCheckList>();
            builder.Services.AddTransient<ICreateCheckList, CreateCheckList>();
            builder.Services.AddTransient<IUpdateCheckList, UpdateCheckList>();
            builder.Services.AddTransient<ICreateServiceOrder, CreateServiceOrder>();
            builder.Services.AddTransient<IGetServiceOrder, GetServiceOrder>();
        }
    }
}
