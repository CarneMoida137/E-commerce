#pragma checksum "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715a242578c506f2c904bf304bd5eca9b54afd13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#nullable restore
#line 1 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\_ViewImports.cshtml"
using MeuIngresso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\_ViewImports.cshtml"
using MeuIngresso.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715a242578c506f2c904bf304bd5eca9b54afd13", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64768ee06324619b53a4066204afe5353822db8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 4 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 10 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
                     Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <table class=\"table table-hover\">\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 14 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
           Write(Model.IdCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
           Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", "\r\n                   href=\"", 367, "\"", 426, 2);
            WriteAttributeValue("", 394, "/cliente/delete/", 394, 16, true);
#nullable restore
#line 19 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 410, Model.IdCliente, 410, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", "\r\n                   href=\"", 489, "\"", 548, 2);
            WriteAttributeValue("", 516, "/cliente/update/", 516, 16, true);
#nullable restore
#line 21 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 532, Model.IdCliente, 532, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 25 "F:\Linguagem de programação PROJETO\MeuIngresso\MeuIngresso\Views\Cliente\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/cliente/create\">Adicionar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
