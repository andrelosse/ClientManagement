using Microsoft.EntityFrameworkCore;

namespace ClientManagement.Data
{
    public class DbContextConfig : DbContext
    {
        public DbContextConfig(DbContextOptions<DbContextConfig> options) : base(options) {
        
        }
    }
}
