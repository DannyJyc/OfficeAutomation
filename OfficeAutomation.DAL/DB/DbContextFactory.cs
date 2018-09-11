using Chloe;
using Chloe.MySql;

namespace OfficeAutomation.DAL.DB
{
    public class DbContextFactory
    {
        public static IDbContext CreateDbContext()
        {
            IDbContext context = new MySqlContext(new MySqlConnectionFactory());
            return context;
        }
    }
}
