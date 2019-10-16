using EscolaRock.Interface;

namespace EscolaRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do ContraBaixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de ContraBaixo");
            return true;
        }
    }
}