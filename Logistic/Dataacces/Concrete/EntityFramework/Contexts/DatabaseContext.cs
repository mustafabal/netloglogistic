using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Dataacces.Concrete.EntityFramework.Contexts
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Data Source=94.73.170.48;Initial Catalog=dbnetlo; User Id=dbnetlo;Password=L.e=F_4efSy49B2-; Integrated Security=false;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
