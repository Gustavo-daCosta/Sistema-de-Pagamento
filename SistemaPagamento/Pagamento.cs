using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public class Pagamento
    {
        // private DateTime Data = DateTime.Now.Date;
        private DateTime Data { get; set; }

        public float Valor { get; set; }

        public string Cancelar()
        {
            return "Operação Cancelada !";
        }
    }
}