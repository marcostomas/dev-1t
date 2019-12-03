using System;

namespace RoletopMVC.Models
{
    public class Balada : Produto
    {
        public Balada()
        {
            
        }
        public Balada(string nome, DateTime dataEvento, DateTime horaEvento, string nomeParticipantes)
        {
            this.Nome = nome;
            this.DataEvento= dataEvento;
            this.HoraEvento = horaEvento;
            this.NomeParticipantes = nomeParticipantes;
        }
    }
}