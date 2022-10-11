#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\Reportes\ReporteInventario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7b319e2a3e5b257e7b57914235b90345f9bd5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Reportes.Pages_Catalogos_Reportes_ReporteInventario), @"mvc.1.0.razor-page", @"/Pages/Catalogos/Reportes/ReporteInventario.cshtml")]
namespace PROYECTO_TIENDA.Pages.Catalogos.Reportes
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
#line 1 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using PROYECTO_TIENDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using PROYECTO_TIENDA.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7b319e2a3e5b257e7b57914235b90345f9bd5a", @"/Pages/Catalogos/Reportes/ReporteInventario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_Reportes_ReporteInventario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""module"">
    //import CreateTable from '../js/TableComponent.js';
    //import CreateTable from '../../../js/TableComponent.js'
    import TableInforme from '../../../js/Reporte.js';

    const CargarDatos = async () => {
        // let UrlP = ""../api/ValuesControllerInventario/TraerInforme"";
        let UrlP = ""../../api/ValuesControllerInventario/TraerInforme"";
        let response = await fetch(UrlP, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });

        response = await response.json();
        console.log(response);
        //CARGA IVENTARIO
        TableInforme(response, TableInventarioR);
    }
        //CargarDatos();

        

    window.onload = async () => {
        CargarDatos();
        BtnUpdate.onclick = () => {
            CargarDatos();
        }
        //BtnPrint.onclick = () => {
        //    const PrintNode = Page.inne");
            WriteLiteral(@"rHTML;
        //    const ventimp = window.open(' ', 'popimpr');
        //    ventimp.document.write(PrintNode);
        //    ventimp.document.close();
        //    ventimp.print();
        //    ventimp.close();
        //}
    }



</script>

<div>
    <h2>
        Que pasa aqui.
    </h2>
</div>

<div class=""FrmContainer"">
    <input type=""date"" id=""Fecha1"" value=""1990-01-01"" />
    <input type=""date"" id=""Fecha2"" value=""2022-01-01"" />
</div>
<div class=""FrmContainer"">
    <input class=""BTN BTNOk2"" type=""button"" id=""BtnPrint"" value=""Imprimir"" />
    <input class=""BTN BTNOk2"" type=""button"" id=""BtnUpdate"" value=""Actualizar"" />
</div>

<div class=""InformeContainer"">
    <div class=""page"" id=""Page"">
        <style>
            .InformeContainer {
                background-color: #b9b9b9;
                padding: 20px;
                height: 600px;
                overflow: auto;
                border: solid 2px #888;
            }

            .page {
                back");
            WriteLiteral(@"ground-color: #fff;
                width: 17cm;
                height: 25.7cm;
                display: block;
                margin: 0 auto;
                margin-bottom: 0.5cm;
                box-shadow: 0 0 0.5cm rgba(0,0,0,0.5);
                padding: 1cm 2cm;
            }

            h1, h4 {
                text-align: center;
            }

            .TableInforme {
                width: 100%;
                margin-bottom: 30px;
            }

                .TableInforme td, .TableInforme th {
                    border-bottom: solid 1px #b9b9b9;
                }
        </style>
        <section>
            <h1>
                Informe
            </h1>
            <h4 id=""labelSubtitle"">Informe de Compras por fechas</h4>
        </section>
        <table id=""TableInventarioR"" class=""TableInforme"">
            <thead>
            </thead>
            <tbody>
            </tbody>
        </table>
        <hr />
        <label id=""LabelTotal""> Total: ");
            WriteLiteral("</label>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.Reportes.ReporteInventarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.Reportes.ReporteInventarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.Reportes.ReporteInventarioModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.Reportes.ReporteInventarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
