using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Acao { get; set; }
        public DateTime DataHora { get; set; }
    }
}
