#pragma checksum "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96ecd894f8f2afd5642756f7a14f88f09f9d509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96ecd894f8f2afd5642756f7a14f88f09f9d509", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 116, true);
            WriteLiteral("<h1>Welcome to CRUDelicious</h1>\r\n<h5><a href=\"/new\">Add a Dish</a></h5>\r\n<h3>Check out some recent dishes!</h3>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\Index.cshtml"
 for(int i = @ViewBag.AllDishes.Count-1; i >= 0 ; i --)
{

#line default
#line hidden
            BeginContext(176, 10, true);
            WriteLiteral("    <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 186, "\"", 221, 1);
#line 7 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 193, ViewBag.AllDishes[i].DishId, 193, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(222, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(224, 25, false);
#line 7 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\Index.cshtml"
                                          Write(ViewBag.AllDishes[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(249, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(258, 25, false);
#line 7 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\Index.cshtml"
                                                                            Write(ViewBag.AllDishes[i].Chef);

#line default
#line hidden
            EndContext();
            BeginContext(283, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 8 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\CRUDelicious\Views\Home\Index.cshtml"

} 

#line default
#line hidden
            BeginContext(296, 2, true);
            WriteLiteral("\r\n");
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
