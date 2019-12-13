using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Evento> Evento {get; set;}
        public string NomeUsuario {get; set;}
        public Cliente Cliente {get; set;}

        public PedidoViewModel()
        {
            this.Evento = new List<Evento>();
            this.Cliente = new Cliente ();
            this.NomeUsuario = Cliente.Nome;
        }
    }
}