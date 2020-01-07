using System.Data.Entity;
using FilterDataSample.Entities;

namespace FilterDataSample.Models
{
    public class AdventureWorksDbContext : DbContext
    {
        public AdventureWorksDbContext() : base("name=AdvWorks")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
