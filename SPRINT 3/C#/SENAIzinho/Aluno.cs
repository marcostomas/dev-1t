using System;

namespace SENAIzinho {
    public class Aluno {
        public string Nome;
        public DateTime DataNascimento;
        public string Curso;
        public int NoSala;
    
    public Aluno (string Nome, DateTime DataNascimento, string Curso){
        this.Nome = Nome;
        this.DataNascimento = DataNascimento;
        this.Curso = Curso;
    }

    public bool AlocarAluno (int nosala){
        if (nosala >)
        this.NoSala = nosala;
        return true;
    }else{
        return false;
    }
}