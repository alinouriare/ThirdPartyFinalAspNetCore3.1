#pragma checksum "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "103884338130a46116aa1484aa3781387e3fd248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Completed), @"mvc.1.0.view", @"/Views/Order/Completed.cshtml")]
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
#line 1 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Framework.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Core.Resources.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Core.Domain.Masters.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Core.Domain.Masters.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Core.Domain.Masters.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI.Infrastructures;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"103884338130a46116aa1484aa3781387e3fd248", @"/Views/Order/Completed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb7b61df1ab87e98cee8fd19e4379794a6f246d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Completed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Terme.Core.Domain.Orders.Entities.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
  
    ViewData["Title"] = @_resourceManager[SharedResource.OrderCompeleted];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container py-4\">\r\n    <div class=\"text-center text-success\">\r\n        <span class=\"mdi mdi-check-circle-outline mdi-48px\"></span>\r\n        <h4>");
#nullable restore
#line 10 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
       Write(_resourceManager[SharedResource.OrderRegistered]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"text-center mt-4\">\r\n        <div class=\"mb-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
       Write(_resourceManager[SharedResource.OrderId]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <span class=\"font-weight-bold\">");
#nullable restore
#line 14 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
                                                                                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 17 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
       Write(_resourceManager[SharedResource.TotalPrice]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <span class=\"font-weight-bold\">");
#nullable restore
#line 17 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
                                                                                    Write(Model.OrderLines.Sum(c => c.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "103884338130a46116aa1484aa3781387e3fd2488747", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 875, "\"", 892, 1);
#nullable restore
#line 20 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
WriteAttributeValue("", 883, Model.Id, 883, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"orderId\" />\r\n            <input type=\"submit\" class=\"btn btn-success\"");
                BeginWriteAttribute("value", " value=\"", 969, "\"", 1020, 1);
#nullable restore
#line 21 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Order\Completed.cshtml"
WriteAttributeValue("", 977, _resourceManager[SharedResource.DoPayment], 977, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IResourceManager _resourceManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Terme.Core.Domain.Orders.Entities.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591