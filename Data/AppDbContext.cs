using Microsoft.EntityFrameworkCore;
using form_using_blazor.Models;

namespace form_using_blazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TransmissionLineDiversionRequest>
            TransmissionLineDiversionRequests
        { get; set; }

        public DbSet<Documents>
            Documents
        { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TransmissionLineDiversionRequest>()
                .HasKey(x => x.RequestId);

            modelBuilder.Entity<Documents>()
                .HasKey(x => x.DocId);
        }
    }
}