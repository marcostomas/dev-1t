namespace Reciclagem.Models
{
    public class Papelao : Lixos, IPapel
    {
        public bool JogarPapel()
        {
            System.Console.WriteLine("Lixo Jogado na Lixeira Azul (Papéis e Derivados)");
            return true;
        }
    }
}