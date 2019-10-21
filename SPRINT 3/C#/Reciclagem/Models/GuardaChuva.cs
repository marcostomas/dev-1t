namespace Reciclagem.Models
{
    public class GuardaChuva : Lixos, IOrganico
    {
        public bool JogarIndefinido()
        {
            System.Console.WriteLine("Lixo Jogado na Lixeira Cinza (Objetos Indefinidos)");
            return true;
        }
    }
}