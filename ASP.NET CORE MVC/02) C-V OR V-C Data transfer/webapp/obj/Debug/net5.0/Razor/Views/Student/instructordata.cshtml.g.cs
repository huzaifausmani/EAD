#pragma checksum "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b6e316c4848d0c47dc880a20b35c93def545d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_instructordata), @"mvc.1.0.view", @"/Views/Student/instructordata.cshtml")]
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
#line 1 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\_ViewImports.cshtml"
using webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b6e316c4848d0c47dc880a20b35c93def545d0", @"/Views/Student/instructordata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9199b4e53545c67bd84ad2eaa2357bc02933d8df", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_instructordata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<webapp.Models.Instructor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
  
    ViewData["Title"] = "Instructor Data";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>

<h2 class=""text-center"">Data for Instructors</h2>
<table border=""2"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Subject</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h1>");
#nullable restore
#line 32 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
Write(ViewBag.x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 33 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\02) C-V OR V-C Data transfer\webapp\Views\Student\instructordata.cshtml"
Write(ViewData["data"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<webapp.Models.Instructor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
