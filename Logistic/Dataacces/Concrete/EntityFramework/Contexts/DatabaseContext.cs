using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Dataacces.Concrete.EntityFramework.Contexts
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Data Source=10.200.10.13;Initial Catalog=Aytemizwebmiddleware; User Id=Middleware;Password=9T!77ztrGCRR; Integrated Security=false;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
