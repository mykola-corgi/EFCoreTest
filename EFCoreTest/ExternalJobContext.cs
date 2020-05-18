using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using EFCoreTest.Entities;
using EFCoreTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreTest
{
    public class ExternalJobContext: DbContext, IDesignTimeDbContextFactory<ExternalJobContext>
    {
        public ExternalJobContext()
        {
            
        }
        public ExternalJobContext(DbContextOptions<ExternalJobContext> options) : base(options)
        {

        }

        public DbSet<WorkOrder> WorkOrders { get; set; }
        internal DbSet<Appliance> Appliances { get; set; }
        internal DbSet<Contract> Contracts { get; set; }
        internal DbSet<Customer> Customers { get; set; }
        internal DbSet<Exclusion> Exclusions { get; set; }
        internal DbSet<Property> Properties { get; set; }
        public ExternalJobContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ExternalJobContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=Test;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ExternalJobContext(optionsBuilder.Options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WorkOrder>(builder => builder.HasKey(k => k.Number));
            modelBuilder.Entity<WorkOrder>(builder => builder.HasIndex(k => k.Name).IsUnique());
            modelBuilder.Entity<Contract>(builder => builder.HasKey(k => k.ContractId));
            modelBuilder.Entity<Property>(builder => builder.HasKey(k => k.PropertyId));
            modelBuilder.Entity<Exclusion>(builder => builder.HasKey(k => k.ExclusionId));
            modelBuilder.Entity<Customer>(builder => builder.HasKey(k => k.CustomerId));
            //modelBuilder.Entity<WorkOrder>().Property<ICustomer>(wo => (Customer)wo.Customer);
            //modelBuilder.Entity<Property>().Property<IEnumerable<Appliance>>(p => (IEnumerable<Appliance>)p.AppliancesAtProperty);

            modelBuilder.Entity<WorkOrder>(x => x.HasOne<Contract>());
            modelBuilder.Entity<WorkOrder>(x => x.HasOne<Property>());

        }
    }
}
