using Microsoft.EntityFrameworkCore;

namespace ClientesAPI
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> opt): base(opt)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
