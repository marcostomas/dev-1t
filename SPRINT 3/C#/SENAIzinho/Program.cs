using System;
using Aluno;
using Sala;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("     Sistema S - Cadastro");
            System.Console.WriteLine("===============================");
            
            System.Console.WriteLine();

            System.Console.WriteLine("Digite o Número das Seguintes Opções:");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Alocar Aluno em Sala");
            System.Console.WriteLine("3 - Terminar");
            opcao = int.Parse(Console.ReadLine());
            
            // array

            do{

            
                switch (opcao){

                    case 1:
                        Console.WriteLine("Nome do Aluno");
                        string nome = Console.ReadLine();

                        System.Console.WriteLine("Data de Nascimento do Aluno");
                        DateTime datanascimento = new Console.ReadLine();

                        System.Console.WriteLine("Curso");
                        string curso = new Console.ReadLine();

                        System.Console.WriteLine("Número da Sala");
                        int numerosala = new Console.ReadLine();
                    break;

                    case 2:
                        System.Console.WriteLine("Digite o Número da Sala onde o aluno será alocado:");
                        nosala = int.Parse(Console.ReadLine());
                    break;

                    case 3:
                        System.Console.WriteLine("Terminando...");
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                    break;
                }
            }while(opcao != 0)
            return 0;
            
            Aluno aluno1 = new Aluno (nome, datanascimento, curso, nosala);
        }
    }
}
