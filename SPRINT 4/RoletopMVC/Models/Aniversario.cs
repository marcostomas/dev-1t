using System;

namespace RoletopMVC.Models
{
    public class Aniversario : Produto
    {
        public Aniversario()
        {

        }

        public Aniversario(string nome, DateTime dataEvento, DateTime horaEvento, string nomeParticipantes)
        {
            this.Nome = nome;
            this.DataEvento= dataEvento;
            this.HoraEvento = horaEvento;
            this.NomeParticipantes = nomeParticipantes;
        }
    }
}