using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    //Trocar a herança de Controller para AbstractController
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        ClienteRepository clienteRepository = new ClienteRepository();

        //Só retorna um ViewModel o metodo Index()
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepository.ObterTodos();
            var shakes = shakeRepository.ObterTodos();

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburgueres;
            pedido.Shakes = shakes;

            //Escrever o nome da pessoa que acessa o pedido
            // var usuarioLogado = HttpContext.Session.GetString();
            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();


            //Guarda o objeto cliente - armazena os dados da tela de pedidos
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                pedido.Cliente = clienteLogado;
            }

            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pedido.NomeUsuario = nomeUsuarioLogado;
            }
                pedido.NomeView = "Pedido";
                pedido.UsuarioEmail = ObterUsuarioSession();
                pedido.UsuarioNome = ObterUsuarioNomeSession();
            //
            //Trocar para o nome do usuario - Pega o usuario da seção e transporta para a View
            pedido.NomeUsuario = ObterUsuarioNomeSession();

            return View(pedido);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();
            
            //OUTRO JEITO DE SE FAZER:
            // var nomeShake = form["shake"];
            //shake.Preco = shakeRepository.ObterPreco(nomeShake);
            //shake.Preco = precoShake;
            //shake.Nome = form["shake"];
            //shake.Preco = shakeRepository.ObterPreco(form["shake"]);
            Shake shake = new Shake(form["shake"], shakeRepository.ObterPrecoDe(form["shake"]));
            pedido.Shake = shake;

            //OUTRO JEITO DE SE FAZER:
            // var nomeHamburguer = form["hamburguer"];
            //Hamburguer.Nome = nomeHamburguer;
            //Hamburguer.Nome = HamburguerRepository.ObterPreco(nomeHamburguer); 
            Hamburguer hamburguer = new Hamburguer(form["hamburguer"], hamburguerRepository.ObterPrecoDe(form["hamburguer"]));
            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = pedido.Hamburguer.Preco + pedido.Shake.Preco;

            if(pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    Mensagem = "Aguarde a aprovação dos nossos administradores",
                    NomeView = "Sucesso",
                    UsuarioEmail = ObterUsuarioNomeSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });

            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao processar seu pedido. Tente novamente",
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioNomeSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Aprovar (ulong id)
        {
            Pedido pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao processar seu pedido. Tente novamente",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioNomeSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar (ulong id)
        {
            Pedido pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao reprovar seu pedido. Tente novamente",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioNomeSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}