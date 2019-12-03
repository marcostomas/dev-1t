using System;

namespace RoletopMVC.Models
{
    public class Casamento : Produto
    {
        public Casamento()
        {

        }
        
        public Casamento(string nome, DateTime dataEvento, DateTime horaEvento, string nomeParticipantes)
        {
            this.Nome = nome;
            this.DataEvento= dataEvento;
            this.HoraEvento = horaEvento;
            this.NomeParticipantes = nomeParticipantes;
        }
    }
}