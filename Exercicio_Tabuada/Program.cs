using System;

namespace Exercicio_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //receber um numero x e mutiplica-lo em fomarto de tabuada (0 a 10)
            //numero recebido é desconhecido
            Console.WriteLine ("\nOlá usuario seja bem vindo a calculadora em formato de tabuda" );
            Console.WriteLine ("Para iniciar....." );
            Console.WriteLine ("....................");
            Console.Write("\nDigite um número:.. ");
            decimal nx = Convert.ToDecimal(Console.ReadLine());
            
            int nmutiplicador = 0;
            decimal nx1=0;
        
            while(nx1 <= 10 * nx)
            {
               
               Console.WriteLine($"{nx} x {nmutiplicador} = {nx1} ");
             
               nx1 += nx; 
              nmutiplicador += 1; 
            }
          
        }

    }
}
