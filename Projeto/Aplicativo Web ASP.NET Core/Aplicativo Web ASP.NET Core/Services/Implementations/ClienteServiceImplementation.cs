using Aplicativo_Web_ASP.NET_Core.Model;
using Aplicativo_Web_ASP.NET_Core.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_ASP.NET_Core.Services.Implementations
{
    public class ClienteServiceImplementation : IClienteService
    {
        private SQLContext _context;

        public ClienteServiceImplementation(SQLContext context)
        {
            _context = context;
        }

        public List<Cliente> FindAll()
        {
            return _context.Clientes.ToList();
        }

        public Cliente FindByID(int id)
        {
            return _context.Clientes.SingleOrDefault(c => c.Id == id);
        }
    }
}
