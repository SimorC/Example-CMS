using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Domain.Entity
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime? DtModified { get; set; }
    }
}
