#pragma checksum "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae4d412e32b0e1655991f4d5f7f626b18a94fad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditSpot), @"mvc.1.0.view", @"/Views/Home/EditSpot.cshtml")]
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
#line 1 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\_ViewImports.cshtml"
using surf_spotter_dot_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\_ViewImports.cshtml"
using surf_spotter_dot_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae4d412e32b0e1655991f4d5f7f626b18a94fad5", @"/Views/Home/EditSpot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_EditSpot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<surf_spotter_dot_net_core.Models.Spot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Spot</h2>\r\n\r\n<h4>");
#nullable restore
#line 12 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 15 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>Department</h4>\r\n            ");
#nullable restore
#line 21 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.HiddenFor(model => model.RowVersion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 27 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Model.Lat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.EditorFor(model => model.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 30 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Model.Lng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.EditorFor(model => model.Lng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 33 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Model.SpotStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 34 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
       Write(Html.EditorFor(model => model.SpotStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\EditSpot.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<surf_spotter_dot_net_core.Models.Spot> Html { get; private set; }
    }
}
#pragma warning restore 1591
