#pragma checksum "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\MasterProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20dd058956f3c27d6d141db82c8b6afe6474c10c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MasterProduct_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MasterProduct/Index.cshtml")]
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
#line 1 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Framework.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Core.Resources.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Core.Domain.Masters.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Endpoints.WebUI.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Core.Domain.Masters.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Terme.Core.Domain.Masters.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dd058956f3c27d6d141db82c8b6afe6474c10c", @"/Areas/Admin/Views/MasterProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c90a04cb39a351e0a659b662153f570070bfb3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MasterProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DtoPassRequestToViewComponentProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\MasterProduct\Index.cshtml"
  
    ViewData["Title"] = _resourceManager[SharedResource.MasterProducts];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Alireza\source\repos\Terme\03. EndPoints\Terme.Endpoints.WebUI\Areas\Admin\Views\MasterProduct\Index.cshtml"
Write(await Component.InvokeAsync("Products", new
{

    //Set by Designer(static values)
    numberOfProducts = 9,
    EnabledPaging = true,
    EnabledSorting = true,
    Title = @_resourceManager[SharedResource.MasterProducts],

    //Set by Request parameters
    pageNumber = Model.CurrentPage,
    TextSeach = Model.TextSeach,
    MasterId = Model.MasterId,
    CategoryId = Model.CategoryId,
    OrderBy = Model.OrderByProduct

}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DtoPassRequestToViewComponentProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
