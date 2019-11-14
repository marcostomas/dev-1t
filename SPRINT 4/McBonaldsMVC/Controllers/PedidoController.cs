using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepository pedidoRepository =  new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        public IActionResult Index()
        {
            var hamburgures = hamburguerRepository.ObterTodos()
            return View();
        }

        public IActionResult Registrar (IFormCollection form)
        {   
            // Construtor Vazio
            Pedido pedido = new Pedido();
            // Construtor Vazio e depois adiciona-se suas características
            Shake shake = new Shake();
            shake.Nome = form["shake"];

            // Contrutor c/ suas características já definidas ao iniciá-lo
            Hamburguer hamburguer = new Hamburguer(form["hamburguer"], 0.0);
            pedido.Hamburguer = hamburguer;

            // Construtor c/ suas características definidas dentro de seu próprio escopo
            Cliente cliente = new Cliente ()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Email = form["email"],
                Telefone = form["telefone"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = 0.0;

            pedidoRepository.Inserir(pedido);

            return View("Sucesso");
        }
    }
}