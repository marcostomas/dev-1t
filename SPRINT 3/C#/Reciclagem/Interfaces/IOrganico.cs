namespace Reciclagem.Interfaces
{
    public interface Organico
    {
        public bool JogarOrganico()
        {
            System.Console.WriteLine("Não possui lixo orgânico");
            return false;
        }
    }
}