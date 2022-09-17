#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\DañadosView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f25e0e287e3a8a7b40bd0f849c2387c41454ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Pages_Catalogos_DañadosView), @"mvc.1.0.razor-page", @"/Pages/Catalogos/DañadosView.cshtml")]
namespace PROYECTO_TIENDA.Pages.Catalogos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f25e0e287e3a8a7b40bd0f849c2387c41454ca", @"/Pages/Catalogos/DañadosView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_DañadosView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""module"">

    import CreateTable from ""../js/TableComponent.js"";
    //import CreateDropDown from ""../js/DropDownComponent.js"";

    let Producto;

    const CargarDatos = async () => {
        let UrlP = ""../api/Dañados/GetInventario"";
        let response = await fetch(UrlP, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });
        response = await response.json();
        console.log(response);
        //CARGA DAÑADOS
        CreateTable(response[0], TableData, FunctionEdit);

        //CARGA PRODUCTO -MODAL
        Producto = response[1]
        CreateTable(Producto, TableDan, FunctionSeleccionar, ""Seleccionar"");
    }

</script>

<div class=""FrmContainer"">
    <div hidden=""true"">
        Id Dañados:
        <input class=""TxtForm"" type=""number"" id=""TxtIdDan"" value=""-1"" />
    </div>
    <div>
        IdProducto:
        <input clas");
            WriteLiteral(@"s=""TxtForm"" type=""number"" id=""TxtIdProducto"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Inventario:
        <input class=""TxtForm"" type=""number"" id=""TxtIdInv"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Fecha:
        <input class=""TxtForm"" type=""date"" id=""TxtDateTime"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Descripcion:
        <input class=""TxtForm"" type=""text"" id=""TxtDescripcion"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Cantidad:
        <input class=""TxtForm"" type=""number"" id=""TxtCantidad"" placeholder=""Propiedad..."" />
    </div>
    
</div>
<div class=""FrmContainer"">
    <div>
        <input class=""BTN BTNOK2"" type=""button"" id=""BtnSave"" value=""Guardar"" />
");
            WriteLiteral("    </div>\r\n</div>\r\n<table id=\"TableData\" class=\"FrmTable\">\r\n    <thead>\r\n    </thead>\r\n    <tbody>\r\n    </tbody>\r\n</table>\r\n< <table id=\"TableDan\" class=\"FrmTable\">\r\n     <thead>\r\n       </thead>\r\n        <tbody>\r\n      </tbody>\r\n  </table>\r\n\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.DañadosViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.DañadosViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.DañadosViewModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.DañadosViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
