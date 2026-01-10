using Microsoft.Extensions.Configuration;
using Minio;
using Minio.DataModel.Args;
using SO.Service.IRepository.Storage;

namespace SO.Infra.Repository.Storage
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

        public async Task UploadAsync(
            Stream file,
            long fileSize,
            string fileName,
            string contentType
        )
        {
            var bucketExists = await _minioClient.BucketExistsAsync(
                new BucketExistsArgs()
                    .WithBucket(_bucket)
            );

            if (!bucketExists)
            {
                await _minioClient.MakeBucketAsync(
                    new MakeBucketArgs()
                        .WithBucket(_bucket)
                );
            }

            await _minioClient.PutObjectAsync(
                new PutObjectArgs()
                    .WithBucket(_bucket)
                    .WithObject(fileName)
                    .WithStreamData(file)
                    .WithObjectSize(fileSize)
                    .WithContentType(contentType)
            );
        }
    }
}
