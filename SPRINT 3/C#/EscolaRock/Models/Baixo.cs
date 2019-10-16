

namespace EscolaRock.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Baixo");
            return true;
        }
    }
}