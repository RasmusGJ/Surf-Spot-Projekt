#pragma checksum "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d397695e06b5fbc76cfef43db5a4bb08919308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowUsers), @"mvc.1.0.view", @"/Views/Home/ShowUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d397695e06b5fbc76cfef43db5a4bb08919308", @"/Views/Home/ShowUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_ShowUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
  
    ViewData["Title"] = "ShowUsers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> All Users :</h1>\r\n");
#nullable restore
#line 9 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
 foreach (User user in ViewBag.Users)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <label>Username: </label>\r\n        ");
#nullable restore
#line 13 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
   Write(user.UserName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n\r\n        <label>email: </label>\r\n        ");
#nullable restore
#line 16 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
   Write(user.Email.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n\r\n        <label>password: </label>\r\n        ");
#nullable restore
#line 19 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
   Write(user.Password.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n");
#nullable restore
#line 21 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\ShowUsers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
