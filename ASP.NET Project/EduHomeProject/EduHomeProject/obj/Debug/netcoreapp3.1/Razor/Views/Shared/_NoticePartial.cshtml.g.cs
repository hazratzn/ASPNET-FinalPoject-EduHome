#pragma checksum "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\Shared\_NoticePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbaa3f1ec7b29ac5f1d50d340fb378fd0fc8078c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NoticePartial), @"mvc.1.0.view", @"/Views/Shared/_NoticePartial.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbaa3f1ec7b29ac5f1d50d340fb378fd0fc8078c", @"/Views/Shared/_NoticePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25e774d7f99a5c878827c225ab8b49c6da75eb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NoticePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NoticeBoard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n    <div class=\"notice-left-wrapper\">\r\n        <h3>notice board</h3>\r\n        <div class=\"notice-left\">\r\n");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\Shared\_NoticePartial.cshtml"
             foreach (var notice in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 255, "\"", 275, 1);
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\Shared\_NoticePartial.cshtml"
WriteAttributeValue("", 263, notice.Size, 263, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h4>");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\Shared\_NoticePartial.cshtml"
                   Write(notice.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\Shared\_NoticePartial.cshtml"
                  Write(notice.Notice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Asp.net\ASP.NET Project\EduHomeProject\EduHomeProject\Views\Shared\_NoticePartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NoticeBoard>> Html { get; private set; }
    }
}
#pragma warning restore 1591