#pragma checksum "C:\Users\Harold\source\repos\sistran\sistran\Views\Asegurado\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e47e6ed38114b0d6c926879267c746d5403d1e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asegurado_index), @"mvc.1.0.view", @"/Views/Asegurado/index.cshtml")]
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
#line 1 "C:\Users\Harold\source\repos\sistran\sistran\Views\_ViewImports.cshtml"
using sistran;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Harold\source\repos\sistran\sistran\Views\_ViewImports.cshtml"
using sistran.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e47e6ed38114b0d6c926879267c746d5403d1e1", @"/Views/Asegurado/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03fa1c196c80543f212609a9c716ee5d74ef8542", @"/Views/_ViewImports.cshtml")]
    public class Views_Asegurado_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Harold\source\repos\sistran\sistran\Views\Asegurado\index.cshtml"
  
    ViewData["Title"] = "Asegurado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Asegurado</h1>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>Apellidos</th>
            <th>Fecha de Nacimiento</th>
            <th>Edad</th>
            <th>Estado Civil</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\".table\").DataTable({\r\n            \"ajax\": {\r\n                \"url\":\r\n            }\r\n        });\r\n    });\r\n    </script>\r\n");
            }
            );
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