using System;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
           
           float media = 0;

           
            Console.WriteLine("Programa Gerador de Média");
            Console.WriteLine("================================");
            
            Console.WriteLine("Insira a Primeira Nota");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Segunda Nota");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Terceira Nota");
            float nota3 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a Quarta Nota");
            float nota4 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) /4;

            Console.WriteLine("Resultado = " + media);

            if(media >= 7.0){
                Console.WriteLine("Aprovado");
            }

            else if(media < 7.0)
            {
                Console.WriteLine("Reprovado");
            }

            
        }
    }
}
