namespace SO.Service.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICheckListRepository CheckList { get; }
        ICheckListResultRepository CheckListResult { get; }
        IImageRepository Image { get; }
        IServiceOrderRepository ServiceOrder { get; }
        IUserRepository User { get; }

        Task SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
