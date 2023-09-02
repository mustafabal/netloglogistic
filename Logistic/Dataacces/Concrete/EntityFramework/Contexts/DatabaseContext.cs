using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Dataacces.Concrete.EntityFramework.Contexts
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Data Source=----;Initial Catalog=----; User Id=Middleware;Password=---; Integrated Security=false;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
