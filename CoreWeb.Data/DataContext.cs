using CoreWeb.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWeb.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbContext"));
            //optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=WebApp;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
