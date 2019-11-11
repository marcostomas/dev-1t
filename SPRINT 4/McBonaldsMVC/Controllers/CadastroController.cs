using System;
using McBonaldsMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";

            try{
            Cliente cliente = new Cliente(
                form["nome"],
                form["email"],
                form["endereco"],
                form["telefone"],
                form ["senha"],
                DateTime.Parse(form["data-nascimento"]));

                return View("Sucesso");
            
            }catch(Exception e){
                return View("Erro");
            }
            //Semelhante à parte superior
            // System.Console.WriteLine(form["nome"]); 
        }
    }
}