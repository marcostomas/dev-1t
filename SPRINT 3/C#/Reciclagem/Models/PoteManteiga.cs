namespace Reciclagem.Models
{
    public class PoteManteiga : Lixos, IPlastico
    {
        public bool JogarPlastico()
        {
            System.Console.WriteLine("Lixo Jogado na Lixeira Vermelha (Plásticos)");
            return true;
        }
    }
}