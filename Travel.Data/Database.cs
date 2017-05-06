
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using Travel.Data.Abstract;
using Travel.Models.Registration;
namespace Travel.Data
{
    public class Database : DbContext, IDataContext
    {
        public Database(): base("AppDbContext") { }

        public DbSet<Models.Registration.Travel> Travel { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await this.SaveAsync();
        }

        public IQueryable<TEntity> Entity<TEntity>() where TEntity: class, new()
        {
            return this.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var travelEntityCfg = modelBuilder.Entity<Models.Registration.Travel>();

            travelEntityCfg.HasKey(e => e.Id)
                                .Property(e => e.Id)
                                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            travelEntityCfg.Property(e => e.FirstName)
                                .HasMaxLength(50)
                                .IsRequired();

            travelEntityCfg.Property(e => e.LastName)
                                .HasMaxLength(150)
                                .IsRequired();

            travelEntityCfg.Property(e => e.State)
                                .HasMaxLength(100)
                                .IsRequired();

            travelEntityCfg.Property(e => e.Country)
                                .HasMaxLength(100)
                                .IsRequired();

            travelEntityCfg.Property(e => e.From)
                                .IsRequired();

            travelEntityCfg.Property(e => e.To)
                                .IsRequired();

            travelEntityCfg.Property(e => e.Hotel)
                                .HasMaxLength(150)
                                .IsRequired();
            
            modelBuilder.Conventions.Remove(new PluralizingTableNameConvention());
            base.OnModelCreating(modelBuilder);
        }
    }
}
