using EscolaRock.Interface;

namespace EscolaRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo da Bateria");
            return true;
        }
    }
}