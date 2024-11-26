using Microsoft.EntityFrameworkCore;

namespace PointToPoint.Context
{
    public class PointToPointInMemoryContext : PointToPointContext
    {
        public PointToPointInMemoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
