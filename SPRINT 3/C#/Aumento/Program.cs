using System;

namespace Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double salario = 0;
           double salario2 = 0;

           
            Console.WriteLine("Vai Ganhar Mais ou Nem??!");
            Console.WriteLine("================================");
            
            Console.WriteLine("Insira Seu Salário");
            salario = double.Parse(Console.ReadLine());

            salario2 = (salario *0.3) + salario;

            if(salario < 500){
                Console.WriteLine("Mais Grana pra você, Meu Chegado!");
                Console.WriteLine("Seu Novo Salário É: R$ " + salario2);
            }

            else if(salario >= 500)
            {
                Console.WriteLine("Você Não Tem Direito ao Aumento");
                Console.WriteLine("Seu Salário Se Mantém Em: R$ " + salario);
            }

            
        }
    }
}