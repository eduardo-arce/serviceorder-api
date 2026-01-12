using Microsoft.EntityFrameworkCore;
using SO.Domain.Entity;
using SO.Infra.Database;
using SO.Service.IRepository;

namespace SO.Infra.Repository
{
    public class ImageRepository(DatabaseContext context) : RepositoryBase<ImageEntity>(context), IImageRepository
    {
        
    }
}
