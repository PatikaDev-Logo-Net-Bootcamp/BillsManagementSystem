using BillsManagementSystem.Business.Abstract;
using BillsManagementSystem.DataAccess.EntityFramework.Repository.Abstract;
using BillsManagementSystem.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BillsManagementSystem.Business.Concrete
{
    public class ApartmentService : IApartmentService
    {

        private readonly IRepository<Apartment> repository;
        private readonly IUnitOfWork unitOfWork;

        public ApartmentService(IRepository<Apartment> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        
        public void AddApartment(Apartment apartment)
        {
            repository.Add(apartment);
            unitOfWork.Commit();
        }

        public void DeleteApartment(Apartment apartment)
        {
            repository.Delete(apartment);
            unitOfWork.Commit();
        }

        public void DeleteApartment(int id)
        {
            repository.Delete(id);
            unitOfWork.Commit();
        }

        public List<Apartment> GetAllApartment()
        {
            return repository.GetAll().ToList();
        }

        public Apartment GetApartmentById(int id)
        {
            return repository.GetById(id);
        }

        public void UpdateApartment(Apartment apartment)
        {
            repository.Update(apartment);
        }
    }
}
