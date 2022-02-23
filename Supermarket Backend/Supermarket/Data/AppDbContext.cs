using Microsoft.EntityFrameworkCore;
using Supermarket.Data.Models;

namespace Supermarket.Data
{
    public class AppDbContext:DbContext
    {
        //Config constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        //2. Config Table Sectors
        public DbSet<Sector> Sectors { get; set; }



        //Config Table Products
        public DbSet<Product> Products { get; set; }

    }
}
