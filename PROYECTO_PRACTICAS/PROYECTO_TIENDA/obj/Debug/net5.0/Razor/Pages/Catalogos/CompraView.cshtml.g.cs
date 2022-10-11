#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\CompraView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f0da4edb05b1a7489b661cfe72e61d292cc8a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Pages_Catalogos_CompraView), @"mvc.1.0.razor-page", @"/Pages/Catalogos/CompraView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f0da4edb05b1a7489b661cfe72e61d292cc8a9", @"/Pages/Catalogos/CompraView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_CompraView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

    import CreateTable from '../js/TableComponent.js';
    import CreateDropDown from '../js/DropDownComponent.js';

    const DetallesCompra = [];
    let compra;

    const CargarDatos = async () => {
        let UrlCompra = ""../api/Compra/VerCompra"";
        let response = await fetch(UrlCompra, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });

        response = await response.json();
        compra = response[0]

        //CARGAR TODOS LAS LISTAS
        console.log(response);

        //CARGA TABLA COMPRA
        CreateTable(compra, TableCompra);

        // DROPDOWN
        CreateDropDown(response[1], DropProveedor, ""idProveedor"", ""nombres"")
        CreateDropDown(response[2], DropMedida, ""idMedida"", ""medida"")

        //TRAE MODAL  INVENTARIO
        CreateTable(response[4], TableProducto, FunctionSeleccionar, ""Seleccio");
            WriteLiteral(@"nar"");


    }

    //SELECCION DE ITEM DE INVENTARIO
    const FunctionSeleccionar = async (Item) => {
        Txtproducto.value = Item.idProducto;
        TxtNproducto.value = Item.producto;
        TxtInvent.value = Item.idInventario;
        Txtprecio.value = Item.precioCompra;
        TxtStockMaximo.value = Item.stockMaximo;
        //TxtStockMinimo.value = Item.stockMinimo;
        TxtStockActual.value = Item.stockActual;
        ModalFunction(ModalProducto)
    }

    //CALCULO DE PORCENTAJES
    Txtcantidad.onkeyup = (ev) => {
        const stockTotal = parseInt(TxtStockActual.value) + parseInt(ev.target.value);
        if (stockTotal > TxtStockMaximo.value) {
            alert('Cantidad Ingresada mayor al Stock, Revisa el Inventario')
            ModalFunction(ModalProducto)
        }
        txtsubtotal.value = Txtprecio.value * ev.target.value;
        Txtiva.value = txtsubtotal.value * 0.15;
        Txttotal.value = parseFloat(txtsubtotal.value) + parseFloat(Txtiva.value)");
            WriteLiteral(@";
    }

    //CALCULO DE DESCUENTO
    TxtDescuento.onkeyup = (ev) => {
        Txttotal.value = parseFloat(Txttotal.value) - ev.target.value;
    }

    ////TEXTO DE BUSQUEDA
    TxtBusquedaCompra.onkeyup = (ev) => {
        const parametro = ev.target.value;
        const CompraFiltrados = compra.filter(x => x.descripcion.includes(parametro));
        CreateTable(CompraFiltrados, TableCompra);
    }

    ////TEXTO DE BUSQUEDA INVENTARIO
    TxtBusquedaProducto.onkeyup = (ev) => {
        const parametro = ev.target.value;
        const InvenFiltrados = response[5].filter(x => x.producto.includes(parametro));
        CreateTable(InvenFiltrados, TableProducto);
    }


    ////// TABLA PARA DETALLE
    export default function CreateTableDetalle(Dataset = [], Table, TableFunction, BtnValue = ""Eliminar"") {
        const thead = Table.querySelector(""thead""); //dataset= response, table=nombre de la tabla-tableproducto,?,?
        const tbody = Table.querySelector(""tbody"");//tbody = cuer");
            WriteLiteral(@"po de tabla, thead=encabezado de tabla
        thead.innerHTML = """";
        tbody.innerHTML = """";
        Dataset.forEach((item, index) => {
            const row = document.createElement(""tr"");//filas
            for (var prop in item) {

                if (index == 0) {

                    const th = document.createElement(""th"");//encabezados
                    th.innerText = prop;
                    thead.append(th);
                }
                const td = document.createElement(""td""); //tabledata
                td.innerText = item[prop];
                row.append(td);
            }
            if (index == 0) {
                const th = document.createElement(""th"");
                th.innerText = ""Eliminar"";
                thead.append(th);

            }
            const tdAction = document.createElement(""td"");
            const btn = document.createElement(""input"");
            btn.type = ""button"";
            btn.className = ""BTN BTNOK"";
            btn.value =");
            WriteLiteral(@" BtnValue;
            btn.onclick = (obejetDet = {}) => {
                obejetDet.target.parentNode.parentNode.remove();
                const Eliminar = DetallesCompra.indexOf(obejetDet);
                DetallesCompra.splice(Eliminar, 1);
                console.log(DetallesCompra);
            }
            tdAction.append(btn);
            row.append(tdAction);

            tbody.append(row);
        });
    }


    //GUARDAR LOS DETALLES

    btnDetalle.onclick = async (Objdetalle = {}) => {
        let cantidad = document.getElementById('Txtcantidad');
        let producto = document.getElementById('Txtproducto');
        //const encontrarId = DetallesCompra.find(i => i.Producto == Objdetalle.Producto);

        if (TxtDescuento.value == """" || undefined) TxtDescuento.value = 0

        if (cantidad.value === '' || producto.value === '') {
            alert('Rellena el todos los campos')
            //event.preventDefault();

        } else {

            //if (encontrarI");
            WriteLiteral(@"d == undefined || encontrarId == null) {
            Objdetalle = {
                IdProducto: Txtproducto.value,
                IdInventario: TxtInvent.value,
                IdMedida: DropMedida.value,
                Cantidad: Txtcantidad.value,
                Precio: Txtprecio.value,
                Subtotal: txtsubtotal.value,
                IVA: Txtiva.value,
                Descuento: TxtDescuento.value,
                Total: Txttotal.value
            }
        }
        DetallesCompra.push(Objdetalle);
        console.log(DetallesCompra);

        DetallesCompra.forEach((objeto) => {
            CreateTableDetalle(DetallesCompra, TableCD);

        })
        // SUMA TOTAL DETALLES
        function sumaTotales(DetallC) {
            const suma = DetallC.map(D => D.Total).reduce((a, v) => parseInt(a) + parseInt(v), 1);
            TxttotalC.value = suma;

        }
        sumaTotales(DetallesCompra);


        //MODALDETALLE
        ModalFunction(ModalDetalle);

 ");
            WriteLiteral(@"       Txtproducto.value = """"
        TxtNproducto.value = """"
        Txtcantidad.value = """"
        TxtInvent.value = """"
        Txtprecio.value = """"
        Txtiva.value = """"
        txtsubtotal.value = """"
        Txttotal.value = """"
        TxtDescuento.value = """"
    }


    //SALVAR COMPRA
    window.onload = async () => {
        BtnSave.onclick = async () => {
            let UrlCompra = ""../api/Compra/GuardarCompra"";
            const ObjInst = {
                IdCompra: TxtCompra.value,
                Fecha: Txtfecha.value,
                Descripcion: Txtdescripcion.value,
                IdProveedor: DropProveedor.value,
                Total: TxttotalC.value,
                Estado: DropEstado.value,
                Detalles: DetallesCompra

            }
            let flag = true;
            for (var prop in ObjInst) {
                if (ObjInst[prop] == """") {
                    flag = false;
                    alert(""la propiedad "" + prop + "" es requerida"");");
            WriteLiteral(@"
                    break;
                }
            }

            if (!flag) {
                return;
            }

            let response = await fetch(UrlCompra, {
                method: ""POST"",
                headers: {
                    'Content-Type': ""application/json; charset=utf-8"",
                    'Accept': ""*/*""
                },
                body: JSON.stringify(ObjInst)
            });
            response = await response.json();
            if (response == true) {
                alert(""Datos Guardados"");
                CargarDatos();
                location.reload()
            }

            DropProveedor.value = 0;
            Txtdescripcion.value = """"
        }
        CargarDatos();

        BtnModalProducto.onclick = () => {
            ModalFunction(ModalProducto);
        }
        BtnCerrarProducto.onclick = () => {
            ModalFunction(ModalProducto);
        }

        BtnModalDetalle.onclick = () => {
            Moda");
            WriteLiteral("lFunction(ModalDetalle);\r\n        }\r\n        BtnCerrarD.onclick = () => {\r\n            ModalFunction(ModalDetalle);\r\n        }\r\n    }\r\n\r\n\r\n</script>\r\n\r\n");
            WriteLiteral(@"<div class=""FrmContainer"">

    <div hidden=""true"">
        IdCompra:
        <input class=""TxtForm"" type=""number"" id=""TxtCompra"" placeholder=""Propiedad..."" value=""-1"" />
    </div>
    <div>
        Fecha:
        <input class=""TxtForm"" type=""date"" id=""Txtfecha"" placeholder=""Propiedad..."" />
    </div>

    <div>
        Descripcion:
        <input class=""TxtForm"" type=""text"" id=""Txtdescripcion"" placeholder=""Propiedad..."" />
    </div>

    <div>
        Proveedor:
        <select class=""TxtForm"" id=""DropProveedor"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f0da4edb05b1a7489b661cfe72e61d292cc8a913571", async() => {
                WriteLiteral("Seleccionar Proveedor");
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
        Total:
        <input class=""TxtForm"" type=""number"" id=""TxttotalC"" placeholder=""Propiedad..."" disabled />
    </div>

    <div>
        Estado:
        <select class=""TxtForm"" id=""DropEstado"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f0da4edb05b1a7489b661cfe72e61d292cc8a915021", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f0da4edb05b1a7489b661cfe72e61d292cc8a916193", async() => {
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
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<div class=""ModalContentDetalle"" id=""ModalDetalle"">

    <div class=""FrmContainerDetalle"">

        <div hidden=""true"">
            IdProducto:
            <input class=""TxtForm"" type=""number"" id=""Txtproducto"" placeholder=""Producto"" disabled />
        </div>

        <div style=""display:flex;"">
            <div>
                Producto:
                <input class=""TxtForm"" type=""text"" id=""TxtNproducto"" placeholder=""Producto"" disabled />
            </div>

            <input type=""button"" id=""BtnModalProducto"" class=""BTN BTNOK2"" value=""Insertar Producto"" style=""height:40px; margin-top:30px;margin-left:20px"" />
        </div>

        <div hidden=""true"">
            IdInventario:
            <input class=""TxtForm"" type=""number"" id=""TxtInvent"" disabled />
        </div>

        <div>
            Cantidad:
            <input class=""TxtForm"" type=""number"" id=""Txtcantidad"" />
        </div>

        <div>
            Medida:
            <select class=""TxtForm"" id=""DropMedida"">
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f0da4edb05b1a7489b661cfe72e61d292cc8a918563", async() => {
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
            Precio:
            <input class=""TxtForm"" type=""number"" id=""Txtprecio"" placeholder=""Propiedad..."" disabled />
        </div>

        <div>
            Subtotal:
            <input class=""TxtForm"" type=""number"" id=""txtsubtotal"" placeholder=""Propiedad..."" disabled />
        </div>

        <div>
            IVA:
            <input class=""TxtForm"" type=""number"" id=""Txtiva"" placeholder=""Propiedad..."" disabled />
        </div>

        <div>
            Descuento:
            <input class=""TxtForm"" type=""number"" id=""TxtDescuento"" placeholder=""Propiedad..."" />
        </div>

        <div>
            Total:
            <input class=""TxtForm"" type=""number"" id=""Txttotal"" placeholder=""Propiedad..."" disabled />
        </div>

        <div>

            <input class=""TxtForm"" type=""number"" id=""TxtStockMaximo"" placeholder=""Propiedad..."" disabled hidden=""true"" />
        </div>

        <div>

            <input clas");
            WriteLiteral(@"s=""TxtForm"" type=""number"" id=""TxtStockActual"" placeholder=""Propiedad..."" disabled hidden=""true"" />
        </div>


        <div>
            <button class=""BTN BTNOK2"" id=""btnDetalle"">Guardar Detalles</button>
            <input class=""BTN BTNOK2"" type=""button"" id=""BtnCerrarD"" value=""Cerrar"" style=""margin-top:30px"" />

        </div>

    </div>


</div>

");
            WriteLiteral(@"<div class=""FrmContainer"">
    <div>
        <input class=""BTN BTNOK2"" type=""button"" id=""BtnSave"" value=""Guardar"" />
        <input class=""BTN BTNOK2"" type=""button"" id=""BtnModalDetalle"" value=""Insertar Detalle"" style=""margin-right:120px"" />
    </div>

</div>


");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div>\r\n    <input type=\"text\" class=\"TxtFormDetalle\" id=\"TxtBusquedaCompra\" placeholder=\"Buscar...\"");
            BeginWriteAttribute("value", " value=\"", 12390, "\"", 12398, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <table id=\"TableCompra\" class=\"FrmTable\">\r\n        <thead>\r\n        </thead>\r\n        <tbody>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            WriteLiteral("<table id=\"TableCD\" class=\"FrmTable\">\r\n    <thead>\r\n    </thead>\r\n    <tbody>\r\n    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral("<div class=\"ModalContent\" id=\"ModalProducto\">\r\n    <div class=\"ContainerForm\" style=\"width:max-content\">\r\n        <input type=\"text\" id=\"TxtBusquedaProducto\" class=\"TxtFormDetalle\" placeholder=\"Buscar...\"");
            BeginWriteAttribute("value", " value=\"", 12911, "\"", 12919, 0);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.CatManageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatManageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatManageModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.CatManageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591