<<<<<<< HEAD
#pragma checksum "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\Vistas\VistaCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9ad0141ebd78ca9f89f89fb570f94e6c397eb2f"
=======
#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\Vistas\VistaCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9ad0141ebd78ca9f89f89fb570f94e6c397eb2f"
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Vistas.Pages_Catalogos_Vistas_VistaCompra), @"mvc.1.0.razor-page", @"/Pages/Catalogos/Vistas/VistaCompra.cshtml")]
namespace PROYECTO_TIENDA.Pages.Catalogos.Vistas
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
<<<<<<< HEAD
#line 1 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
=======
#line 2 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
using PROYECTO_TIENDA;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
=======
#line 3 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
using PROYECTO_TIENDA.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9ad0141ebd78ca9f89f89fb570f94e6c397eb2f", @"/Pages/Catalogos/Vistas/VistaCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_Vistas_VistaCompra : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""module"">
    import CreateTable from '../../js/TableComponent.js';
    let compra;

    const CargarDatos = async () => {
        let UrlCompra = ""../../api/Compra/VerCompra"";
        let response = await fetch(UrlCompra, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });
        response = await response.json();
        compra = response[0];
        //CARGAR TODOS LAS LISTAS
        console.log('Hola en la vista')
        console.log(response);
        console.log(compra);

        //CARGA TABLA COMPRA
        CreateTable(compra, TableCompra);//tabla compra

        window.onload = async () => {
            CargarDatos();
            alert(""hola"")

        }

        //CargarDatos();
         

    }
</script>
<div>
    <input type=""text"" class=""TxtForm"" id=""TxtBusquedaCompra"" placeholder=""Buscar...""");
            BeginWriteAttribute("value", " value=\"", 1071, "\"", 1079, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <table id=\"TableCompra\" class=\"FrmTable\">\r\n        <thead>\r\n        </thead>\r\n        <tbody>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.VistaCompra.VistaCompraModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.VistaCompra.VistaCompraModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.VistaCompra.VistaCompraModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.VistaCompra.VistaCompraModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
