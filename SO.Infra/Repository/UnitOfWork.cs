using Microsoft.EntityFrameworkCore.Storage;
using SO.Infra.Database;
using SO.Service.IRepository;

namespace SO.Infra.Repository
{
    public class UnitOfWork(
        IServiceOrderRepository serviceOrder,
        ICheckListRepository checkList,
        ICheckListResultRepository checkListResult,
        IImageRepository image,
        IUserRepository user,
        DatabaseContext context
    ) : IUnitOfWork
    {
        private readonly DatabaseContext _context = context;
        private IDbContextTransaction? _transaction;
        public ICheckListRepository CheckList { get; } = checkList;
        public ICheckListResultRepository CheckListResult { get; } = checkListResult;
        public IImageRepository Image { get; } = image;
        public IServiceOrderRepository ServiceOrder { get; } = serviceOrder;
        public IUserRepository User { get; } = user;

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
