#pragma checksum "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be7ac63cc792df5a3da08427ad339c01c84e183f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bank_CreateClient), @"mvc.1.0.view", @"/Views/Bank/CreateClient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be7ac63cc792df5a3da08427ad339c01c84e183f", @"/Views/Bank/CreateClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a24889690ada020b2e493630e2c0181fe3b54a63", @"/Views/_ViewImports.cshtml")]
    public class Views_Bank_CreateClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bank.ViewModels.ClientViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
  
    ViewData["Title"] = "Clients";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
 using(Html.BeginForm("CreateOneClient", "Bank", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n        <h1 class=\"display-4\">Log in</h1>\n        <div class=\"text-center\">\n            ");
#nullable restore
#line 11 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 12 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 13 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"text-center\">\n            ");
#nullable restore
#line 16 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.LabelFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 17 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.EditorFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"text-center\">\n            ");
#nullable restore
#line 20 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.LabelFor(model => model.PassportNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 21 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.EditorFor(model => model.PassportNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"text-center\">\n            ");
#nullable restore
#line 24 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.LabelFor(model => model.PassportSeries));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 25 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.EditorFor(model => model.PassportSeries));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"text-center\">\n            ");
#nullable restore
#line 28 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.LabelFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 29 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.EditorFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"text-center\">\n            ");
#nullable restore
#line 32 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 33 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
       Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <input type=\"submit\" name=\"submit\" id=\"submit\" class=\"form-submit\" value=\"Submit\"/>\n    </div>\n");
#nullable restore
#line 37 "/home/vladislav/Рабочий стол/dima/Bank/Views/Bank/CreateClient.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bank.ViewModels.ClientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
