using BillsManagementSystem.Model.Entities.Concrete;
using System.Collections.Generic;

namespace BillsManagementSystem.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUser();

        User GetUserById(int id);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);

        void DeleteUser(int id);
    }
}
