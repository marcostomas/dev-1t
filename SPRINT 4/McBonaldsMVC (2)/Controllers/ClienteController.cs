using System;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        private const string SESSION_CLIENTE_EMAIL = "email_clienter";
        private ClienteRepository clienteRepository =  new ClienteRepository ();
        private PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["action"] = "Login";

            try
            {
                System.Console.WriteLine("======================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("======================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null){
                    if( cliente.Senha.Equals(senha))
                    {
                        //! Session: Controla os dados que são recebidos
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString("SESSION_CLIENTE_NOME", cliente.Nome);
                        // Passa a ação para outro método
                        return RedirectToAction("Historico","Cliente");
                    }else{
                        // Retorna uma tela
                        return View("Erro", new RespostaViewModel("Senha Incorreta"));
                    }
                }else{
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));
                }
            } catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }

        public IActionResult Historico(string email)
        {
            var emailCiente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidos = pedidoRepository.ObterTodosPorCliente(emailCiente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidos
            });
        }
    }
}