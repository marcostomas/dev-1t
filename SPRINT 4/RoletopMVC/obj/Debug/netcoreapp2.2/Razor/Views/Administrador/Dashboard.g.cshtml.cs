#pragma checksum "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1536b505b23490e01de499bfd7c8b60d7476c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1536b505b23490e01de499bfd7c8b60d7476c6", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 244, true);
            WriteLiteral("\r\n<main>\r\n    <h2>Dashboard</h2>\r\n    <section id=\"status-pedidos\">\r\n        <h3>Status dos pedidos</h3>\r\n        <div id=\"painel\">\r\n            <div class=\"box-status-pedidos aprovados\">\r\n                <h4>Aprovados</h4>\r\n                <p>");
            EndContext();
            BeginContext(294, 22, false);
#line 10 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(316, 137, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos pendentes\">\r\n                <h4>Pendentes</h4>\r\n                <p>");
            EndContext();
            BeginContext(454, 22, false);
#line 14 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(476, 139, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos reprovados\">\r\n                <h4>Reprovados</h4>\r\n                <p>");
            EndContext();
            BeginContext(616, 23, false);
#line 18 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(639, 838, true);
            WriteLiteral(@"</p>
            </div>
        </div>
    </section>
    
    <section id=""lista-pedidos"">
        <h3>Lista de pedidos</h3>
        <table>
            <thead>
                <tr>
                    <th rowspan=""2"">Nome</th>
                    <th rowspan=""2"">E-mail</th>
                    <th rowspan=""2"">Tipo Evento</th>
                    <th rowspan=""2"">Aprovar</th>
                </tr>
                <!-- EXCLUÍDO 09/12 [6] 
                    
                    <tr>
                    <th>Som</th>
                    <th>Luz</th>
                    <th></th>
                    <th></th>
                    </tr> 
                -->
            </thead>
            <tfoot>
                <tr>
                    <td colspan=""6"">
                        <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1478, 12, false);
#line 46 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                             Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1490, 99, true);
            WriteLiteral("</p>\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n            <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                 foreach (var pedido in Model.Pedidos)
                {

#line default
#line hidden
            BeginContext(1664, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1719, 19, false);
#line 54 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1738, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1774, 20, false);
#line 55 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1794, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1830, 18, false);
#line 56 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1848, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1885, "\'", 1946, 1);
#line 57 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1892, Url.Action("Aprovar","Pedido", new {id = @pedido.Id}), 1892, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1947, 70, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2017, "\'", 2080, 1);
#line 58 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2024, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2024, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2081, 67, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 60 "C:\Users\44036901818\Documents\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(2167, 63, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</main>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
