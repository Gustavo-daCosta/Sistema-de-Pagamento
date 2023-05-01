using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public class Cartao
    {
        public string Bandeira;
        public string NumeroCartao;
        public string Titular;
        public string Cvv;
        public abstract void Pagar();
        public bool SalvarCartao(string cartaoAnalizado);
        foreach (Cartao cartaoChecado in cartoes)
        {
            if (cartaoChecado == cartaoAnalizado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}