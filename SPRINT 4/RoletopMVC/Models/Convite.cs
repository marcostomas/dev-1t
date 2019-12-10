namespace RoletopMVC.Models
{
    public class Convite
    {
        public Cliente Cliente {get; set;}
        public Participante Participante {get; set;}

        public Convite()
        {
            this.Cliente = new Cliente();
            this.Participante = 
        }
    }
}