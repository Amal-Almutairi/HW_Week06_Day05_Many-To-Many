#pragma checksum "C:\Users\amalf\source\repos\CodeFirst\Views\Students\Deatails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad40507d8738af1b428d08a1280bf016561d4371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Deatails), @"mvc.1.0.view", @"/Views/Students/Deatails.cshtml")]
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
#line 1 "C:\Users\amalf\source\repos\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amalf\source\repos\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad40507d8738af1b428d08a1280bf016561d4371", @"/Views/Students/Deatails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Deatails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amalf\source\repos\CodeFirst\Views\Students\Deatails.cshtml"
  
    var Students1 = (Student)ViewData["Students1"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>This is details of student</h1>\r\n    <p>Hi, My Name is: ");
#nullable restore
#line 6 "C:\Users\amalf\source\repos\CodeFirst\Views\Students\Deatails.cshtml"
                  Write(Students1.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and my Last Name is: ");
#nullable restore
#line 6 "C:\Users\amalf\source\repos\CodeFirst\Views\Students\Deatails.cshtml"
                                                            Write(Students1.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" And my email is : ");
#nullable restore
#line 6 "C:\Users\amalf\source\repos\CodeFirst\Views\Students\Deatails.cshtml"
                                                                                                  Write(Students1.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
