#pragma checksum "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff41fefd74ada339ed70eb816493aa37594397dd"
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
#nullable restore
#line 3 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff41fefd74ada339ed70eb816493aa37594397dd", @"/Views/Home/spots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_spots : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<surf_spotter_dot_net_core.ViewModels.SpotsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("spotSelect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Spots", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Spots"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
  
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

<div class=""spotSelectDiv"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff41fefd74ada339ed70eb816493aa37594397dd10046", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff41fefd74ada339ed70eb816493aa37594397dd10313", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 139 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SpotId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 140 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.Spots,"Id","Name"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Action\" class=\"btn btn-default\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"spotSelectDivLatLong\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff41fefd74ada339ed70eb816493aa37594397dd14059", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 149 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"inputgroup\">\r\n                ");
#nullable restore
#line 153 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.LabelFor(x => x.Lat));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 154 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.EditorFor(x => x.Lat));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"inputgroup\">\r\n                ");
#nullable restore
#line 157 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.LabelFor(x => x.Lng));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 158 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
           Write(Html.EditorFor(x => x.Lng));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"inputgroup\">\r\n                <button type=\"submit\" class=\"sub\">Action</button>\r\n            </div>\r\n");
#nullable restore
#line 163 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<div>
    <table class=""dataTable"">
        <thead>
            <tr>
                <th>
                    Time Stamp
                </th>
                <th>
                    Air Temperature
                </th>
                <th>
                    Air Pressure
                </th>
                <th>
                    Feels Like
                </th>
                <th>
                    Wind Speed
                </th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 191 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
              
                int i = 0;
                int c = 0;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 196 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
             foreach (var vmItem in Model.Hourly)
            {
                if (c == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 202 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                       Write(string.Format("+{0}:00", i));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 205 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                       Write(Html.DisplayFor(modelItem => vmItem.Temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 208 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                       Write(Html.DisplayFor(modelItem => vmItem.Pressure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 211 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                       Write(Html.DisplayFor(modelItem => vmItem.Feels_Like));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 214 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                       Write(Html.DisplayFor(modelItem => vmItem.Wind_Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 217 "C:\Users\regsa\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
                    c = 1;
                }
                else
                {
                    c = 0;
                }

                i++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

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
            WriteLiteral(@"                <img src=""Assets/Images/surf-icon-16.png"" alt=""error"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<surf_spotter_dot_net_core.ViewModels.SpotsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
