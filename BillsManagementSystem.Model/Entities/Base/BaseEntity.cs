using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsManagementSystem.Model.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public string CreatedBy { get; set; }
        
        public DateTime? LastUpdatedAt { get; set; }
        
        public string LastUpdatedBy { get; set; }

    }
}
