using BillsManagementSystem.Model.Base;
using System.Linq;

namespace BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}