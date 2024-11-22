using Microsoft.EntityFrameworkCore;

namespace Kreata.Context
{
    public class KreataInMemoryContext : KreataContext
    {
        public KreataInMemoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
