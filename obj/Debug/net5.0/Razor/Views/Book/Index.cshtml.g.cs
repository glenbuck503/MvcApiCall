#pragma checksum "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c6cb03346b6e2ae95d5f0d87452ed9c280f19cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/_ViewImports.cshtml"
using MvcApiCall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/_ViewImports.cshtml"
using MvcApiCall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c6cb03346b6e2ae95d5f0d87452ed9c280f19cc", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f23a777e9ef0fdfd0407564fbf2dfc5793fb9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>All Books:</h1>\n\n<ol>\n");
#nullable restore
#line 5 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml"
 foreach (Book book in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\n        <li>Title: ");
#nullable restore
#line 8 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml"
              Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Author: ");
#nullable restore
#line 9 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml"
               Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    \n        <li>");
#nullable restore
#line 11 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml"
       Write(Html.ActionLink($"{book.Title}", null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n         \n    </ul>\n    <br>\n");
#nullable restore
#line 15 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\n\n<p>");
#nullable restore
#line 18 "/Users/arthurbuck/Desktop/projects/MvcApiCall/Views/Book/Index.cshtml"
Write(Html.ActionLink("************ Articles ************", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>;");
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
