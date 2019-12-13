using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enums;
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
            // * TERMINADO 09/12 (6)
            pvm.Evento = eventoRepository.ObterTodos();

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
            pvm.UsuarioEmail = usuarioLogado;
            pvm.UsuarioNome = nomeUsuarioLogado;

            return View(pvm);
        }

            //TODO: TERMINAR MÉTODO REGISTRAR
            // !  IMPORTANTISSÍMO
        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";

            var cliente = clienteRepository.ObterPor(ObterUsuarioSession());
            
            // Cliente cliente = new Cliente ()
            // {
            //     Nome = cliente1.Nome,
            //     CPF = cliente1.CPF,
            //     Email = cliente1.Email
            // }

            var tipoEvento = form["tipoEvento"];
            Evento evento = new Evento()
            {
                Nome = form["nomeEvento"],
                Observacoes = form["observacoes"],
            };

            Pedido pedido = new Pedido()
            {
                HoraDoEvento = DateTime.Parse(form["horaEvento"]),
                DataDoEvento = DateTime.Parse(form["dataEvento"])
            };
        
            
            if(pedidoRepository.Inserir (pedido))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Aprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel ("Não foi possível aprovar seu pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Reprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel ("Não foi possível aprovar seu pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}