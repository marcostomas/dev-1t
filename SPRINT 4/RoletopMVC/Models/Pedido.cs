using System;
using RoletopMVC.Enums;

namespace RoletopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get; set;}
        public Cliente Cliente {get; set;}
        public Balada Balada {get; set;}
        public Casamento Casamento {get; set;}
        public Aniversario Aniversario {get; set;}
        public DateTime DataDoEvento {get; set;}
        public uint Status {get; set;}
        public string Observacoes {get; set;}
        public string Participantes {get; set;}


        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Balada = new Balada(); 
            this.Casamento = new Casamento ();
            this.Aniversario = new Aniversario ();
            this.Status = (uint) StatusPedido.PENDENTE;
        }
    }
}