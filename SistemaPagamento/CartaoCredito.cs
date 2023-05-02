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



        public (float, float) PrestacaoJuros(int a , float b, float c){
            c = 0f;
            

            if (a <=6)
            {
               c = 0.05f; 
            }
            else if (c >= 7 && c <=12){
                c = 0.08f;
            }
            

        float prestacao = (b * c) / a;
        float valortotal = b * c;

        return (prestacao,valortotal);
        

        }


//Parcela com juros Valor não pode ser maior que limite - Crédito :
// - limite estabelecido no cartão de crédito deve ser pré-definido
// - máximo de parcelamento 12x
// - até 6x - acrescentar juros de 5% no valor da compra
// - entre 7x e 12x acrescentar juros de 8% no valor da compra
    }
}