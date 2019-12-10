using System;

namespace SENAIzinho
{
    class Program
    {
        public void Main(string[]Args)
        System.Console.WriteLine("===============================");
        System.Console.WriteLine("     Sistema S - Cadastro");
        System.Console.WriteLine("===============================");

            int limiteAlunos = 0;
            int limiteSalas = 0;
            Aluno[] alunos;
            Sala[] salas;
            int alunosCadastrados;
            int salasCadastradas;
            bool querSair;

        public void CadastrarAluno(int limiteAlunos)
        {
            if (limiteAlunos < 100)
            {
                System.Console.WriteLine("Digite o nome do Aluno");
                string nome = Console.ReadLine();

                System.Console.WriteLine("Digite a idade do Aluno");
                int idade = int.Parse(Console.ReadLine());

                Alunos[] alunos = new Alunos[];
            }else{
                System.Console.WriteLine("não há vagas disponíveis!");
            }
        }

        public void CadastrarSala()
        {
            if(limiteSalas < 10)
            {
                
            }
        }

        public void AlocarAluno()
        {
            
        }
        public void RemoverAluno()
        {
            System.Console.WriteLine("Digite o nome do Aluno");
            string aluno = Console.ReadLine();
        }
        public void VerificarSalas()
        {

        }
        public void verificarAlunos()
        {

        }
    }
}
