#pragma checksum "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a3c424559861271b71efe13f756777315610a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a3c424559861271b71efe13f756777315610a4", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - Roletop";
    ViewData["H2"] = "Histórico de Eventos";

#line default
#line hidden
            BeginContext(148, 19, true);
            WriteLiteral("\r\n<main>\r\n    <h2> ");
            EndContext();
            BeginContext(168, 8, false);
#line 8 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
    Write(ViewData);

#line default
#line hidden
            EndContext();
            BeginContext(176, 229, true);
            WriteLiteral(" [\"H2\"]</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Nome Cliente</th>\r\n                <th>Tipo do Evento</th>\r\n                <th>Status</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(460, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(507, 18, false);
#line 20 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(525, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(557, 19, false);
#line 21 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(576, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(608, 13, false);
#line 22 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Status);

#line default
#line hidden
            EndContext();
            BeginContext(621, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 24 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(666, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
