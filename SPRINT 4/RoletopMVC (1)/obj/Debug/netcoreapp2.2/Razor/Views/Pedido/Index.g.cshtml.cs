#pragma checksum "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ca373683c5c61cc482c3b4fd71be924deea1df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ca373683c5c61cc482c3b4fd71be924deea1df", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 71, true);
            WriteLiteral("    \r\n<main>\r\n    <section class=\"formulario\">\r\n        <h2>Bem-Vindo, ");
            EndContext();
            BeginContext(118, 17, false);
#line 5 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml"
                  Write(Model.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(135, 65, true);
            WriteLiteral(" </h2>\r\n        \r\n        <h2>Agendar Evento</h2><br />\r\n        ");
            EndContext();
            BeginContext(200, 1554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ca373683c5c61cc482c3b4fd71be924deea1df4616", async() => {
                BeginContext(263, 1098, true);
                WriteLiteral(@"
            <div class=""form-box"">
                <label for=""nomeEvento""> Nome do Evento</label>
                <br />
                <input id=""nomeEvento"" type=""text"" maxlength=""60"" minlength=""3"" name=""nomeEvento"">
            </div>

            <div class=""form-box"">
                <label for=""dataEvento""> Data do Evento</label>
                <br />
                <input id=""dataEvento"" type=""date"" name=""dataEvento"" />
            </div>

            <div class=""form-box"">
                <label for=""horaEvento""> Hora de Início</label>
                <br />
                <input id=""horaEvento"" type=""time"" name=""horaEvento"">
            </div>

            <div class=""form-box"">
                <label for=""observacoes""> Observações</label>
                <br />
                <input id=""observacoes"" type=""text"" name=""observacoes""/>
            </div>
            <div class=""option-box"">
                <label for=""tipoEvento""> Tipo de Evento</label>
                <");
                WriteLiteral("select id=\"tipoEvento\" name=\"tipoEvento\" required>\r\n\r\n                    ");
                EndContext();
                BeginContext(1361, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ca373683c5c61cc482c3b4fd71be924deea1df6187", async() => {
                    BeginContext(1396, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1414, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 38 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml"
                     foreach (var e in Model.Evento)
                    {

#line default
#line hidden
                BeginContext(1495, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1519, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ca373683c5c61cc482c3b4fd71be924deea1df8654", async() => {
                    BeginContext(1541, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1543, 6, false);
#line 40 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml"
                                          Write(e.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1549, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 40 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml"
                          WriteLiteral(e.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1559, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1584, 163, true);
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"enter\">\r\n                <input type=\"submit\" value=\"Enviar!\">\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 8 "c:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Pedido\Index.cshtml"
AddHtmlAttributeValue("", 228, Url.Action("Registrar","Pedido"), 228, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1754, 25, true);
            WriteLiteral("\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
