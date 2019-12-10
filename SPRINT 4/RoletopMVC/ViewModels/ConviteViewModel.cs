using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class ConviteViewModel
    {
        public List <Convite> Convite {get; set;}
        public string NomeCliente {get; set;}
        public Cliente Cliente {get; set;}

        public ConviteViewModel()
        {
            this.Convite = new List<Convite>();
            this.NomeCliente = Cliente.Nome;
            this.Cliente = new Cliente();
        }
    }
}