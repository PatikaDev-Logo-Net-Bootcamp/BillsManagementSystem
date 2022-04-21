using BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract;
using BillsManagementSystem.Model.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BillsManagementSystem.Business.Concrete
{
    public class BillService
    {
        private readonly IRepository<Bill> repository;
        private readonly IUnitOfWork unitOfWork;

        public BillService(IRepository<Bill> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }


        public void AddBill(Bill bill)
        {
            repository.Add(bill);
            unitOfWork.Commit();
        }

        public void DeleteBill(Bill bill)
        {
            repository.Delete(bill);
            unitOfWork.Commit();
        }

        public void DeleteBill(int id)
        {
            repository.Delete(id);
            unitOfWork.Commit();
        }

        public List<Bill> GetAllBill()
        {
            return repository.GetAll().ToList();
        }

        public Bill GetBillById(int id)
        {
            return repository.GetById(id);
        }

        public void UpdateBill(Bill bill)
        {
            repository.Update(bill);
        }
    }
}
