using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.Models;
using McBonaldsMVC.ViewModels;

namespace McBonaldsMVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            //Apagou o nomeView = Home
            // ViewData["NomeView"] = "Home";
            //Passar o a pasta BaseViewModel
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }   
        
    }
}
