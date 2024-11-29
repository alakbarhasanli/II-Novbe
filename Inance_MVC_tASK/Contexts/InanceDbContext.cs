using Inance_MVC_tASK.Models;
using Microsoft.EntityFrameworkCore;

namespace Inance_MVC_tASK.Contexts
{
    public class InanceDbContext:DbContext 
    {
        DbSet<Masters> masters {  get; set; }
        DbSet<Orders> orders  { get; set; }
        DbSet<Services> services { get; set; }

        public InanceDbContext(DbContextOptions options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Masters>()
                .HasOne(m=>m.Service)
                .WithMany(s => s.Master)
                .HasForeignKey(m => m.ServiceId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Orders>()
                .HasOne(m => m.Master)
                .WithMany(s => s.order)
                .HasForeignKey(m => m.MasterId)
                .OnDelete(DeleteBehavior.Restrict);
           
            modelBuilder.Entity<Orders>()
                .HasOne(o =>o.Service)
                .WithMany(s => s.order1)
                .HasForeignKey(o => o.ServiceId)
                 .OnDelete(DeleteBehavior.Restrict);

       

        }
        

    }
}
