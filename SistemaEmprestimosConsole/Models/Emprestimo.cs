using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimosConsole.Models
{
    class Emprestimo
    {
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;
        public DateTime DataDevolucao { get; set; }

    }
}
