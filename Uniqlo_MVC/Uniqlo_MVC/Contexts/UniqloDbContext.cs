using Microsoft.EntityFrameworkCore;
using Uniqlo_MVC.Models;

namespace Uniqlo_MVC.Contexts
{
    public class UniqloDbContext : DbContext
    {
        public UniqloDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SliderItem> SliderItems { get; set;}
    }
}
