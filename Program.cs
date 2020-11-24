using System;

namespace Votar
{
    class Program
    {
        static void Main(string[] args)
        {
            
         Console.WriteLine("Escreva a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int media( int idade)
            {
                int voto = idade - 2020;

                return voto;
            }

            if( media(idade) >= 16)
            { Console.WriteLine($"Parabéns, você pode votar! ");   }
             else if ( media(idade) <= 15)
            {  Console.WriteLine($"Sinto muito, mas você não tem a idade minima para votar:");   }
        
        }
    }
}
   

