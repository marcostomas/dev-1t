using System;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    //LOGOFF - duas opções,clicando no botão e usando o timeout

    //Trocou a herança de Controller para AbstractController
    public class ClienteController : AbstractController
    {
        
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel(){
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
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

                //este metodo verifica se o EMAIL existe ou não
                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)
                {
                    //Verifica se a senha e o email são iguais à escolha do usuario
                    //EXCLUIDO - if(cliente.Email.Equals(usuario) && cliente.Senha.Equals(senha))
                    if (cliente.Senha.Equals(senha))
                    {
                        //Deixa visivel para todos os controllers as informações 
                        //Exemplo: email,nome
                        //! HttpContext.Session.SetString - permite que os dados seja compartilhado entre controllers
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                        //Redirecionar para a ação= chamar um metodo (HISTORICO)
                        //ANTES
                        // return View("Historico", "Cliente");
                        //DEPOIS
                        //! RedirectToAction - passa a ação do metodo para outro
                        return RedirectToAction ("Historico", "Cliente");
                    }
                    else
                    {
                        //VIEW - RETORNA UMA TELA
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                }
                else
                {
                    //Duas opções que fazem a mesma coisa 1 e 2
                // 1 -RespostaViewModel rvm = new RespostaViewModel();
                // 1 - return View("Erro", rvm);

                // 2 -Criando o objeto sem armazena-lo no cliente controller
                //Tudo que está dentro de "" vai para o parametro string mensagem, do construtor RespostaViewModel
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));
                }

            } catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    
        public IActionResult Historico()
        {
            //envia o nome para o cliente
            var emailCliente = ObterUsuarioSession();
             //Metodo pedidoRepository = listar todos os pedidos
            var pedidos = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidos,
                NomeView = "Historico",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }

        //Metodo de Logoff
        public IActionResult Logoff()
        {
            //Tirar os dados da seção e depois limpar os dados
            //Depois redireciona para o Index, Home
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    
    }
}