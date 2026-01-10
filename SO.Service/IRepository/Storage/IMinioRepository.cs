using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Service.IRepository.Storage
{
    public interface IMinioRepository
    {
        Task UploadAsync(
            Stream file,
            long fileSize,
            string fileName,
            string contentType
        );
    }
}
