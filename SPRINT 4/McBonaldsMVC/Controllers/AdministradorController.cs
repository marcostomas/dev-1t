using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class AdministradorController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();

        [HttpGet]
        public IActionResult Dashboard () 
        {
            var tipoUsuarioSessao = ObterUsuarioNomeSession();
            if(tipoUsuarioSessao.Equals((uint) TipoUsuarios))
            {

            var pedidos = pedidoRepository.ObterTodos ();
            DashboardviewModel dashboardViewModel = new DashboardviewModel ();

            /*
            ! Pode se fazer com 'if' ou 'switch'
            foreach(var pedido in pedidos)
            {
                if(pedido.Status == (uint) StatusPedido.PENDENTE)
                {
                    dashboardViewModel.Pedidos.Add(pedido);
                }
            }
            */
            foreach (var pedido in pedidos)
            {
                switch(pedido.Status)
                {
                    case (uint) StatusPedido.REPROVADO:
                        dashboardViewModel.PedidosReprovados++;
                    break;
                    case (uint) StatusPedido.APROVADO:
                        dashboardViewModel.PedidosAprovados++;
                    break;
                    default:
                        dashboardViewModel.PedidosPendentes++;
                        dashboardViewModel.Pedidos.Add(pedido);
                    break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();

            return View(dashboardViewModel);
            }
        }
    }
}