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

        

        public override void  Pagar(){
        Console.WriteLine($"Em quantas prestações deseja fazer");
        bala:
        int parcela = int.Parse(Console.ReadLine()); 
        if (parcela >12)
        {
            Console.WriteLine($"Prestacao tem que ser menor ou igual a 12, Tente novamente");
            goto bala; 
        }
        float taxa = 0f;
            

            if (parcela <=6)
            {
                Console.WriteLine( this.Valor*1.05f);               
                
            }
            else if (taxa >= 7 && taxa <=12){
                Console.WriteLine( this.Valor*1.08f);
            }
            

       
        
    
        
        

        }
        
            
            


    }
}