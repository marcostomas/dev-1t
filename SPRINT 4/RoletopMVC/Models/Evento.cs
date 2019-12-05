using System;

namespace RoletopMVC.Models
{
    public class Evento
    {
        public string Nome {get; set;}
        public DateTime DataDoEvento {get; set;}
        public DateTime HoraDoEvento {get; set;}
        public string Observacoes {get; set;}
        public string NomeParticipantes {get; set;}

    
    }
}