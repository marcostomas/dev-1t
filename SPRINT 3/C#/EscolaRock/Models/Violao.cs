using EscolaRock.Interface;

namespace EscolaRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussão
    {
        public bool TocarAcordes()
        {    
            System.Console.WriteLine("Tocando Acordes do Violão");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de Violão");
            return true;
        }
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Violão");
            return true;
        }
    }
}