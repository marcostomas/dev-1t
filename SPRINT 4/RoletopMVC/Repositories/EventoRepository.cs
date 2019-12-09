using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class EventoRepository
    {
        private const string PATH= "Database/Evento.csv";

        public List<Evento> ObterTodos()
        {
            List<Evento> eventos = new List<Evento>();
            var linhas = File.ReadAllLines(PATH);

            foreach( var linha in linhas)
            {
                Evento e = new Evento();
                
                eventos.Add(e);
            }

            return eventos;
        } 
    }
}