#pragma checksum "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "475b5401f2678e95ee34eb72d4047a8b2a0d86c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_Index), @"mvc.1.0.view", @"/Views/First/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"475b5401f2678e95ee34eb72d4047a8b2a0d86c0", @"/Views/First/Index.cshtml")]
    public class Views_First_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>From the Index view</h1>\r\n<p>\r\n    Name :  ");
#nullable restore
#line 8 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
       Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Age : ");
#nullable restore
#line 10 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
     Write(ViewData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Customer\'s Phone number : ");
#nullable restore
#line 13 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
                         Write(ViewBag.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Price : ");
#nullable restore
#line 15 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
       Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    <h2>\r\n        Post\r\n    </h2>\r\n    ");
#nullable restore
#line 21 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
Write(TempData.Peek("Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    <h2>Numbers using ViewData</h2>\r\n");
#nullable restore
#line 25 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
     foreach (var item in (IEnumerable<int>)ViewData["scores"])
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 29 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>\r\n    <h2>Numbers using ViewBag</h2>\r\n");
#nullable restore
#line 33 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
     foreach (var item in ViewBag.Scores)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 37 "C:\Users\DHESH KUMAAR A\Desktop\softura\day20\MVCWebSolution\MVCWebApplication\Views\First\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
