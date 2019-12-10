namespace SENAIzinho 
{
    public class Sala 
    {
        public int CapacidadeAtual = 0;
        public int CapacidadeTotal  = 30;
        public int numeroSala;
        public string[] Alunos;
        

        public Sala(int numerosala, int capacidadeTotal)
        {
            this.numeroSala = numerosala;
            this.CapacidadeTotal = capacidadeTotal;
        }

        public string AlocarAluno(string Nome)
        {
            Nome;
        }

        public string RemoverAluno (string)
        {

        }

        public string MostrarAlunos()
        {
            System.Console.WriteLine();
        }
    }
}