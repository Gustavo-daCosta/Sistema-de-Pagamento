using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseCartao
{
    public class Cartao
    {
        public string Bandeira;
        public string NumeroCartao;
        public string Titular;
        public string Cvv;
        public abstract void Pagar();
        public string SalvarCartao();
    }
}