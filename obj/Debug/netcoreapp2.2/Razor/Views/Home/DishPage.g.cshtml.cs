#pragma checksum "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "275078e9b5d47a76524bba48f5a2fe4ec52bae1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DishPage), @"mvc.1.0.view", @"/Views/Home/DishPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DishPage.cshtml", typeof(AspNetCore.Views_Home_DishPage))]
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
#line 1 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275078e9b5d47a76524bba48f5a2fe4ec52bae1b", @"/Views/Home/DishPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 24, false);
#line 1 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
Write(ViewBag.dishpage[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(29, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(41, 24, false);
#line 2 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
Write(ViewBag.dishpage[0].Chef);

#line default
#line hidden
            EndContext();
            BeginContext(65, 56, true);
            WriteLiteral("</h2>\r\n<hr>\r\n    <h4><a href=\"/\">Home</a></h4>\r\n    <h4>");
            EndContext();
            BeginContext(122, 31, false);
#line 5 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
   Write(ViewBag.dishpage[0].Description);

#line default
#line hidden
            EndContext();
            BeginContext(153, 25, true);
            WriteLiteral("</h4>\r\n    <h5>Calories: ");
            EndContext();
            BeginContext(179, 28, false);
#line 6 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
             Write(ViewBag.dishpage[0].Calories);

#line default
#line hidden
            EndContext();
            BeginContext(207, 26, true);
            WriteLiteral("</h5>\r\n    <h5>Tastiness: ");
            EndContext();
            BeginContext(234, 29, false);
#line 7 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
              Write(ViewBag.dishpage[0].Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(263, 13, true);
            WriteLiteral("</h5>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 276, "\"", 318, 2);
            WriteAttributeValue("", 283, "/delete/", 283, 8, true);
#line 8 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
WriteAttributeValue("", 291, ViewBag.dishpage[0].DishId, 291, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 30, true);
            WriteLiteral("><button>Delete</a></button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 349, "\"", 389, 2);
            WriteAttributeValue("", 356, "/edit/", 356, 6, true);
#line 8 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\DishPage.cshtml"
WriteAttributeValue("", 362, ViewBag.dishpage[0].DishId, 362, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(390, 34, true);
            WriteLiteral("><button>Edit</button></a>\r\n</div>");
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
