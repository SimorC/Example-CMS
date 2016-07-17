using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_CMS.ViewModel
{
    public class EntityBaseViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime? DtModified { get; set; }
    }
}