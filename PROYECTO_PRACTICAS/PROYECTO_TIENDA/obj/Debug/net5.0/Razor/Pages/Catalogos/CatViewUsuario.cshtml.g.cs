<<<<<<< HEAD
#pragma checksum "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\CatViewUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5679bef32e625649401d313295d28065c443b160"
=======
#pragma checksum "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\Catalogos\CatViewUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92406e5f184613faf52bdc6a3381cdc228641e1d"
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROYECTO_TIENDA.Pages.Catalogos.Pages_Catalogos_CatViewUsuario), @"mvc.1.0.razor-page", @"/Pages/Catalogos/CatViewUsuario.cshtml")]
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
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
=======
#line 2 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
using PROYECTO_TIENDA;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\USER\Desktop\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
=======
#line 3 "C:\Sistema\COMPV2022-G5\PROYECTO_PRACTICAS\PROYECTO_TIENDA\Pages\_ViewImports.cshtml"
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
using PROYECTO_TIENDA.Data;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5679bef32e625649401d313295d28065c443b160", @"/Pages/Catalogos/CatViewUsuario.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92406e5f184613faf52bdc6a3381cdc228641e1d", @"/Pages/Catalogos/CatViewUsuario.cshtml")]
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1589a794a507b402e5738872327c01bae8496fb4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalogos_CatViewUsuario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
    import CreateDropDown from ""../js/DropDownComponent.js"";

    const CargarDatos = async () => {
        let UrlP = ""../api/ValuesControllerUsuarios/TakeDataForUsuario"";
        let response = await fetch(UrlP, {
            method: ""POST"",
            headers: {
                'Content-Type': ""application/json; charset=utf-8"",
                'Accept': ""*/*""
            }
        });
        response = await response.json();
        console.log(response);

        CreateTable(response[1], TableData, FunctionEdit);
        CreateDropDown(response[0], DropRol, ""idRol"", ""rol"");
        
    }
    const FunctionEdit = async (Item) => {
        TxtIdUsuario.value = Item.idUsuario;
        TxtUsuario.value = Item.usuario;
<<<<<<< HEAD
        TxtContrasena.value = Item.contraseña;
=======
        TxtContrasena.value = Item.contrasena;
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
        DropRol.value = Item.idRol;
        DropEstado.value = Item.estado;
    }
    window.onload = async () => {
        BtnSave.onclick ");
            WriteLiteral(@"= async () => {
            const ObjInst = {
                IdUsuario: TxtIdUsuario.value,
                Usuario: TxtUsuario.value,
<<<<<<< HEAD
                Contraseña: TxtContrasena.value,
=======
                Contrasena: TxtContrasena.value,
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
                IdRol: DropRol.value,
                Estado: DropEstado.value
            }
            let Url = ""../api/ValuesControllerUsuarios/SaveUsuarios"";
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

                TxtIdUsuario.value = ""-1"";
                DropRol.value = """";
                TxtUsuario.value = """";
                TxtContrasena.value = """";
                DropEstado.value = """";
 ");
            WriteLiteral(@"           }
        }
        //Cargar Categorias
        CargarDatos();
    }
</script>

<div class=""FrmContainer"">
    <div hidden=""true"">
        Id Usuario:
        <input class=""TxtForm"" type=""number"" id=""TxtIdUsuario"" value=""-1"" />
    </div>

    <div>
        Usuario:
        <input class=""TxtForm"" type=""text"" id=""TxtUsuario"" placeholder=""Propiedad..."" />
    </div>

    <div>
        Contraseña:
        <input class=""TxtForm"" type=""text"" id=""TxtContrasena"" placeholder=""Propiedad..."" />
    </div>

    <div>
        Rol:
        <select class=""TxtForm minimal"" id=""DropRol"">
");
            WriteLiteral("        </select>\r\n    </div>\r\n\r\n    <div>\r\n        Estado:\r\n        <select class=\"TxtForm\" id=\"DropEstado\">\r\n            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5679bef32e625649401d313295d28065c443b1606999", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92406e5f184613faf52bdc6a3381cdc228641e1d6955", async() => {
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5679bef32e625649401d313295d28065c443b1608170", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92406e5f184613faf52bdc6a3381cdc228641e1d8126", async() => {
>>>>>>> f5a85abdc3241312d311c51f60f38213929a1acb
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECTO_TIENDA.Pages.Catalogos.CatViewUsuarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewUsuarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROYECTO_TIENDA.Pages.Catalogos.CatViewUsuarioModel>)PageContext?.ViewData;
        public PROYECTO_TIENDA.Pages.Catalogos.CatViewUsuarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
