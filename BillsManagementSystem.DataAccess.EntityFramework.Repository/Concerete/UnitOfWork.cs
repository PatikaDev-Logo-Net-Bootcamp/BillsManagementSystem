using BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract;

namespace BillsManagementSystem.DataAccess.EntityFramework.Repository.Concerete
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext Context { get; }
        public UnitOfWork(AppDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
