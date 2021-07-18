using Microsoft.EntityFrameworkCore;

namespace Aplicativo_Web_ASP.NET_Core.Model.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext()
        {

        }
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) {}
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
