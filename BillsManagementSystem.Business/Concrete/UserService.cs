using BillsManagementSystem.Business.Abstract;
using BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract;
using BillsManagementSystem.Model.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BillsManagementSystem.Business.Concrete
{
    public class UserService :IUserService
    {

        private readonly IRepository<User> repository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IRepository<User> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }


        public void AddUser(User user)
        {
            repository.Add(user);
            unitOfWork.Commit();
        }

        public void DeleteUser(User user)
        {
            repository.Delete(user);
            unitOfWork.Commit();
        }

        public void DeleteUser(int id)
        {
            repository.Delete(id);
            unitOfWork.Commit();
        }

        public List<User> GetAllUser()
        {
            return repository.GetAll().ToList();
        }

        public User GetUserById(int id)
        {
            return repository.GetById(id);
        }

        public void UpdateUser(User user)
        {
            repository.Update(user);
        }
    }
}
