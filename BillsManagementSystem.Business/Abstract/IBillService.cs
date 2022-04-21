using BillsManagementSystem.Model.Entities.Concrete;
using System.Collections.Generic;

namespace BillsManagementSystem.Business.Abstract
{
    public interface IBillService
    {
        List<Bill> GetAllBill();

        Bill GetBillById(int id);

        void AddBill(Bill bill);

        void UpdateBill(Bill bill);

        void DeleteBill(Bill bill);

        void DeleteBill (int id);
    }
}
