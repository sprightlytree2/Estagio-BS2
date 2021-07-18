using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicativo_Web_ASP.NET_Core.Model
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("DATA_CADASTRO")]
        public DateTime Data_Cadastro { get; set; }
    }
}
