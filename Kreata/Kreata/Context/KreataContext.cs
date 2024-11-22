using Microsoft.EntityFrameworkCore;

namespace Kreata.Context
{
    public class KreataContext : DbContext
    {
        protected KreataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
