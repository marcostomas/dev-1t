using System;
using RoletopMVC.Enums;
namespace RoletopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get; set;}
        public Cliente Cliente {get; set;}
        public Evento Evento {get; set;}
        public DateTime DataDoEvento {get; set;}
        public DateTime HoraDoEvento {get; set;}
        public uint Status {get; set;}
        
        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Evento = new Evento();
            this.Status = (uint) StatusPedido.PENDENTE;
        }
    }
}