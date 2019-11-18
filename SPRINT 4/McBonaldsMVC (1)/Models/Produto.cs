using System;

namespace McBonaldsMVC.Models
{
    public class Produto : Pedido
    {
        public string Nome {get; set;}
        public double Preco {get; set;}
    }
}