using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enums;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]

        public IActionResult Login ()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }


        [HttpPost]

        public IActionResult Login (IFormCollection form)
        {
            ViewData["action"] = "Login";

            try
            {
                System.Console.WriteLine("========================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("========================");

                var usuario = form["email"];
                var senha = form["senha"];

                // * O MÉTODO ABAIXO VERIFICA SE P EMAIL EXISTE OU NÃO
                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch(cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLINETE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLINETE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLINETE_TIPO, cliente.TipoUsuario.ToString());
                                
                                return RedirectToAction("Historico", "Cliente");

                            default:
                                HttpContext.Session.SetString(SESSION_CLINETE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLINETE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLINETE_TIPO, cliente.TipoUsuario.ToString());


                                return RedirectToAction ("Dashboard", "Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha Incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }


        public IActionResult Historico()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel ()
            {
                Pedidos = pedidosCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }


        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLINETE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLINETE_NOME);
            HttpContext.Session.Clear();
            
            return RedirectToAction("Index", "Home");
        }
    }
}