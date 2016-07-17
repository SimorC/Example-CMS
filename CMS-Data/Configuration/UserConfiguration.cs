using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS_Domain.Entity;

namespace CMS_Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.FullControl)
                .IsRequired();

            Property(x => x.Password)
                .IsRequired();
        }
    }
}
