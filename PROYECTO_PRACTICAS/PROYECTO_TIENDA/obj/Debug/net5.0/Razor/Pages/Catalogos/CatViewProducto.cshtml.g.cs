#pragma checksum "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\CatViewProducto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64711de3e35ea87e1f80ddf54fa6dfcd6cde606c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Pages_Catalogos_CatViewProducto), @"mvc.1.0.razor-page", @"/Pages/Catalogos/CatViewProducto.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using PROYECTO_TIENDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using PROYECTO_TIENDA.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64711de3e35ea87e1f80ddf54fa6dfcd6cde606c", @"/Pages/Catalogos/CatViewProducto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_CatViewProducto : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Activo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Inactivo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""module"">
    import CreateTable from ""../js/TableComponent.js"";
    import CreateDropDown from '../js/DropDownComponent.js';
    const CargarDatos = async () => {
        let UrlP = ""../api/ValuesControllerProducto/TakeDataForCategoria"";
        let response = await fetch(UrlP, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });
        response = await response.json();
        console.log(response);

        CreateTable(response[0], TableData, FunctionEdit);
        CreateDropDown(response[1], DropCategoria, ""idCategoria"", ""nombre"");
    }
    const FunctionEdit = async (Item) => {
        TxtIdProducto.value = Item.idProducto;
        TxtNombreProducto.value = Item.nombreProducto;
        TxtDescripcionProducto.value = Item.descripcion;
        DropCategoria.value = Item.idCategoria;
        DropEstado.value = Item.estado;
    }
    window.onloa");
            WriteLiteral(@"d = async () => {
        BtnSave.onclick = async () => {
            const ObjInst = {
                IdProducto: TxtIdProducto.value,
                NombreProducto: TxtNombreProducto.value,
                Descripcion: TxtDescripcionProducto.value,
                IdCategoria: DropCategoria.value,
                Estado: DropEstado.value
            }

            let flag = true;
            for (var prop in ObjInst) {
                if (ObjInst[prop] == """") {
                    flag = false;
                    alert(""la propiedad "" + prop + "" es requerida"");
                    break;
                }
            }

            if (!flag) {
                return;
            }

            let Url = ""../api/ValuesControllerProducto/SaveProducto"";
            let response = await fetch(Url, {
                method: ""POST"",
                headers: {
                    'Content-Type': ""application/json; charset=utf-8"",
                    'Accept': ""*/*""
               ");
            WriteLiteral(@" },
                body: JSON.stringify(ObjInst)
            });
            response = await response.json();
            if (response == true) {
                alert(""Datos Guardados"");
                window.location.reload();
                CargarDatos();

                TxtIdProducto.value = ""-1"";
                TxtNombreProducto.value = """";
                TxtDescripcionProducto.value = """";
            }
        }
        //Cargar Productos
        CargarDatos();
    }
</script>
<divdiv></divdiv>
<div class=""FrmContainer"">
    <div hidden=""true"">
        Id Producto:
        <input class=""TxtForm"" type=""number"" id=""TxtIdProducto"" value=""-1"" />
    </div>
    <div>
        NombreProducto:
        <input class=""TxtForm"" type=""text"" id=""TxtNombreProducto"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Descripcion:
        <input class=""TxtForm"" type=""text"" id=""TxtDescripcionProducto"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Categoria:
   ");
            WriteLiteral("     <select class=\"TxtForm minimal\" id=\"DropCategoria\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64711de3e35ea87e1f80ddf54fa6dfcd6cde606c7636", async() => {
                WriteLiteral("Seleccionar Categoria");
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
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n    <div>\r\n        Estado:\r\n        <select class=\"TxtForm\" id=\"DropEstado\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64711de3e35ea87e1f80ddf54fa6dfcd6cde606c8945", async() => {
                WriteLiteral("Activo");
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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64711de3e35ea87e1f80ddf54fa6dfcd6cde606c10116", async() => {
                WriteLiteral("Inactivo");
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
            WriteLiteral(@"
        </select>
    </div>
</div>
<div class=""FrmContainer"">
    <div>
        <input class=""BTN BTNOK2"" type=""button"" id=""BtnSave"" value=""Guardar"" />
    </div>
</div>
<table id=""TableData"" class=""FrmTable"">
    <thead>
    </thead>
    <tbody>
    </tbody>
</table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.CatViewProductoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewProductoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewProductoModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.CatViewProductoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
