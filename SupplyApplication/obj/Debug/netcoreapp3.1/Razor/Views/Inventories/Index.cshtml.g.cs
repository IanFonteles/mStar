#pragma checksum "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef0fc33bda42b3ed4d6329ad7eba0e244dccc30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventories_Index), @"mvc.1.0.view", @"/Views/Inventories/Index.cshtml")]
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
#line 1 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\_ViewImports.cshtml"
using SupplyApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\_ViewImports.cshtml"
using SupplyApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef0fc33bda42b3ed4d6329ad7eba0e244dccc30", @"/Views/Inventories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2197762885a7748b8795eca24f4f98f3ff1347", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SupplyApplication.Models.Inventory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Estoque</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InventoryQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InventoryQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\ian_l\source\repos\SupplyApplication\SupplyApplication\Views\Inventories\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SupplyApplication.Models.Inventory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
