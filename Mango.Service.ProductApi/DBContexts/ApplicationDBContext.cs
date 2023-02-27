using Mango.Service.ProductApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Service.ProductApi.DBContexts
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
