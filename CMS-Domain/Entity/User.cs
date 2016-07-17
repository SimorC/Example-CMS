using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Domain.Entity
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public bool FullControl { get; set; }
        public string Password { get; set; }
    }
}
