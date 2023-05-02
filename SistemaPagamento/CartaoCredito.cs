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

        

        public override bool Pagar(){
        Console.WriteLine($"Em quantas prestações deseja fazer");
       
        int parcela = int.Parse(Console.ReadLine()); 
        
        float taxa = 0f;
            

            if (parcela <=6)
            {
                Console.WriteLine( this.Valor*1.05f);               
                
            }
            else if (taxa >= 7 && taxa <=12){
                Console.WriteLine( this.Valor*1.08f);
            }
            
            return parcela <= 12 ? true : false;

       
        
    
        
        

        }
        
            
            


    }
}