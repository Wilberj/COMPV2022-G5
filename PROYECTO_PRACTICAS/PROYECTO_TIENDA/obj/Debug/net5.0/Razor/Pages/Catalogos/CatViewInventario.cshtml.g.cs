#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\CatViewInventario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "410f72f66588882e196b05e3a3e7f4173be50ed9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410f72f66588882e196b05e3a3e7f4173be50ed9", @"/Pages/Catalogos/CatViewInventario.cshtml")]
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
        CreateTableInventario(response[0], TableData, FunctionEdit, ""Editar"", FunctionDan, ""Dañados"");

        //CARGA PRODUCTO -MODAL
        Producto = response[1]
        CreateTable(Producto, TableProducto, FunctionSeleccionar, ""Seleccionar"");


        CreateDropDown(response[2], DropMarca, ""idMarca"", ""marca"");
        CreateDropDown(response[3], DropTalla, ""idTalla"", ""talla"");
        CreateDropD");
            WriteLiteral(@"own(response[4], DropBodega, ""idBodega"", ""descripcion"");
        CreateDropDown(response[5], DropMedida, ""idTransMedida"", ""equivalencia"");
    }


    //AGREDAR PRODUCTO DE MODAL A INPUT
    const FunctionSeleccionar = async (Item) => {
        console.log(Item)
        TxtProducto.value = Item.idProducto;
        TxtNProd.value = Item.nombreProducto;
        ModalFunction(ModalProducto)
    }


    //FUNCION EDITAR
    const FunctionEdit = async (Item) => {
        TxtIdInventario.value = Item.idInventario;
        TxtProducto.value = Item.idProducto;
        TxtCodigo.value = Item.codigoProducto;
        TxtDateTime.value = Item.fechaRegistro;
        DropMarca.value = Item.idMarca;
        DropTalla.value = Item.idTalla;
        DropBodega.value = Item.idBodega;
        TxtPrecioCompra.value = Item.precioCompra;
        TxtPrecioVenta.value = Item.precioVenta;
        TxtMedida.value = Item.medida;
        TxtMinimo.value = Item.stockMinimo;
        TxtMaximo.value = Item.stockMa");
            WriteLiteral(@"ximo;
        TxtActual.value = Item.stockActual;


    }

    //AGREGA DATOS AL FORM DANADOS
    const FunctionDan = async (Item) => {

        TxtIdProducto.value = Item.idProducto;
        TxtIdInv.value = Item.idInventario;
        TxtCoPro.value = Item.codigoProducto;

    }

    //CREATE TABLE INVENTARIO
    export default function CreateTableInventario(Dataset = [], Table, TableFunction, BtnValue = ""Edit"", funcion, BtnDañado = ""Añadir"") {
        const thead = Table.querySelector(""thead""); //dataset= response, table=nombre de la tabla-tableproducto,?,?
        const tbody = Table.querySelector(""tbody"");//tbody = cuerpo de tabla, thead=encabezado de tabla


        thead.innerHTML = """";
        tbody.innerHTML = """";



        Dataset.forEach((item, index) => {
            const row = document.createElement(""tr"");//filas
            for (var prop in item) {

                if (index == 0) {

                    const th = document.createElement(""th"");//encabezados
     ");
            WriteLiteral(@"               th.innerText = prop;
                    thead.append(th);
                }
                const td = document.createElement(""td""); //tabledata
                td.innerText = item[prop];
                row.append(td);
            }
            if (index == 0) {
                const th = document.createElement(""th"");
                const thD = document.createElement(""th"")
                th.innerText = ""Editar"";
                thD.innerHTML = ""Productos Dañados""
                thead.append(th, thD);

            }

            const tdAction = document.createElement(""td"");
            const btn = document.createElement(""input"");
            btn.type = ""button"";
            btn.className = ""BTN BTNOK"";
            btn.value = BtnValue;
            btn.onclick = () => {
                //console.log(item);
                TableFunction(item);
            }

            const tdprod = document.createElement(""td"");
            const btnD = document.createElement(""in");
            WriteLiteral(@"put"");
            btnD.type = ""button"";
            btnD.className = ""BTN BTNOK"";
            btnD.value = BtnDañado;
            btnD.onclick = () => {
                ModalFunction(ModalPD);
                funcion(item)
            }
            tdAction.append(btn);
            tdprod.append(btnD);
            row.append(tdAction, tdprod);
            tbody.append(row);

        });

    }


    // GUARDAR DAÑADOS
    BtnSavePD.onclick = async () => {
        const obj = {
            IdDañados: TxtIdDan.value,
            IdInventario: TxtIdInv.value,
            IdProducto: TxtIdProducto.value,
            CodigoProducto: TxtCoPro.value,
            Fecha: TxtDateT.value,
            Descripcion: TxtDDescripcion.value,
            Cantidad: TxtCantidad.value

        }

        let UrlD = ""../api/Dan/SaveDan"";
        let response = await fetch(UrlD, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",");
            WriteLiteral(@"
                'Accept': ""*""
            },
            body: JSON.stringify(obj)
        });
        response = await response.json();
        if (response == true) {
            alert(""Datos Guardados"");
            ModalFunction(ModalPD);
        }
    }


    /*GUARDAR INVENTARIO*/
    window.onload = async () => {
        BtnSave.onclick = async () => {
            const ObjInst = {
                IdInventario: TxtIdInventario.value,
                IdProducto: TxtProducto.value,
                CodigoProducto: TxtCodigo.value,
                FechaRegistro: TxtDateTime.value,
                Descripcion: TxtDescripcion.value,
                IdBodega: DropBodega.value,
                IdMarca: DropMarca.value,
                IdTalla: DropTalla.value,
                IdTransMedida: DropMedida.value,
                PrecioCompra: TxtPrecioCompra.value,
                PrecioVenta: TxtPrecioCompra.value,
                StockMaximo: TxtMaximo.value,
                StockAct");
            WriteLiteral(@"ual: TxtActual.value
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
                alert(""Datos Guardados"");
                window.location.reload();
            }
            TxtIdInventario.value = """"
            TxtProducto.value = """"");
            WriteLiteral(@"
            TxtCodigo.value = """"
            TxtDescripcion.value = """"
            PrecioCompra.value = """"
            PrecioVenta.value = """"
            TxtNProd.value = """"
        }

        CargarDatos();

        BtnModalProducto.onclick = () => {
            ModalFunction(ModalProducto);
        }
        BtnCerrarProducto.onclick = () => {
            ModalFunction(ModalProducto);
        }

        BtnCerrarPDA.onclick = () => {
            ModalFunction(ModalPD);
        }


    }

</script>


");
            WriteLiteral(@"<div class=""FrmContainer"">
    <div hidden=""true"">
        Id Inventario:
        <input class=""TxtForm"" type=""number"" id=""TxtIdInventario"" value=""-1"" />
    </div>
    <div hidden=""true"">
        IdProducto:
        <input class=""TxtForm"" type=""number"" id=""TxtProducto"" placeholder=""Propiedad..."" disabled />
    </div>

    <div>
        Producto:
        <input class=""TxtForm"" type=""text"" id=""TxtNProd"" placeholder=""Propiedad..."" disabled />
    </div>

    <div>
        Codigo:
        <input class=""TxtForm"" type=""text"" id=""TxtCodigo"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Descripcion:
        <input class=""TxtForm"" type=""text"" id=""TxtDescripcion"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Bodega:
        <select class=""TxtForm minimal"" id=""DropBodega"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f72f66588882e196b05e3a3e7f4173be50ed912665", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f72f66588882e196b05e3a3e7f4173be50ed914105", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f72f66588882e196b05e3a3e7f4173be50ed915417", async() => {
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
        <select class=""TxtForm minimal"" id=""DropMedida"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410f72f66588882e196b05e3a3e7f4173be50ed917022", async() => {
                WriteLiteral("Seleccionar Medida");
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
        <input class=""BTN BTNOK2"" type=""button"" id=""BtnModalProducto"" value=""Agregar Producto"" />
    </div>
</div>

");
            WriteLiteral(@"
<div class=""ModalContentPD"" id=""ModalPD"">
    <div class=""FrmContainerPD"">
        <div hidden=""true"">
            Id Dañados:
            <input class=""TxtForm"" type=""number"" id=""TxtIdDan"" value=""-1"" />
        </div>
        <div>
            Inventario:
            <input class=""TxtForm"" type=""number"" id=""TxtIdInv"" placeholder=""Propiedad..."" />
        </div>
        <div>
            Producto:
            <input class=""TxtForm"" type=""number"" id=""TxtIdProducto"" placeholder=""Propiedad..."" />
        </div>
        <div>
            Codigo Producto:
            <input class=""TxtForm"" type=""text"" id=""TxtCoPro"" placeholder=""Propiedad..."" />
        </div>

        <div>
            Fecha:
            <input class=""TxtForm"" type=""date"" id=""TxtDateT"" placeholder=""Propiedad..."" />
        </div>
        <div>
            Descripcion:
            <input class=""TxtForm"" type=""text"" id=""TxtDDescripcion"" placeholder=""Propiedad..."" />
        </div>
        <div>
            Cantidad:
  ");
            WriteLiteral(@"          <input class=""TxtForm"" type=""number"" id=""TxtCantidad"" placeholder=""Propiedad..."" />
        </div>

    </div>

    <div class=""FrmContainer"">
        <div>
            <input class=""BTN BTNOK2"" type=""button"" id=""BtnSavePD"" value=""Guardar"" />
            <input class=""BTN BTNOK2"" type=""button"" id=""BtnCerrarPDA"" value=""Cerrar"" />
        </div>
    </div>
</div>



");
            WriteLiteral(@"<table id=""TableData"" class=""FrmTable"">
    <thead>
    </thead>
    <tbody>
    </tbody>
</table>


<div class=""ModalContent"" id=""ModalProducto"">
    <div class=""ContainerForm"">
        <input type=""text"" id=""TxtBusquedaProducto"" placeholder=""Buscar...""");
            BeginWriteAttribute("value", " value=\"", 11913, "\"", 11921, 0);
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
