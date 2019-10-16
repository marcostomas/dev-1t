using EscolaRock.Interface;

namespace EscolaRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussão
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Tambor");
            return true;
        }
    }
}