#pragma checksum "C:\Users\Isabel Aguilar\Favorites\Documents\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\CatViewInventario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149ef139613226a732ec5ec8b2ef2fef285ff816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Pages_Catalogos_CatViewInventario), @"mvc.1.0.razor-page", @"/Pages/Catalogos/CatViewInventario.cshtml")]
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
#line 1 "C:\Users\Isabel Aguilar\Favorites\Documents\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Isabel Aguilar\Favorites\Documents\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using PROYECTO_TIENDA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Isabel Aguilar\Favorites\Documents\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
using PROYECTO_TIENDA.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149ef139613226a732ec5ec8b2ef2fef285ff816", @"/Pages/Catalogos/CatViewInventario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_CatViewInventario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    import CreateDropDown from ""../js/DropDownComponent.js"";
    let Producto;
    const CargarDatos = async () => {
        let UrlP = ""../api/ValuesControllerInventario/TakeDataForInventario"";
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
        CreateTable(response[0], TableData, FunctionEdit);

        //CARGA PRODUCTO -MODAL
        Producto = response[1]
        CreateTable(Producto, TableProducto, FunctionSeleccionar, ""Seleccionar"");


        //TEXTO BUSQUEDA
        //TxtBusquedaProducto.onchange = (ev) => {
        //    const parametro = ev.target.value;
        //    const ProductosFiltrados = Producto.filter(x => x.nombreProdu");
            WriteLiteral(@"cto.includes(parametro));
        //    CreateTable(ProductosFiltrados, TableProducto, FunctionSeleccionar, ""Seleccionar"");


        //}
       
            CreateDropDown(response[2], DropMarca, ""idMarca"", ""marca"");
            CreateDropDown(response[3], DropTalla, ""idTalla"", ""talla"");
            CreateDropDown(response[4], DropBodega, ""idBodega"", ""descripcion"");
        
    }

    //AGREDAR PRODUCTO DE MODAL A INPUT
        const FunctionSeleccionar = async (Item) => {
            console.log(Item)
            TxtProducto.value = Item.idProducto;
            ModalFunction(ModalProducto)
        }
        const FunctionEdit = async (Item) => {
            TxtIdInventario.value = Item.idInventario;
            TxtProducto.value = Item.idProducto;
            TxtCodigo.value = Item.codigoProducto;
            TxtDateTime.value = Item.fechaRegistro;
            DropBodega.vale = Item.idBodega;
            DropMarca.value = Item.idMarca;
            DropTalla.value = Item.idTalla;
 ");
            WriteLiteral(@"           TxtPrecioCompra.value = Item.precioCompra;
            TxtPrecioVenta.value = Item.precioVenta;
            TxtMedida.value = Item.medida;
            TxtMinimo.value = Item.stockMinimo;
            TxtMaximo.value = Item.stockMaximo;
            TxtActual.value = Item.stockActual;
        }
        window.onload = async () => {
            BtnSave.onclick = async () => {
                const ObjInst = {
                    IdInventario: TxtIdInventario.value,
                    IdProducto: TxtProducto.value,
                    CodigoProducto: TxtCodigo.value,
                    FechaRegistro: TxtDateTime.value,
                    IdBodega:DropBodega.value,
                    IdMarca: DropMarca.value,
                    IdTalla: DropTalla.value,
                    PrecioCompra: TxtPrecioCompra.value,
                    PrecioVenta: TxtPrecioCompra.value,
                    Medida:TxtMedida.value ,
                    StockMinimo: TxtMinimo.value,
                    S");
            WriteLiteral(@"tockMaximo: TxtMaximo.value,
                    StockActual: TxtActual.value
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

                let Url = ""../api/ValuesControllerInventario/SaveInventario"";
                let response = await fetch(Url, {
                    method: ""POST"",
                    headers: {
                        'Content-Type': ""application/json; charset=utf-8"",
                        'Accept': ""*""
                    },
                    body: JSON.stringify(ObjInst)
                });
                response = await response.json();
                if (response == true) {
                    alert");
            WriteLiteral(@"(""Datos Guardados"");
                    window.location.reload();
                }
            }
            CargarDatos();
            BtnModalProducto.onclick = () => {
                ModalFunction(ModalProducto);
            }
            BtnCerrarProducto.onclick = () => {
                ModalFunction(ModalProducto);
            }
        }
</script>
<div></div>
<div class=""FrmContainer"">
    <div hidden=""true"">
        Id Inventario:
        <input class=""TxtForm"" type=""number"" id=""TxtIdInventario"" value=""-1"" />
    </div>
    <div>
        Producto:
        <input class=""TxtForm"" type=""text"" id=""TxtProducto"" placeholder=""Propiedad..."" disabled/>
    </div>
    <div>
        Codigo:
        <input class=""TxtForm"" type=""text"" id=""TxtCodigo"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Bodega:
        <select class=""TxtForm minimal"" id=""DropBodega"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149ef139613226a732ec5ec8b2ef2fef285ff8169006", async() => {
                WriteLiteral("Seleccionar Bodega");
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
            WriteLiteral(@"
        </select>
    </div>
    <div>
        Fecha:
        <input class=""TxtForm"" type=""date"" id=""TxtDateTime"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Marca:
        <select class=""TxtForm minimal"" id=""DropMarca"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149ef139613226a732ec5ec8b2ef2fef285ff81610445", async() => {
                WriteLiteral("Seleccionar Marca");
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
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n    <div>\r\n        Talla:\r\n        <select class=\"TxtForm minimal\" id=\"DropTalla\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149ef139613226a732ec5ec8b2ef2fef285ff81611757", async() => {
                WriteLiteral("Seleccionar Talla");
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
            WriteLiteral(@"
        </select>
    </div>
    <div>
        PrecioCompra:
        <input class=""TxtForm"" type=""number"" id=""TxtPrecioCompra"" placeholder=""Propiedad..."" />
    </div>
    <div>
        PrecioVenta:
        <input class=""TxtForm"" type=""number"" id=""TxtPrecioVenta"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Medida:
        <input class=""TxtForm"" type=""text"" id=""TxtMedida"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Stock minimo:
        <input class=""TxtForm"" type=""number"" id=""TxtMinimo"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Stock maximo:
        <input class=""TxtForm"" type=""number"" id=""TxtMaximo"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Stock actual:
        <input class=""TxtForm"" type=""number"" id=""TxtActual"" placeholder=""Propiedad..."" />
    </div>
</div>
<div class=""FrmContainer"">
    <div>
        <input class=""BTN BTNOK2"" type=""button"" id=""BtnSave"" value=""Guardar"" />
        <input class=""BTN BTNOK2"" type=");
            WriteLiteral(@"""button"" id=""BtnModalProducto"" value=""Agregar Producto"" />
    </div>
</div>
<table id=""TableData"" class=""FrmTable"">
    <thead>
    </thead>
    <tbody>
    </tbody>
</table>


<div class=""ModalContent"" id=""ModalProducto"">
    <div class=""ContainerForm"">
        <input type=""text"" id=""TxtBusquedaProducto"" placeholder=""Buscar...""");
            BeginWriteAttribute("value", " value=\"", 6987, "\"", 6995, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        <table id=""TableProducto"" class=""FrmTable"">
            <thead>
            </thead>
            <tbody>
            </tbody>
        </table>

        <div class=""FrmContainer"">
            <div>
                <input class=""BTN BTNOK2"" type=""button"" id=""BtnCerrarProducto"" value=""Cerrar"" />
            </div>
        </div>
    </div>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.CatViewInventarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewInventarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewInventarioModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.CatViewInventarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
