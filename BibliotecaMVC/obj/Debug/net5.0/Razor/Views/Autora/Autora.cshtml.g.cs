#pragma checksum "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\Autora\Autora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73fc1e9ee536a358571af82de1167b4e80796107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autora_Autora), @"mvc.1.0.view", @"/Views/Autora/Autora.cshtml")]
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
#line 1 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\_ViewImports.cshtml"
using BibliotecaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\_ViewImports.cshtml"
using BibliotecaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73fc1e9ee536a358571af82de1167b4e80796107", @"/Views/Autora/Autora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754068e205fb75f1f1a1e44ec2818872f5e92324", @"/Views/_ViewImports.cshtml")]
    public class Views_Autora_Autora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BibliotecaMVC.Autora>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\Autora\Autora.cshtml"
  
    ViewData["Title"] = "Autora";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Autora</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\Autora\Autora.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\Autora\Autora.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\Autora\Autora.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "D:\Dev\WCC\BibliotecaMVC\BibliotecaMVC\Views\Autora\Autora.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BibliotecaMVC.Autora>> Html { get; private set; }
    }
}
#pragma warning restore 1591
