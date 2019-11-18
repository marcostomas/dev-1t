using System;

namespace McBonaldsMVC.Models
{
    public class Pedido
    {
        public Cliente Cliente {get; set;}
        public Hamburguer Hamburguer {get; set;}
        public Shake Shake {get; set;}
        public DateTime DataDoPedido {get; set;}
        public double PrecoTotal {get; set;}

        /*
        public Pedido()
        {

        }
        
        public Pedido(Cliente cliente, Hamburguer hamburguer, Shake shake , DateTime dataPedido, double precoTotal)
        {
            this.Cliente = cliente;
            this.Hamburguer = hamburguer;
            this.Shake = shake;
            this.DataDoPedido = dataPedido;
            this.PrecoTotal = precoTotal;
        }
        */
        
    }
}