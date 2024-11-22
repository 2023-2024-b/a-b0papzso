using Microsoft.EntityFrameworkCore;

namespace Kreata.Context
{
    public class KreataInMemoryContext : KreataContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
