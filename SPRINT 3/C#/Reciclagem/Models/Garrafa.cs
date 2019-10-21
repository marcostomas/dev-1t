namespace Reciclagem.Models
{
    public class Garrafa : Lixos, IVidro
    {
        public bool JogarVidro()
        {
            System.Console.WriteLine("Lixo Jogado na Lixeira Verde (Vidros)");
            return true;
        }
    }
}