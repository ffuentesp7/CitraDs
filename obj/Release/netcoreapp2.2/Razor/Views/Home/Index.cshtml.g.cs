#pragma checksum "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c2559197cc09e6ecd8584b697581e0041b36b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore;

#line default
#line hidden
#line 2 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git2\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c2559197cc09e6ecd8584b697581e0041b36b25", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "EPSG:4326", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "EPSG:3857", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "EPSG:32719", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Polygon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(29, 569, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b255340", async() => {
                BeginContext(35, 556, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Tiled WMS</title>
    <link rel=""stylesheet"" href=""https://openlayers.org/en/v5.3.0/css/ol.css"" type=""text/css"">
    <!-- The line below is only needed for old environments like Internet Explorer and Android 4.x -->
    <script src=""https://cdn.polyfill.io/v2/polyfill.min.js?features=requestAnimationFrame,Element.prototype.classList,URL""></script>
    <script src=""https://cdn.rawgit.com/openlayers/openlayers.github.io/master/en/v5.3.0/build/ol.js""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(598, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(602, 4565, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b257094", async() => {
                BeginContext(608, 2832, true);
                WriteLiteral(@"

    <h2>Mapa de Prueba</h2>

    <div class=""panel panel-primary"">
        <div class=""panel-body"">
            <div id=""map"" class=""map""></div>
        </div>
    </div>

    <div class=""container"">

        <div class=""row justify-content-start"">




            <div class=""container-fluid"">

                <div class=""row"">
                    <div class=""col-lg-4"">
                        <div class=""panel panel-primary"">
                            <div class=""panel-body"">
                                <h1>Indicadores</h1>

                                <div class=""custom-control custom-radio"">
                                    <input type=""radio"" id=""customRadio1"" name=""customRadio"" class=""custom-control-input"">
                                    <label class=""custom-control-label"" for=""customRadio1"">NDVI</label>
                                </div>

                                <div class=""custom-control custom-radio"">
                                    <i");
                WriteLiteral(@"nput type=""radio"" id=""customRadio2"" name=""customRadio"" class=""custom-control-input"">
                                    <label class=""custom-control-label"" for=""customRadio2"">ET24</label>
                                </div>

                                <div class=""custom-control custom-radio"">
                                    <input type=""radio"" id=""customRadio3"" name=""customRadio"" class=""custom-control-input"">
                                    <label class=""custom-control-label"" for=""customRadio3"">LAI</label>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""panel panel-primary"">
                            <div class=""panel-body"">

                                <div>
                                    <button type=""button"" id=""save"" onclick=""printpoly()"" class=""btn btn-success"">Guardar poligono</button>
           ");
                WriteLiteral(@"                     </div>
                                <div>
                                    <button type=""button"" id=""sum"" class=""btn btn-success"">Calcular suma</button>
                                </div>



                                <div class=""panel panel-primary"">
                                    <div class=""panel-body""> Coordenadas
                                        <div type=""text"" id=""mouse-position""></div>
                                    </div>
                                </div>




                                        <div>
                                            <label>Projection </label>
                                            <select id=""projection"">
                                                ");
                EndContext();
                BeginContext(3440, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b2510474", async() => {
                    BeginContext(3466, 9, true);
                    WriteLiteral("EPSG:4326");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3484, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(3534, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b2511991", async() => {
                    BeginContext(3560, 9, true);
                    WriteLiteral("EPSG:3857");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3578, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(3628, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b2513508", async() => {
                    BeginContext(3655, 10, true);
                    WriteLiteral("EPSG:32719");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3674, 605, true);
                WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div>
                                            <label>Precision </label>
                                            <input id=""precision"" type=""number"" min=""0"" max=""12"" value=""4"" />
                                        </div>

                                    </div>
                                </div>

                            </div>
                </div>
            </div>

            <div class=""container"">
                ");
                EndContext();
                BeginContext(4279, 502, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b2515595", async() => {
                    BeginContext(4305, 123, true);
                    WriteLiteral("\r\n                    <label>Geometry type &nbsp;</label>\r\n                    <select id=\"type\">\r\n                        ");
                    EndContext();
                    BeginContext(4428, 40, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2559197cc09e6ecd8584b697581e0041b36b2516128", async() => {
                        BeginContext(4452, 7, true);
                        WriteLiteral("Polygon");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4468, 306, true);
                    WriteLiteral(@"
                        <!--
                        <option value=""Point"">Point</option>
                        <option value=""LineString"">LineString</option>
                        <option value=""Circle"">Circle</option>
                        -->
                    </select>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4781, 379, true);
                WriteLiteral(@"
            </div>

        </div>

    </div>

    <button type=""button"" id=""b1"" value=""btn1"" onclick=""addInteraction(); disableB1()"" class=""btn btn-primary btn-lg btn-block"">Dibujar Poligono</button>
    <button type=""button"" id=""b2"" value=""btn2"" onclick=""removeInteraction(); disableB2()"" disabled=""true"" class=""btn btn-primary btn-lg btn-block"">Terminar</button>

");
                EndContext();
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
            EndContext();
            BeginContext(5167, 11403, true);
            WriteLiteral(@"
</html>



<script>

    const pro = proj4.defs(""EPSG:32719"", ""+proj=utm +zone=19 +south +datum=WGS84 +units=m +no_defs"");
    ol.proj.proj4.register(proj4);

    var mousePositionControl = new ol.control.MousePosition({
        coordinateFormat: ol.coordinate.createStringXY(4),
        projection: 'EPSG:4326',
        // comment the following two lines to have the mouse position
        // be placed within the map.
        className: 'custom-mouse-position',
        target: document.getElementById('mouse-position'),
        undefinedHTML: '&nbsp;'
    });

    //Mapa Satelital
    var raster = new ol.layer.Tile({
        opacity: 0.7,
        proyection: 'EPSG:32719',
        source: new ol.source.XYZ({
            attributions: ['Powered by Esri',
                'Source: Esri, DigitalGlobe, GeoEye, Earthstar Geographics, CNES/Airbus DS, USDA, USGS, AeroGRID, IGN, and the GIS User Community'],
            attributionsCollapsible: false,
            
            url: 'https://se");
            WriteLiteral(@"rvices.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}',
            proyection: 'EPSG:32719',
            maxZoom: 23

        })
    });

    //imagen Satelital (Se debe modificar para ir cambiando por fecha)
    var landsat = new ol.layer.Tile({
        opacity: 0.7,
        proyection: 'EPSG:32719',
        source: new ol.source.TileWMS({
            url: 'http://localhost:8080/geoserver/localhost/wms?',
            params: { 'LAYERS': 'localhost:LC08_L1TP_233086_20131005_20170429_01_T1_sr_ndvi'},
            proyection: 'EPSG:32719',
            serverType: 'geoserver',
            
            // Countries have transparency, so do not fade tiles:
            transition: 0
        })
    });

    var tiff_de_geos = new ol.layer.Tile({
        proyection: 'EPSG:32719',
        source: new ol.source.TileWMS({
        url: 'http://localhost:8080/geoserver/localhost/wms?',
        params: { 'LAYERS': 'localhost:LC08_L1TP_233086_20131005_20170429_01_T1_");
            WriteLiteral(@"sr_ndvi', 'FORMAT': 'image/tiff'},
        proyection: 'EPSG:32719',
            serverType: 'geoserver'
        })
    });

    var projectionSelect = document.getElementById('projection');
    projectionSelect.addEventListener('change', function (event) {
        mousePositionControl.setProjection(event.target.value);
    });

    var precisionInput = document.getElementById('precision');
    precisionInput.addEventListener('change', function (event) {
        var format = ol.coordinate.createStringXY(event.target.valueAsNumber);
        mousePositionControl.setCoordinateFormat(format);
    });

    //Mapa plano con calles
    var street = new ol.layer.Tile({ source: new ol.source.OSM() });

    

    //Vector para guardar los poligonos.
    var source = new ol.source.Vector({
        proyection: 'EPSG:3857'
    })

    //capa para agregar los vectores
    var vector = new ol.layer.Vector({
        source: source,
        proyection: 'EPSG:3857'
    });


    //""Constructor");
            WriteLiteral(@""" del elemento mapa, Se le agregan las capas de satelite, imagen, y calle. Asi como tambien el vector
    // donde son guardados los poligonos.
    var map = new ol.Map({
        pixelRatio: 1,
        layers: [street, raster, landsat, vector],
        target: 'map',
        controls: ol.control.defaults().extend([mousePositionControl]),
        view: new ol.View({
            proyection: 'EPSG:32719',
            center: [0, 0],
            zoom: 5
        })
    });

    var typeSelect = document.getElementById('type');
    var sumaaa;
    var geo;

    var ondrawend = async function (e) {
        console.log(e.feature.getGeometry());
        var allfeat = vector.getSource().getFeatures();
        console.log(""allfeats: "", allfeat);


        /*

        var cord = proj4(""EPSG:4326"", pro, e.feature.getGeometry().getCoordinates()[0][0]);
        console.log(""vord: "", cord);
        const raster = await geoblaze.load(""http://localhost:8080/geoserver/localhost/wms?service=WMS&versio");
            WriteLiteral(@"n=1.1.0&request=GetMap&layers=localhost:LC08_L1TP_233086_20131005_20170429_01_T1_sr_ndvi&bbox=126584.999972549,5732785.00003017,355814.99997254903,5963515.00003017&width=763&height=768&srs=EPSG:32719&format=image/geotiff"");
        var sumaaa = geoblaze.sum(raster);
        console.log(""sm original: "", sumaaa);

        ge = e.feature;
        geo = ge.getGeometry();
        console.log(""poligono original: "", geo.getCoordinates());

        

        var stringjson = { ""type"": ""Feature"", ""geometry"": { ""type"": ""Polygon"", ""coordinates"": [[[-8048819.078429057, -4507950.1801465545], [-8051876.559560465, -4528741.051840122], [-8029251.199188053, -4529964.044292685], [-8048819.078429057, -4507950.1801465545]]] }, ""properties"": null };

        var geojsonbueno = new ol.format.GeoJSON().readFeatures(stringjson);

        console.log(""bueno: "", geojsonbueno);




        var geojson = new ol.format.GeoJSON();
        var featgjson = geojson.writeGeometryObject(geo, pro);
        console.log(""geoj");
            WriteLiteral(@"son: "", featgjson);
        var newfeat = new ol.Feature(geo.clone().transform('EPSG:3857', 'EPSG:4326'));
        console.log(""newfeat: "", newfeat);
        var txtarr = [];
        txtarr.push(JSON.stringify(featgjson));

        console.log(""arraytextgeojson: "", txtarr);
        
        var contentType = 'text/json';
        var blob = new Blob([txtarr], { type: contentType });
        var link = document.createElement('a');
        link.href = window.URL.createObjectURL(blob);
        link.download = ""test.geojson"";
        link.textContent = ""Descargar poly"";
        //link.click();
        console.log(""despues de la descarga"");
  */
        
        //var carp = e.feature.getGeometry().transform('EPSG:3857',""EPSG:32719"");
        //console.log(""funcion ondrawned: "", carp);
        /*
        var pool = e.feature.getGeometry();
        console.log(""funcion ondrawned2: "", pool);
        console.log(""antes del raster "");
        //const raster = await geoblaze.load(""http://localhos");
            WriteLiteral(@"t:8080/geoserver/localhost/wms?service=WMS&version=1.1.0&request=GetMap&layers=localhost:LC08_L1TP_233086_20131005_20170429_01_T1_sr_ndvi&bbox=126584.999972549,5732785.00003017,355814.99997254903,5963515.00003017&width=763&height=768&srs=EPSG:32719&format=image/geotiff"");
        console.log(""rast: "", raster);

        var arr = [[geo.flatCoordinates[0], geo.flatCoordinates[1]],
        [geo.flatCoordinates[2], geo.flatCoordinates[3]],
        [geo.flatCoordinates[4], geo.flatCoordinates[5]],
        [geo.flatCoordinates[6], geo.flatCoordinates[7]]
        ]

        console.log(""arr: "", arr);
        geo.setCoordinates([geo.flatCoordinates[0], geo.flatCoordinates[1], geo.flatCoordinates[2], geo.flatCoordinates[3], geo.flatCoordinates[4], geo.flatCoordinates[5], geo.flatCoordinates[6], geo.flatCoordinates[7]]);
        console.log(""poligono inyectado: "", geo.getCoordinates());

        

        sumaaa = geoblaze.identify(raster, [355814.99997254903,
            5963515.00003017]);
        co");
            WriteLiteral(@"nsole.log(""mean original2: "", sumaaa);

        var sumaaa = geoblaze.sum(raster, geojsonbueno);
        console.log(""sm con geojson hardcoded: "", sumaaa);*/
    };

    var draw; // global so we can remove it later
    function addInteraction() {
        var value = typeSelect.value;
        if (value !== 'None') {
            draw = new ol.interaction.Draw({
                source: source,
                type: typeSelect.value
            });
            draw.on('drawend', ondrawend);
            map.addInteraction(draw);
            console.log(""hallo"");
        }
    }

    function removeInteraction() {
        map.removeInteraction(draw);
    }

    // Habilita/desabilida los botones
    function disableB2() {
        document.getElementById(""b1"").disabled = false;
        document.getElementById(""b2"").disabled = true;
    }
    function disableB1() {
        document.getElementById(""b1"").disabled = true;
        document.getElementById(""b2"").disabled = false;
    }

");
            WriteLiteral(@"
    function deletePoly() {

    }


    /**
      * Handle change event.
      */
    typeSelect.onchange = function () {
        map.removeInteraction(draw);
        addInteraction();
    };


    /*
     *
     * TEST
     *
     * */


    //var GjsonPar = new ol.Format.GeoJSON();

    //var polyJson = GjsonPar.write(vector.features);


    async function  printpoly() {
        var interaction = vector.getSource().getFeatures();
        interaction.forEach(async function (feature) {
            //var newgeo = feature;
            //newgeo.getGeometry().transform('EPSG:3857', ""EPSG:32719"");
            var newfeat = feature.clone();
            var transform = newfeat.getGeometry().transform('EPSG:3857', ""EPSG:32719"");
            var coord = newfeat.getGeometry().getCoordinates();

            var workspace = layer.params.LAYERS.split(':');
            var downloadurl = ""http://localhost:8080/geoserver/"" + workspace[0] + ""/wcs?service=WCS&version=2.0.1&request=GetCover");
            WriteLiteral(@"age&CoverageId="" + layer.params.LAYERS + ""&format=image/tiff""
            window.open(downloadurl);


            console.log(""poligono: "" + coord);
            //coord = ol.proj.transform(coord, 'EPSG:32719', 'EPSG:4326');

            const img = await geoblaze.load(""http://localhost:8080/geoserver/localhost/wms?service=WMS&version=1.1.0&request=GetMap&layers=localhost:LC08_L1TP_233086_20131005_20170429_01_T1_sr_ndvi&bbox=126584.999972549,5732785.00003017,355814.99997254903,5963515.00003017&width=763&height=768&srs=EPSG:32719&format=image/geotiff"");
            //const img = await geoblaze.load(""http://localhost:8080/geoserver/localhost/wms?service=WMS&version=1.1.0&request=GetMap&layers=localhost:Ts&bbox=64051.700592833,4191661.52438661,195811.700592833,4308241.52438661&width=768&height=679&srs=EPSG:32611&format=image/geotiff"");
            var sumaaa = geoblaze.sum(img);
            console.log(""sm original: "", sumaaa);
            var lonlat = [223885.153852, 5786947.319458];
            var ");
            WriteLiteral(@"sum = geoblaze.identify(img, lonlat);
            console.log(""sm crop: "", sum);
            console.log(""img raster: "", img);

            var swissCoord = ol.proj.transform(lonlat, 'EPSG:4326', 'EPSG:32719');
            console.log(""transform: "", swissCoord)
            swissCoord = ol.proj.transform(lonlat, 'EPSG:32719', 'EPSG:4326');
            console.log(""transform 4326: "", swissCoord)
            swissCoord = ol.proj.transform(lonlat, 'EPSG:4326', 'EPSG:32719');
            console.log(""transform 4326 -> 32719: "", swissCoord)
            swissCoord = ol.proj.transform(lonlat, 'EPSG:32719', 'EPSG:3857');
            console.log(""transform 3857: "", swissCoord)

            var suma = geoblaze.sum(img, coord);
            Swal.fire({
                icon: 'success',
                title: 'Resultado',
                text: 'El valor del indicador seleccionado contenido en el pol??gono es:'+suma
            })
            console.log(""sm: "", suma);

        });
    }

</script>

");
            WriteLiteral("\r\n\r\n<style>\r\n    * {\r\n        box-sizing: border-box;\r\n    }\r\n\r\n    .map {\r\n        height: 70%;\r\n        width: 100%;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
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
