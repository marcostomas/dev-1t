using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Aniversario> Aniversarios {get; set;}
        public List<Balada> Baladas {get; set;}
        public List<Casamento> Casamentos {get; set;}
        public string NomeUsuario {get; set;}
        public Cliente Cliente {get; set;}

        public PedidoViewModel()
        {
            this.Aniversarios = new List<Aniversario>(); 
            this.Baladas =  new List<Balada>();
            this.Casamentos = new List<Casamento>();
            this.NomeUsuario = "Jovem";
            this.Cliente = new Cliente ();
        }
    }
}