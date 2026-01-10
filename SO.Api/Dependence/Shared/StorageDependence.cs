using Minio;
using SO.Infra.Repository.Storage;
using SO.Service.IRepository.Storage;

namespace SO.Api.Dependence.Shared
{
    public static class StorageDependence
    {
        public static void Initialize(WebApplicationBuilder builder)
        {
            var minioSection = builder.Configuration.GetSection("Minio");

            if (!minioSection.Exists())
                throw new InvalidOperationException("Configuração do MinIO não encontrada.");

            var endpoint = minioSection["Endpoint"]
                ?? throw new InvalidOperationException("Minio:Endpoint não configurado.");

            var accessKey = minioSection["AccessKey"]
                ?? throw new InvalidOperationException("Minio:AccessKey não configurado.");

            var secretKey = minioSection["SecretKey"]
                ?? throw new InvalidOperationException("Minio:SecretKey não configurado.");

            var uri = new Uri(endpoint);

            builder.Services.AddSingleton<IMinioClient>(_ =>
                new MinioClient()
                    .WithEndpoint(uri.Host, uri.Port)
                    .WithCredentials(accessKey, secretKey)
                    .WithSSL(uri.Scheme == Uri.UriSchemeHttps)
                    .Build()
            );

            builder.Services.AddScoped<IMinioRepository, MinioRepository>();
        }
    }
}
