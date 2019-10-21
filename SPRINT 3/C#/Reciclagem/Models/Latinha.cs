namespace Reciclagem.Models
{
    public class Latinha : Lixos, IMetal
    {
        public bool JogarMetal()
        {
            System.Console.WriteLine("Lixo Jogado na Lixeira Amarela (Metais)");
            return true;
        }
    }
}