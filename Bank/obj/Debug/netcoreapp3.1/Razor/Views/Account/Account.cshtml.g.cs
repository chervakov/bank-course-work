#pragma checksum "/home/vladislav/Рабочий стол/dima/Bank/Views/Account/Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e78e7e00ef57afcb97363d28b5fde1b38e3fea54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Account), @"mvc.1.0.view", @"/Views/Account/Account.cshtml")]
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
#line 1 "/home/vladislav/Рабочий стол/dima/Bank/Views/_ViewImports.cshtml"
using Bank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/vladislav/Рабочий стол/dima/Bank/Views/_ViewImports.cshtml"
using Bank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78e7e00ef57afcb97363d28b5fde1b38e3fea54", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a24889690ada020b2e493630e2c0181fe3b54a63", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.Models.Worker>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/vladislav/Рабочий стол/dima/Bank/Views/Account/Account.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">");
#nullable restore
#line 7 "/home/vladislav/Рабочий стол/dima/Bank/Views/Account/Account.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "/home/vladislav/Рабочий стол/dima/Bank/Views/Account/Account.cshtml"
                                 Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <div class=\"text-center\">\n        <label> Email: ");
#nullable restore
#line 9 "/home/vladislav/Рабочий стол/dima/Bank/Views/Account/Account.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\n    </div>\n    <div class=\"text-center\">\n        <label> Role: ");
#nullable restore
#line 12 "/home/vladislav/Рабочий стол/dima/Bank/Views/Account/Account.cshtml"
                 Write(Model.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bank.Models.Worker> Html { get; private set; }
    }
}
#pragma warning restore 1591
