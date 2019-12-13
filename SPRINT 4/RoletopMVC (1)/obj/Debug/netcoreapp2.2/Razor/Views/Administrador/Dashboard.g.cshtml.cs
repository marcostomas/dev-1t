#pragma checksum "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f591ae0236961dff3e4fc5ee03fcbe228a2cbe"
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
#line 1 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f591ae0236961dff3e4fc5ee03fcbe228a2cbe", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 223, true);
            WriteLiteral("\r\n<main>   \r\n    <section id=\"status-pedidos\">\r\n        <h3>Status dos pedidos</h3>\r\n        <div id=\"painel\">\r\n            <div class=\"box-status-pedidos aprovados\">\r\n                <h4>Aprovados</h4>\r\n                <p>");
            EndContext();
            BeginContext(273, 22, false);
#line 9 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(295, 137, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos pendentes\">\r\n                <h4>Pendentes</h4>\r\n                <p>");
            EndContext();
            BeginContext(433, 22, false);
#line 13 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(455, 139, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos reprovados\">\r\n                <h4>Reprovados</h4>\r\n                <p>");
            EndContext();
            BeginContext(595, 23, false);
#line 17 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(618, 838, true);
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
            BeginContext(1457, 12, false);
#line 45 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                             Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1469, 99, true);
            WriteLiteral("</p>\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n            <tbody>\r\n");
            EndContext();
#line 50 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                 foreach (var pedido in Model.Pedidos)
                {

#line default
#line hidden
            BeginContext(1643, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1698, 19, false);
#line 53 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1753, 20, false);
#line 54 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1773, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1809, 18, false);
#line 55 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1827, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1864, "\'", 1925, 1);
#line 56 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1871, Url.Action("Aprovar","Pedido", new {id = @pedido.Id}), 1871, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1926, 70, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1996, "\'", 2059, 1);
#line 57 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2003, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2003, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2060, 67, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 59 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(2146, 63, true);
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
