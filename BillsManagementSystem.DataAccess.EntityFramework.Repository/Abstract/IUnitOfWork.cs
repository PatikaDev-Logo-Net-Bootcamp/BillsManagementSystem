using BillsManagementSystem.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        AppDbContext Context { get; }

        void Commit();
    }
}
