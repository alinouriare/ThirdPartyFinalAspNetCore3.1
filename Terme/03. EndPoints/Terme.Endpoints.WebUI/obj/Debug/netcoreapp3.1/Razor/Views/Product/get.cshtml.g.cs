#pragma checksum "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "629fefd889e1c4a463effc4d53410090c5c8443e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_get), @"mvc.1.0.view", @"/Views/Product/get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629fefd889e1c4a463effc4d53410090c5c8443e", @"/Views/Product/get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb7b61df1ab87e98cee8fd19e4379794a6f246d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DtoProductDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/OwlCarousel2-2.3.4/dist/assets/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/OwlCarousel2-2.3.4/dist/assets/owl.theme.default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/OwlCarousel2-2.3.4/dist/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Master", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
  
    ViewData["Title"] = @_resourceManager[SharedResource.ProductDetails];
    if (Model.PhotoUrlCollection.Count == 0)
        Model.PhotoUrlCollection.Add(Model.MainPhoto);

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "629fefd889e1c4a463effc4d53410090c5c8443e9024", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "629fefd889e1c4a463effc4d53410090c5c8443e10202", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "629fefd889e1c4a463effc4d53410090c5c8443e11502", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $('.owl-carousel').owlCarousel({
            loop: true,
            dots: true,
            nav: false,
            margin: 10,
            responsiveClass: true,
            responsive: {
                0: {
                    items: 1
                },
                768: {
                    items: 3
                },
                992: {
                    items: 4
                }
            }
        })
    </script>
");
            }
            );
            WriteLiteral("<div class=\"container mt-3\">\r\n");
            WriteLiteral(@"    <div class=""rounded border"">
        <div class=""row"">
            <div class=""col-md-6 d-flex"">
                <div id=""carouselExampleIndicators"" class=""carousel slide d-flex align-items-center"" data-ride=""carousel"">
                    <div class=""carousel-inner align-items-center justify-content-center"">
");
#nullable restore
#line 44 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                          int cntRows = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                         foreach (var imgUrl in Model.PhotoUrlCollection)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1666, "\"", 1716, 2);
            WriteAttributeValue("", 1674, "carousel-item", 1674, 13, true);
#nullable restore
#line 47 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
WriteAttributeValue(" ", 1687, cntRows==0? "active" : "", 1688, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"d-block w-50 \"");
            BeginWriteAttribute("src", " src=\"", 1778, "\"", 1791, 1);
#nullable restore
#line 48 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
WriteAttributeValue("", 1784, imgUrl, 1784, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                            cntRows += 1;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 55 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                          int cnt = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                         foreach (var imgUrl in Model.PhotoUrlCollection)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 58 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                                                                                   Write(cnt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 2222, "\"", 2255, 1);
#nullable restore
#line 58 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
WriteAttributeValue("", 2230, cnt ==0 ? "active" :"", 2230, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 59 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                            cnt = cnt + 1;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ol>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""bg-light p-4"">
                    <div class=""mb-3"">
                        <h5 class=""mb-1"">
                            ");
#nullable restore
#line 76 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <div class=\"text-muted d-block\"><small class=\"ml-2\">استاد</small>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "629fefd889e1c4a463effc4d53410090c5c8443e18327", async() => {
#nullable restore
#line 78 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                                                                                                                                                               Write(Model.MasterFullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                                                                                                                                       WriteLiteral(Model.MasterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"mb-3\">\r\n                        ");
#nullable restore
#line 81 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                   Write(_resourceManager[SharedResource.CategoryName]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        ");
#nullable restore
#line 82 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                   Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <p class=\"text-justify text-muted\">\r\n                        ");
#nullable restore
#line 85 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                   Write(Html.Raw(@Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""d-flex flex-column align-items-center justify-content-between mt-5"">
                        <div class=""d-flex align-items-center mb-2"">
                            <h5 class=""font-weight-bold ml-2"">");
#nullable restore
#line 89 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                                                         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"text-muted\">ریال</small></h5>\r\n                            <del class=\"text-muted\">");
#nullable restore
#line 90 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                                               Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                        </div>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "629fefd889e1c4a463effc4d53410090c5c8443e23198", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4409, "\"", 4433, 1);
#nullable restore
#line 95 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
WriteAttributeValue("", 4417, Model.ProductId, 4417, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\r\n                                   value=\"", 4504, "\"", 4595, 1);
#nullable restore
#line 97 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
WriteAttributeValue("", 4548, ViewContext.HttpContext.Request.PathAndQuery(), 4548, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <button type=""submit""
                                    class=""btn btn-success btn-sm d-flex align-items-center"">
                                <span class=""mdi mdi-cart-plus mdi-18px ml-2""></span>
                                ");
#nullable restore
#line 101 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
                           Write(_resourceManager[SharedResource.AddToCart]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </button>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 93 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
AddHtmlAttributeValue("", 4234, Model.ProductId, 4234, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 116 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Views\Product\get.cshtml"
Write(await Component.InvokeAsync("Products",
    new
        {
        numberOfProducts = 9,
        EnabledPaging = false,
        EnabledSorting = false,
        Title = _resourceManager[SharedResource.LatestProduct],
        DisplayModeProducts = EnumDisplayModeProducts.Slider
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DtoProductDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
