#pragma checksum "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\6) Layout sections\webapp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f14051a3a4e56ca6299e593fff1838f4f572866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\6) Layout sections\webapp\Views\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\6) Layout sections\webapp\Views\_ViewImports.cshtml"
using webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f14051a3a4e56ca6299e593fff1838f4f572866", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9199b4e53545c67bd84ad2eaa2357bc02933d8df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\6) Layout sections\webapp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("s1", async() => {
                WriteLiteral("\r\n    <p>This is upper section.</p>\r\n");
            }
            );
            DefineSection("s2", async() => {
                WriteLiteral("\r\n    <p>This is lower section</p>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("addNewStyling", async() => {
                WriteLiteral("\r\n    <style>\r\n        h1\r\n        {\r\n            font-weight: bold;\r\n            text-decoration: underline;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4\">Welcome to Layout section.</h1>\r\n</div>\r\n");
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
