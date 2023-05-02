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

        public float PrestacaoJuros(int a , float b, float c){
            c = 0f;
            

            if (a <=6)
            {
               c = 0.05f; 
            }
            else if (c >= 7 && c <=12){
                c = 0.08f;
            }
            

       
        float valortotal = (b * c) + b;

        return valortotal;
        

        }
        
            


    }
}