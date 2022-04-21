using BillsManagementSystem.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsManagementSystem.Model.Entities.Concrete
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        
        public Guid TurkishIdentificationNumber { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string Phone { get; set; }
        
        public string Role { get; set; } // To identify Admin or Not
        
        public bool HaveCar { get; set; }
        
        public string CarLisancePlate { get; set; }
    }
}
