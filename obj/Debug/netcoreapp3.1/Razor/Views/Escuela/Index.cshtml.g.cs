#pragma checksum "D:\Unicauca\Programacion\Platzi\NetCore\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fe73730a48781d496cfd3fc30ccc05fadd71d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe73730a48781d496cfd3fc30ccc05fadd71d03", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EscuelaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "School Information";
    Layout = "Simple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Escuela </h1>\r\n<h2>Nombre: ");
#nullable restore
#line 9 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p><strong>Año fundacion: ");
#nullable restore
#line 10 "D:\Unicauca\Programacion\Platzi\NetCore\Views\Escuela\Index.cshtml"
                     Write(Model.AnioFundacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EscuelaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
