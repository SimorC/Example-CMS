using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CMS_Data.Configuration;
using CMS_Domain.Entity;

namespace CMS_Data.Context
{
    public class CMSContext : DbContext
    {
        public CMSContext()
            : base("Example-CMS")
        {
            Database.SetInitializer<CMSContext>(null);
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        // DbSets
        public virtual DbSet<User> Users { get; set; }

        /// <summary>
        /// Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Sets the Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(5000));

            // Adds the Configurations
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        /// <summary>
        /// SaveChanges
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DtCreated") != null))
            {
                entry.Property("DtModified").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Property("DtCreated").CurrentValue = DateTime.Now;
                    entry.Property("IsActive").CurrentValue = true;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DtCreated").IsModified = false;
                    entry.Property("DtModified").IsModified = true;
                }
            }
            return base.SaveChanges();
        }
    }
}
