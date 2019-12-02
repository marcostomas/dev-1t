#pragma checksum "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb950c97a2abf5ea6a90c8b25fb7ae9a3acaf07"
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
#line 1 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb950c97a2abf5ea6a90c8b25fb7ae9a3acaf07", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.DashboardviewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 274, true);
            WriteLiteral(@"    <main>
        <h2>Dashboard</h2>
        <section id=""status-pedidos"">
            <h3>Status dos pedidos</h3>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(326, 22, false);
#line 9 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(348, 153, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(502, 22, false);
#line 13 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(524, 155, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos reprovados\">\r\n                    <h4>Reprovados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(680, 23, false);
#line 17 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(703, 901, true);
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
                        <th rowspan=""2"">Endereço</th>
                        <th colspan=""2"">Pedido</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <tr>
                        <th><i class=""fas fa-hamburger""></i></th>
                        <th><i class=""fas fa-mug-hot""></i></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1605, 12, false);
#line 42 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var pedido in Model.Pedidos)
                    {

#line default
#line hidden
            BeginContext(1814, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1877, 19, false);
#line 50 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1896, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1936, 23, false);
#line 51 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Cliente.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(1959, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1999, 22, false);
#line 52 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2021, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2061, 17, false);
#line 53 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2078, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2119, "\'", 2181, 1);
#line 54 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2126, Url.Action("Aprovar", "Pedido", new {id = @pedido.Id}), 2126, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2182, 74, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2256, "\'", 2319, 1);
#line 55 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2263, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2263, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2320, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2414, 81, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.DashboardviewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591