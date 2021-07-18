using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicativo_Web_ASP.NET_Core.Model
{
    
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}
