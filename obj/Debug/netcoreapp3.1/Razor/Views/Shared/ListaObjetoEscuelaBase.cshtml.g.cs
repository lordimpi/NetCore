#pragma checksum "D:\Unicauca\Programacion\Platzi\NetCore\Views\Shared\ListaObjetoEscuelaBase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0d5d98a3e0c4f0cd97143ccc66077a4fc0b8b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetoEscuelaBase), @"mvc.1.0.view", @"/Views/Shared/ListaObjetoEscuelaBase.cshtml")]
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
#line 1 "D:\Unicauca\Programacion\Platzi\NetCore\Views\_ViewImports.cshtml"
using NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Unicauca\Programacion\Platzi\NetCore\Views\_ViewImports.cshtml"
using NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0d5d98a3e0c4f0cd97143ccc66077a4fc0b8b6", @"/Views/Shared/ListaObjetoEscuelaBase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetoEscuelaBase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ObjetoEscuelaBaseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Shared\ListaObjetoEscuelaBase.cshtml"
         foreach (var obj in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 14 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Shared\ListaObjetoEscuelaBase.cshtml"
               Write(obj.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 15 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Shared\ListaObjetoEscuelaBase.cshtml"
               Write(obj.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 17 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Shared\ListaObjetoEscuelaBase.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ObjetoEscuelaBaseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591