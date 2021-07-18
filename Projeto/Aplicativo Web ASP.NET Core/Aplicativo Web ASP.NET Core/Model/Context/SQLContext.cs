using Microsoft.EntityFrameworkCore;

namespace Aplicativo_Web_ASP.NET_Core.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) {}
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
