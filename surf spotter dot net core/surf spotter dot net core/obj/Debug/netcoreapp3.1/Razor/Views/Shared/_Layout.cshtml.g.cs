#pragma checksum "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450771b0f8e72a4b0f031acba5fad3e6aaf392d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450771b0f8e72a4b0f031acba5fad3e6aaf392d6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/CSS/spotsGallery.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450771b0f8e72a4b0f031acba5fad3e6aaf392d65346", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Surf Spotter</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <meta name=""viewport"" content=""width-device, initial scale=1.0"">
    <link rel=""stylesheet"" type=""text/css"" href=""CSS/navBarSheet.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""CSS/myStyleSheet.css"" />
    <link rel=""stylesheet"" href=""CSS/footerSheet.css"">
    <link rel=""stylesheet"" href=""CSS/aboutUsSheet.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""CSS/contactSheet.css"" type=""text/css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "450771b0f8e72a4b0f031acba5fad3e6aaf392d66266", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.1/css/all.min.css"">

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.min.css"">

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
            WriteLiteral(@"

<header>
    <div class=""nav-bar"">
        <nav>
            <ul>
                <li><a href=""Index"">Hjem</a></li>
                <li><a href=""spots"">Spots</a></li>
                <li><a href=""Aboutus"">Om os</a></li>
                <li><a href=""Kontakt"">Kontakt</a></li>
                <li>
");
#nullable restore
#line 32 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450771b0f8e72a4b0f031acba5fad3e6aaf392d69341", async() => {
                WriteLiteral("\r\n                            <a href=\"javascript: $(\'#logout\').submit()\" class=\"last\">\r\n                            Logout\r\n                                <span style=\"margin-left:10px;\"class=\"tagline\">");
#nullable restore
#line 37 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
                                                                          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </a>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 1620, Url.Action("Logout", "Account"), 1620, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2065, "\"", 2103, 1);
#nullable restore
#line 43 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2072, Url.Action("Login", "Account"), 2072, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"log in\" class=\"last\">\r\n                            Login\r\n                        </a>\r\n");
#nullable restore
#line 46 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </li>
                </ul>
        </nav>
    </div>
    <div class=""overlay"">
        <video playsinline=""playsinline"" autoplay=""autoplay"" muted=""muted"" loop=""loop"">
            <source src=""Assets/Images/Header.mp4"" type=""video/mp4"">
        </video>
    </div>
    <svg class=""wave"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 320"">
        <path fill=""white"" fill-opacity=""1"" d=""M0,256L48,229.3C96,203,
            192,149,288,154.7C384,160,480,224,576,218.7C672,213,768,139,864,
            128C960,117,1056,171,1152,197.3C1248,224,1344,224,1392,224L1440,
            224L1440,320L1392,320C1344,320,1248,320,1152,320C1056,320,960,320,
            864,320C768,320,672,320,576,320C480,320,384,320,288,320C192,320,96,
            320,48,320L0,320Z""></path>
    </svg>



    <button class=""goToBody"" href=""#infoImage1""><i class=""fas fa-arrow-down fa-2x""></i></button>

</header>

");
#nullable restore
#line 71 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

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
    </div>
</footer>
");
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
