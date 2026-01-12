using SO.Api.Middleware;
using SO.Api.Dependence.Shared;
using SO.Api.Dependence.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

AuthenticationDependece.Initialize(builder);
SwaggerDependece.Initialize(builder);
DatabaseDependence.Initialize(builder);
StorageDependence.Initialize(builder);
UserDependence.Initialize(builder);

var app = builder.Build();

ConfigureSwagger.Initialize(app);
ExecuteMigration.Initialize(app);

app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware<AuthMiddleware>();

app.MapControllers();

app.Run();