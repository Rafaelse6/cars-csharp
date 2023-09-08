using Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Car> Cars => Set<Car>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=1234567;database=dotnet-cars";

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}