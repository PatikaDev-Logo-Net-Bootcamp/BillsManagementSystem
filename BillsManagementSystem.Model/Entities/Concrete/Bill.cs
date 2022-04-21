using BillsManagementSystem.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsManagementSystem.Model.Entities.Concrete
{
    public class Bill : BaseEntity
    {
        public int BillId { get; set; }
        
        public string BillName { get; set; }
        
        public string BillDescription { get; set; }
        
        public decimal BillAmount { get; set; }
        
        public DateTime BillDate { get; set; }
        
        public int BillTypeId { get; set; }
        
        public int BillStatusId { get; set; }
        
        public int UserId { get; set; }
        
        //public virtual BillType BillType { get; set; }
        
        //public virtual BillStatus BillStatus { get; set; }
        
        public virtual User User { get; set; }
    }
}
