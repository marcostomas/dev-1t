#pragma checksum "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee62b66c329831b5b341a9a975674dfc6c798c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee62b66c329831b5b341a9a975674dfc6c798c27", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("toggleMobileMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logoff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Historico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(40, 1008, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee62b66c329831b5b341a9a975674dfc6c798c275779", async() => {
                BeginContext(46, 647, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Rolê Top</title>
    <!--Favicon-->
    <link href=""img/logo.png"" rel=""icon"" type=""image/x-icon"" />
    <!--Importar fontes do Google-->
    <link href=""https://fonts.googleapis.com/css?family=Fredoka+One&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Londrina+Solid:900%7COpen+Sans"" rel=""stylesheet"">
    <!--Importar folha CSS-->
    <link href=""css/index.css"" rel=""stylesheet"" type=""text/css"">

    <!-- CONCLUIR -->
");
                EndContext();
#line 18 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
     if(!"Home".Equals(@Model.NomeView))
    {

#line default
#line hidden
                BeginContext(742, 168, true);
                WriteLiteral("        <link href=\"\"rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"\"rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"\"rel=\"stylesheet\" type=\"text/css\">\r\n");
                EndContext();
#line 23 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
                BeginContext(917, 124, true);
                WriteLiteral("    <!-- Importar o Font Awesome para o projeto -->\r\n    <script src=\"https://kit.fontawesome.com/349a64cb04.js\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1048, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1052, 3072, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee62b66c329831b5b341a9a975674dfc6c798c278522", async() => {
                BeginContext(1058, 606, true);
                WriteLiteral(@"
    <header>
        <nav>
            <div class=""section-container"">

                <a href=""#"">
                    <img src=""img/logo.png"" alt=""Logo Rolê Top"" title=""Logo"">
                </a>
                <ul>
                    <li id=""bt-mobile-menu"">
                        <!-- HTML para colocar os ícones do FA -->
                        <a href=""javascript:void(0);"" class=""icon"" onclick=""toggleMobileMenu()"">
                            <i class=""fas fa-bars""></i>
                        </a>
                    </li>

                    <li class=""bt-common-menu"">");
                EndContext();
                BeginContext(1664, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee62b66c329831b5b341a9a975674dfc6c798c279533", async() => {
                    BeginContext(1752, 9, true);
                    WriteLiteral("Principal");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1765, 85, true);
                WriteLiteral("</li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1850, "\'", 1891, 2);
#line 45 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1857, Url.Action("Index", "Home"), 1857, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 1885, "#sobre", 1885, 6, true);
                EndWriteAttribute();
                BeginContext(1892, 95, true);
                WriteLiteral(">Sobre</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1987, "\'", 2034, 2);
#line 46 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1994, Url.Action("Index", "Home"), 1994, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 2022, "#localizacao", 2022, 12, true);
                EndWriteAttribute();
                BeginContext(2035, 101, true);
                WriteLiteral(">Localização</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2136, "\'", 2175, 1);
#line 47 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2143, Url.Action("Index", "Convites"), 2143, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2176, 98, true);
                WriteLiteral(">Convites</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2274, "\'", 2320, 1);
#line 48 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2281, Url.Action("Index", "ProximosEventos"), 2281, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2321, 94, true);
                WriteLiteral(">Próximos Eventos</a></li>\r\n                    \r\n                    \r\n                    \r\n");
                EndContext();
#line 52 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
                     if(string.IsNullOrEmpty(@Model.UsuarioEmail))
                    {

#line default
#line hidden
                BeginContext(2506, 82, true);
                WriteLiteral("                        <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2588, "\'", 2630, 2);
#line 54 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2595, Url.Action("Index", "Login"), 2595, 29, false);

#line default
#line hidden
                WriteAttributeValue("", 2624, "#login", 2624, 6, true);
                EndWriteAttribute();
                BeginContext(2631, 17, true);
                WriteLiteral(">Login</a></li>\r\n");
                EndContext();
#line 55 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(2720, 51, true);
                WriteLiteral("                        <li class=\"bt-common-menu\">");
                EndContext();
                BeginContext(2771, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee62b66c329831b5b341a9a975674dfc6c798c2715182", async() => {
                    BeginContext(2848, 6, true);
                    WriteLiteral("Logoff");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2858, 58, true);
                WriteLiteral("</li>\r\n                        <li class=\"bt-common-menu\">");
                EndContext();
                BeginContext(2916, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee62b66c329831b5b341a9a975674dfc6c798c2717004", async() => {
                    BeginContext(2996, 16, true);
                    WriteLiteral("Eventos Marcados");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3016, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 60 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
                BeginContext(3046, 42, true);
                WriteLiteral("                    <li><a id=\"bt-peca_ja\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 3088, "\'", 3124, 1);
#line 61 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3095, Url.Action("Index","Pedido"), 3095, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3125, 139, true);
                WriteLiteral(">Agende Já</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n        <!-- Não esquecer de realocar aquia logo area -->\r\n");
                EndContext();
#line 66 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
         if("Home".Equals(@Model.NomeView))
        {
            Html.RenderPartial("_HeaderHomePage");
        }

#line default
#line hidden
                BeginContext(3383, 21, true);
                WriteLiteral("    </header>\r\n\r\n    ");
                EndContext();
                BeginContext(3405, 12, false);
#line 72 "C:\Users\44036901818\Documents\1º Termo\dev-1t\SPRINT 4\RoletopMVC\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3417, 700, true);
                WriteLiteral(@"

    <footer>      
        <div class=""footer-container"">
            <div class=""footer-left-container"">
                <address>
                    Alameda Barão de Limeira, 539 <br>
                    Campos Elíseos - Sampa <br>
                    roletop@email.com <br>
                    11 3250 0000 <br>
                </address>
                
            </div>
                <div class=""footer-center-container"">
                    <a href=""https://pt-br.facebook.com""><i class=""fab fa-facebook""></i>/roletop</a>
                    <a href=""https://instagram.com""><i class=""fab fa-instagram""></i>/roletop</a>
            </div>
        </div>
    </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
