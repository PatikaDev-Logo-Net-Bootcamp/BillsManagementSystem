using BillsManagementSystem.Model.Entities.Concrete;
using System.Collections.Generic;

namespace BillsManagementSystem.Business.Abstract
{
    public interface IApartmentService
    {
        List<Apartment> GetAllApartment();

        Apartment GetApartmentById(int id);

        void AddApartment(Apartment apartment);

        void UpdateApartment(Apartment apartment);

        void DeleteApartment(Apartment apartment);

        void DeleteApartment(int id);
    }
}
