#pragma checksum "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a644d4099a7e172d337e665619be66d6baf8f909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_spots), @"mvc.1.0.view", @"/Views/Home/spots.cshtml")]
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
#line 1 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\_ViewImports.cshtml"
using surf_spotter_dot_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\_ViewImports.cshtml"
using surf_spotter_dot_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a644d4099a7e172d337e665619be66d6baf8f909", @"/Views/Home/spots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_spots : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<surf_spotter_dot_net_core.Models.Spot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hero-text\">\r\n        <h1>Spots</h1>\r\n    </div>\r\n");
            WriteLiteral(@"
<!--Hentning af google api og placering af markers. Evt infobokse. Fungere ikke optimalt endnu....-->
<div class=""maps"" id=""googleMap""></div>
<script>
    var map;
    var centerCords = {
        lat: 55.3980029,
        lng: 10.3814147
    };

    var markerLocations = [{
        lat: 57.044290,
        lng: 8.480431,
        title: 'Klitmøller Strand',
    },
    {
        lat: 56.010760,
        lng: 8.106947,
        title: 'Ringkøbing Fjord',
    }
        ,
    {
        lat: 22.039073,
        lng: -159.335492,
        title: 'Kauai',
    }
        ,
    {
        lat: 20.898691,
        lng: -156.444709,
        title: 'Maui',
    }
        ,
    {
        lat: -28.042766,
        lng: 153.438623,
        title: 'Gold Coast',
    }
        ,
    {
        lat: 57.363698,
        lng: 9.696541,
        title: 'Løkken',
    }
    ];

    var airPressureValue = "" "";
    var airTemperatureValue = "" "";
    var windSpeedValue = "" "";
    var probPercipitation");
            WriteLiteral(@"Value = "" "";
    var contentHTML = "" "";

    function dataHentning(lat, lng, title) {
        //console.log(lat + "" : "" + lng);
        fetch('https://api.met.no/weatherapi/locationforecast/2.0/compact.json?lat=' + lat + '&lon=' + lng)
            .then(response => response.json())
            .then(data => {
                //console.log(data)
                airPressureValue = data['properties']['timeseries']['0']['data']['instant']['details']['air_pressure_at_sea_level'];
                airTemperatureValue = data['properties']['timeseries']['0']['data']['instant']['details']['air_temperature'];
                windSpeedValue = data['properties']['timeseries']['0']['data']['instant']['details']['wind_speed'];
                probPercipitationValue = data['properties']['timeseries']['0']['data']['instant']['details']['wind_speed'];
            })

            .catch(err => alert(""error""))
        contentHTML =
            ""<div class='infowindowHeader'>"" +
            ""<h2>"" + title + ""</h");
            WriteLiteral(@"2>"" +
            ""</div>"" +
            ""<table>"" +
            ""<tr>"" +
            ""<td>Wave Height: </td>"" +
            ""<td>"" + airTemperatureValue + ""</td>"" +
            ""</tr>"" +
            ""<tr> "" +
            ""<td>Wave Period: </td>"" +
            ""<td>asd</td>"" +
            ""</tr>"" +
            ""<tr>"" +
            ""<td>Wind Speed: </td>"" +
            ""<td>asd</td>"" +
            ""</tr>"" +
            ""<tr>"" +
            ""<td>Water Temperature: </td>"" +
            ""<td>asd</td>"" +
            ""</tr>"" +
            ""<tr>"" +
            ""<td>Weather assesment: </td>"" +
            ""<td>asd</td>"" +
            ""</tr>"" +
            ""</table>"";
        return contentHTML;
    }

    function myMap() {
        map = new google.maps.Map(document.getElementById(""googleMap""), {
            center: centerCords,
            zoom: 6.5,
            mapTypeId: google.maps.MapTypeId.SATELLITE,
            disableDefaultUI: true
        });

        var infowindow = new ");
            WriteLiteral(@"google.maps.InfoWindow();

        for (var i = 0; i < markerLocations.length; i++) {
            var marker = new google.maps.Marker({
                position: markerLocations[i],
                map: map,
                title: markerLocations[i].title
            });
            google.maps.event.addListener(marker, 'click', (function (marker, i) {
                return function () {
                    infowindow.setContent(dataHentning(markerLocations[i].Lat, markerLocations[i].Lng, markerLocations[i].Name));
                    infowindow.open(map, marker);
                }
            })(marker, i));
        }
    }

</script>

<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAzdejVAEmRXr66UrCtX_CWKzjZ4C0fXCA&callback=myMap""
        type=""text/javascript"">
</script>

<div class=""vejr-tabel"">

    <table>
        <tr>
            <td></td>
            <td>Torsdag</td>
            <td>Fredag</td>
            <td>Lørdag</td>
        </tr>

        <tr>
  ");
            WriteLiteral(@"          <td>Wind Speed</td>
            <td>12*</td>
            <td>123</td>
            <td>123</td>
        </tr>
        <tr>
            <td>Wave Length</td>
            <td>123</td>
            <td>123</td>
            <td>123</td>
        </tr>
        <tr>
            <td>Water Temperature</td>
            <td>123</td>
            <td>123</td>
            <td>123</td>
        </tr>
        <tr>
            <td>Air Temperature</td>
            <td>23</td>
            <td>123</td>
            <td>123</td>
        </tr>

    </table>

</div>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 176 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 179 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.DisplayNameFor(model => model.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 182 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.DisplayNameFor(model => model.Lng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 185 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.DisplayNameFor(model => model.SpotStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 191 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 195 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 198 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 201 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lng));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 204 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
               Write(Html.DisplayFor(modelItem => item.SpotStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a644d4099a7e172d337e665619be66d6baf8f90912761", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 207 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                                           WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a644d4099a7e172d337e665619be66d6baf8f90914960", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a644d4099a7e172d337e665619be66d6baf8f90917165", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 209 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 212 "D:\Github\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<div class=""gallery-section"">
    <div class=""inner-width"">
        <h1>Kendte spots</h1>
        <div class=""border""></div>
        <div class=""gallery"">

            <a href=""Assets/Images/surf-icon-16.png"" class=""image"">
                <img src=""Assets/Images/surf-icon-16.png"" alt=""error"">
            </a>

            <a href=""Assets/Images/wave-1.jpg"" class=""image"">
                <img src=""Assets/Images/wave-1.jpg"" alt=""error"">
            </a>

            <a href=""Assets/Images/wave2.jpg"" class=""image"">
                <img src=""Assets/Images/wave2.jpg"" alt=""error"">
            </a>

            <a href=""Assets/Images/wave3.jpg"" class=""image"">
                <img src=""Assets/Images/wave3.jpg"" alt=""error"">
            </a>

            <a href=""Assets/Images/wave4.jpg"" class=""image"">
                <img src=""Assets/Images/wave4.jpg"" alt=""error"">
            </a>

            <a href=""Assets/Images/surf-icon-16.png"" class=""image"">
              ");
            WriteLiteral(@"  <img src=""Assets/Images/surf-icon-16.png"" alt=""error"">
            </a>

        </div>
    </div>
</div>

<script>
    $("".gallery"").magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true
        }
    });
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<surf_spotter_dot_net_core.Models.Spot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
