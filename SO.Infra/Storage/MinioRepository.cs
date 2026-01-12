using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Minio;
using Minio.DataModel.Args;
using SO.Service.Storage;

namespace SO.Infra.Storage
{
    public sealed class MinioRepository : IMinioRepository
    {
        private readonly IMinioClient _minioClient;
        private readonly string _bucket;

        public MinioRepository(
            IMinioClient minioClient,
            IConfiguration configuration
        )
        {
            _minioClient = minioClient;

            _bucket = configuration["Minio:Bucket"]
                ?? throw new InvalidOperationException("Minio:Bucket não configurado.");
        }

        public async Task UploadAsync(IEnumerable<IFormFile> files)
        {
            await EnsureBucketExistsAsync();

            foreach (var file in files)
            {
                var allowed = new[] { "image/jpeg", "image/png", "image/webp" };
                if (!allowed.Contains(file.ContentType))
                    throw new InvalidOperationException("Formato não permitido");

                if (file.Length > 5 * 1024 * 1024)
                    throw new InvalidOperationException("Imagem maior que 5MB");

                var safeName = $"{Guid.NewGuid()}";

                using var stream = file.OpenReadStream();

                await _minioClient.PutObjectAsync(
                    new PutObjectArgs()
                        .WithBucket(_bucket)
                        .WithObject(safeName)
                        .WithStreamData(stream)
                        .WithObjectSize(file.Length)
                        .WithContentType(file.ContentType)
                );
            }
        }

        private async Task EnsureBucketExistsAsync()
        {
            var exists = await _minioClient.BucketExistsAsync(
                new BucketExistsArgs().WithBucket(_bucket)
            );

            if (!exists)
            {
                await _minioClient.MakeBucketAsync(
                    new MakeBucketArgs().WithBucket(_bucket)
                );
            }
        }
    }
}
