<<<<<<< HEAD
#pragma checksum "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\ViewClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35827401d242907eb4b36f9716a3ca189c948c52"
=======
#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\ViewClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35827401d242907eb4b36f9716a3ca189c948c52"
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Pages_Catalogos_ViewClientes), @"mvc.1.0.razor-page", @"/Pages/Catalogos/ViewClientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35827401d242907eb4b36f9716a3ca189c948c52", @"/Pages/Catalogos/ViewClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_ViewClientes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Activo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Inactivo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    const CargarDatos = async () => {
        let UrlP = ""../api/ValuesControllerClientes/GetCliente"";
        let response = await fetch(UrlP, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });
        response = await response.json();
        console.log(response);
        CreateTable(response, TableData, FunctionEdit);
    }
    const FunctionEdit = async (Item) => {
        TxtIdCliente.value = Item.idCliente;
        TxtNombres.value = Item.nombres;
        TxtApellidos.value = Item.apellidos;
        TxtCelular.value = Item.celular;
        TxtDireccion.value = Item.direccion;
        DropEstado.value = Item.estado;
    }
    window.onload = async () => {
        BtnSave.onclick = async () => {
            const ObjInst = {
                IdCliente: TxtIdCliente.value,
     ");
            WriteLiteral(@"           Nombres: TxtNombres.value,
                Apellidos: TxtApellidos.value,
                Celular: TxtCelular.value,
                Direccion: TxtDireccion.value,
                Estado: DropEstado.value
            }
            let Url = ""../api/ValuesControllerClientes/SaveClientes"";
            let response = await fetch(Url, {
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
                TxtIdCliente.value = """";
                TxtNombres.value = """";
                TxtApellidos.value = """";
                TxtCelular.value = """";
                TxtDireccion.value = """";
               
            }
        }
        ");
            WriteLiteral(@"//Cargar Categorias
        CargarDatos();
    }
</script>

<div class=""FrmContainer"">
   <div hidden=""true"">
        Id Cliente:
        <input class=""TxtForm"" type=""number"" id=""TxtIdCliente"" value=""-1"" />
    </div>

    <div>
        Nombres:
        <input class=""TxtForm"" type=""text"" id=""TxtNombres"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Apellidos:
        <input class=""TxtForm"" type=""text"" id=""TxtApellidos"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Celular:
        <input class=""TxtForm"" type=""number"" id=""TxtCelular"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Direccion:
        <input class=""TxtForm"" type=""text"" id=""TxtDireccion"" placeholder=""Propiedad..."" />
    </div>
    <div>
        Estado:
        <select class=""TxtForm minimal"" id=""DropEstado"">
            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35827401d242907eb4b36f9716a3ca189c948c527075", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35827401d242907eb4b36f9716a3ca189c948c527031", async() => {
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
                WriteLiteral("Activo");
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
            WriteLiteral("\r\n            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35827401d242907eb4b36f9716a3ca189c948c528246", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35827401d242907eb4b36f9716a3ca189c948c528202", async() => {
>>>>>>> 41c719d25a772fe85e3601dee3320ea0cfe88d19
                WriteLiteral("Inactivo");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.CatViewClientesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewClientesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewClientesModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.CatViewClientesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
