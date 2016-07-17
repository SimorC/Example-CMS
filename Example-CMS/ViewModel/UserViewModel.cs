using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CMS_Domain.Entity;

namespace Example_CMS.ViewModel
{
    public class UserViewModel : EntityBaseViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public bool FullControl { get; set; }
        public string Password { get; set; }
    }
}