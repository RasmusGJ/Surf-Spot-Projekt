#pragma checksum "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d870cbd8b7514a2da11fc43bbd95f1d9c9b6de3f"
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
#line 1 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\_ViewImports.cshtml"
using surf_spotter_dot_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\_ViewImports.cshtml"
using surf_spotter_dot_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d870cbd8b7514a2da11fc43bbd95f1d9c9b6de3f", @"/Views/Home/spots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbab292c81c8259f16148cae1dfad101a19aec0", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_spots : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<");
#nullable restore
#line 1 "C:\Users\ras_j\Documents\GitHub\Surf-Spot-Projekt\surf spotter dot net core\surf spotter dot net core\Views\Home\spots.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hero-text\">\r\n        <h1>Spots</h1>\r\n    </div>\r\n");
            WriteLiteral(@"          <!--Hentning af google api og placering af markers. Evt infobokse. Fungere ikke optimalt endnu....-->
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
      ");
            WriteLiteral(@"      title: 'Løkken',
        }
        ];

        var airPressureValue = "" "";
        var airTemperatureValue = "" "";
        var windSpeedValue = "" "";
        var probPercipitationValue = "" "";
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
                    probPercipitationValue = data['propertie");
            WriteLiteral(@"s']['timeseries']['0']['data']['instant']['details']['wind_speed'];
                })

                .catch(err => alert(""error""))
            contentHTML =
                ""<div class='infowindowHeader'>"" +
                ""<h2>"" + title + ""</h2>"" +
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
               ");
            WriteLiteral(@" ""</table>"";
            return contentHTML;
        }

        function myMap() {
            map = new google.maps.Map(document.getElementById(""googleMap""), {
                center: centerCords,
                zoom: 6.5,
                mapTypeId: google.maps.MapTypeId.SATELLITE,
                disableDefaultUI: true
            });

            var infowindow = new google.maps.InfoWindow();

            for (var i = 0; i < markerLocations.length; i++) {
                var marker = new google.maps.Marker({
                    position: markerLocations[i],
                    map: map,
                    title: markerLocations[i].title
                });
                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                    return function () {
                        infowindow.setContent(dataHentning(markerLocations[i].lat, markerLocations[i].lng, markerLocations[i].title));
                        infowindow.open(map, marker);
             ");
            WriteLiteral(@"       }
                })(marker, i));
                google.maps.event.addListener(marker, 'mouseover', (function (marker, i) {
                    return function () {
                        infowindow.setContent(dataHentning(markerLocations[i].lat, markerLocations[i].lng));
                    }
                })(marker, i));
            }
        }

    </script>

     <script
     src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAzdejVAEmRXr66UrCtX_CWKzjZ4C0fXCA&callback=myMap""
     type=""text/javascript"">
     </script>


        <div class=""gallery-section"">
            <div class=""inner-width"">
                <h1>Kendte spots</h1>
                <div class=""border""></div>
                <div class=""gallery"">

                    <a href=""Assets/Images/surf-icon-16.png"" class=""image"">
                        <img src=""Assets/Images/surf-icon-16.png"" alt=""error"">
                    </a>

                    <a href=""Assets/Images/wave-1.jpg"" class=""image"">
   ");
            WriteLiteral(@"                     <img src=""Assets/Images/wave-1.jpg"" alt=""error"">
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
                        <img src=""Assets/Images/surf-icon-16.png"" alt=""error"">
                    </a>

                </div>
            </div>
        </div>

        <script>
            $("".gallery"").magnificPopup({
                delegate: 'a',
                type: 'image',
                gallery:{
             ");
            WriteLiteral("       enabled:true\r\n                }\r\n            });\r\n        </script>\r\n\r\n");
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