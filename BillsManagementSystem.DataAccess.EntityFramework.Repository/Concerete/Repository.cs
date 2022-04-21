using BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract;
using BillsManagementSystem.Model.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BillsManagementSystem.DataAccess.EntityFramework.Repository.Concerete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly IUnitOfWork unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            unitOfWork.Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            T exist = unitOfWork.Context.Set<T>().Find(entity.Id);
            if (exist != null)
            {
                exist.IsDeleted = true;
                unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            T exist = unitOfWork.Context.Set<T>().Find(id);
            if (exist != null)
            {
                exist.IsDeleted = true;
                unitOfWork.Context.Remove(id);
            }
        }

        public IQueryable<T> GetAll()
        {
            return unitOfWork.Context.Set<T>().Where(x => !x.IsDeleted).AsQueryable();
        }

        public T GetById(int id)
        {
            return unitOfWork.Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
