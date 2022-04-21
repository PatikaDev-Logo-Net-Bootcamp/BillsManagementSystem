using BillsManagementSystem.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsManagementSystem.Model.Entities.Concrete
{
    public class Apartment : BaseEntity
    {
        public int ApartmentId { get; set; }
        
        public string Block { get; set; }
        
        public string Status { get; set; } //Is Empty or Not
        
        public string Type { get; set; } // Is 2+1 or etc.    
        
        public int FloorNumber { get; set; }
        
        public int ApartmentNumber { get; set; }
        
        public User Indweller { get; set; } //İkamet eden kimse

    }
}
