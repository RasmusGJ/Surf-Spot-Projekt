#pragma checksum "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa187f17f503ab63230a22388f5428f5215b70b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Spot_ShowSpots), @"mvc.1.0.view", @"/Views/Spot/ShowSpots.cshtml")]
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
#line 1 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\_ViewImports.cshtml"
using surf_spotter_dot_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\_ViewImports.cshtml"
using surf_spotter_dot_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa187f17f503ab63230a22388f5428f5215b70b", @"/Views/Spot/ShowSpots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    public class Views_Spot_ShowSpots : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<surf_spotter_dot_net_core.Models.Spot>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
  
    Layout = "";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
 foreach (var spot in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>adse</td>\r\n            <td>");
#nullable restore
#line 17 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
           Write(Html.DisplayFor(modelItem => spot.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
           Write(Html.DisplayFor(modelItem => spot.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
           Write(Html.DisplayFor(modelItem => spot.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
           Write(Html.DisplayFor(modelItem => spot.Lng));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n    </table>\r\n");
#nullable restore
#line 23 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Spot\ShowSpots.cshtml"
    

}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<surf_spotter_dot_net_core.Models.Spot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
