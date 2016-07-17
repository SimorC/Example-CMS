using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_CrossCutting.Helper;
using CMS_Data.Context;
using CMS_Domain.Entity;

namespace CMS_Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CMSContext context)
        {
            #region User
            if (!context.Users.Any())
            {
                context.Users.AddOrUpdate(new User
                {
                    Email = "example@email.com",
                    FullControl = true,
                    IsActive = true,
                    Name = "Admin",
                    Password = StringHelper.Md5EncryptSalt("password123")
                });
            }
            #endregion
        }
    }
}
