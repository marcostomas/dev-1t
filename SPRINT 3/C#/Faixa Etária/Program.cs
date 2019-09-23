using System;

namespace Faixa_Etária
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano1 = 0;
            int ano2 = 2019;
            int idade;
            
            do{
                Console.WriteLine("================================");
                Console.WriteLine("De Qual Faixa Etária Faço Parte?");
                Console.WriteLine("================================");


                Console.WriteLine("Informe Seu Ano de Nascimento");
                ano1 = int.Parse(Console.ReadLine());

                idade = (ano2 - ano1);

                Console.WriteLine("Sua Idade é de " + idade + " anos");

                if(idade <= 2){
                    Console.WriteLine("Você é um Recém-Nascido");
                }

                else if(idade <= 11){
                    Console.WriteLine("Você é uma Criança");
                }

                else if(idade <= 19){
                    Console.WriteLine("Você é um Adolescente");
                }

                else if(idade <= 65){
                    Console.WriteLine("Você é um Adulto");
                }

                else if(idade > 65){
                    Console.WriteLine("Você é um Museu");
                }

                Console.WriteLine("Para sair, Digite o ano posterior ao que estamos!");


            }while(idade != -1);
        }
    }
}
