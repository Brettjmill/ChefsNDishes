#pragma checksum "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da50b813d0dff1f394bf5a2d235ea661cb3ed057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#line 1 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da50b813d0dff1f394bf5a2d235ea661cb3ed057", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Yum, take a look at our tasty dishes!</h1>
<br>
<a href=""/dish/new"">Add a Dish</a>
<hr>
<div>
    <table class=""table table-bordered"">
        <thead class=""table-dark"">
            <tr>
                <td>Name</td>
                <td>Chef</td>
                <td>Tastiness</td>
                <td>Calories</td>
            </tr>
        </thead>
        <tbody class=""table-striped"">
");
#nullable restore
#line 18 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
         foreach(Dish dish in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
               Write(dish.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
               Write(dish.DishCreator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
                                           Write(dish.DishCreator.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
               Write(dish.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
               Write(dish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\ChefsNDishes\Views\Home\Dishes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
