#pragma checksum "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28bbd2b8e54749dd0009a061fe758bf8d798fd43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Signup), @"mvc.1.0.view", @"/Views/Account/Signup.cshtml")]
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
#line 1 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\_ViewImports.cshtml"
using surf_spotter_dot_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\_ViewImports.cshtml"
using surf_spotter_dot_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28bbd2b8e54749dd0009a061fe758bf8d798fd43", @"/Views/Account/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<surf_spotter_dot_net_core.Models.Account.RegisterViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28bbd2b8e54749dd0009a061fe758bf8d798fd433733", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Login</title>
    <link rel=""stylesheet"" href=""CSS/navBarSheet.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""CSS/loginSheet.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""CSS/footerSheet.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.1/css/all.min.css"">




");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28bbd2b8e54749dd0009a061fe758bf8d798fd435172", async() => {
                WriteLiteral(@"
    <header>
        <nav>
            <div class=""nav-bar"">
                <ul>
                    <li><a href=""Index"">Hjem</a></li>
                    <li><a href=""spots"">spots</a></li>
                    <li><a href=""Aboutus"">Om os</a></li>
                    <li><a href=""Kontakt"">Kontakt</a></li>
                    <li><a href=""login"">Login</a></li>

                </ul>
            </div>
        </nav>
    </header>
    <div class=""login"">
        <div class=""overlay"">
            <video playsinline=""playsinline"" autoplay=""autoplay"" muted=""muted"" loop=""loop"">
                <source src=""Assets/Images/Oceanwaves-login.mp4"" type=""video/mp4"">
            </video>
        </div>

        <div class=""container"">

            <div class=""login-form"">
");
#nullable restore
#line 48 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h2 id=\"reg\">Registrer</h2>\r\n                    <div class=\"inputgroup\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.LabelFor(x => x.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.EditorFor(x => x.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 55 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
                WriteLiteral("                    <div class=\"inputgroup\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.EditorFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 61 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"inputgroup\">\r\n                        ");
#nullable restore
#line 64 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 65 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.EditorFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 66 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n");
                WriteLiteral(@"                    <div class=""inputgroup"">
                        <button type=""submit"" class=""sub"">Registrer</button>
                    </div>
                    <div class=""inputgroup""> 
                        <input type=""button"" class=""sub"" onclick=""location.href = 'login';"" value=""Login"">
                    </div>
");
#nullable restore
#line 76 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Account\Signup.cshtml"
                
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </div>
    </div>
    <footer class=""footer"">
        <div class=""footer-content"">
            <p class=""copyright"">
                Copyright &copy; 2020, Team Y4 - All Rights Reserved
            </p>
            <div class=""social-list"">
                <a href=""#""><i class=""fab fa-facebook-f""></i></a>
                <a href=""#""><i class=""fab fa-instagram""></i></a>
                <a href=""#""><i class=""fab fa-twitter""></i></a>

            </div>

            <script src=""login.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<surf_spotter_dot_net_core.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
