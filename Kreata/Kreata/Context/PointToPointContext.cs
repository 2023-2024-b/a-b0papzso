using Microsoft.EntityFrameworkCore;
namespace PointToPoint.Context
{
    public class PointToPointContext : DbContext
    {
        protected PointToPointContext(DbContextOptions options) : base(options)
        {
        }
    }
}
