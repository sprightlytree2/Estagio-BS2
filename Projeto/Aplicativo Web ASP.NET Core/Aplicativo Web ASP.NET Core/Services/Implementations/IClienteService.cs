using Aplicativo_Web_ASP.NET_Core.Model;
using System.Collections.Generic;

namespace Aplicativo_Web_ASP.NET_Core.Services.Implementations
{
    public interface IClienteService
    {
        Cliente FindByID(int id);
        List<Cliente> FindAll();

    }
}
