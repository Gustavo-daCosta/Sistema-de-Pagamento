using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClasseCartao;

namespace  CartaoCredito
{
    public class Credito : Cartao
    {
        public float Limite { get; set; }

        public override void Pagar()
        {
            throw new NotImplementedException();
        }

        //Parcela com juros Valor não pode ser maior que limite 
    }
}