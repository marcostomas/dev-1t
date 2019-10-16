using System;
using EscolaRock.Interface;

namespace EscolaRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Toicando acordes da Guitarra");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de Guitarra");
            return true;
        }
    }
}