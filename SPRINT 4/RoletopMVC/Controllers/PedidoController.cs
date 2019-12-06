using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        EventoRepository eventoRepository = new EventoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
            //TODO: FAZER O EVENTO REPOSITORY
            pvm.Eventos = eventoRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();

            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);

            if(clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = "usuarioLogado";
            pvm.UsuarioNome = nomeUsuarioLogado;

            return View(pvm)
        }


        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();

            var nomeEvento = form["tipoevento"];
            Evento evento = new Evento();
            
        }
    }
}