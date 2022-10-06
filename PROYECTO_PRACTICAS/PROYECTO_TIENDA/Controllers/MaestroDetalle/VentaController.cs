using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using Newtonsoft.Json;

namespace PROYECTO_TIENDA.Controllers.Venta
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpPost]

        public Object VerVenta()
        {
            List<Object> Response = new List<Object>();

            Ventas Inst = new Ventas();
            Response.Add(Inst.TraerVenta(Inst));

            NClientes Prov = new NClientes();
            Response.Add(Prov.GetClientes(Prov));

            NInventario i = new NInventario();
            Response.Add(i.GetInventario(i));

            NUsuarios U = new NUsuarios();
            Response.Add(U.GetUsuarios(U));

            UMedida UM = new UMedida();
            Response.Add(UM.GetMedida(UM));

            VistaInventario VI = new VistaInventario();
            Response.Add(VI.TraerInventario(VI));

            return Response;
        }

        [HttpPost]
        public object GuardarVenta(object ObjInst)
        {
            Ventas Inst = JsonConvert.DeserializeObject<Ventas>(ObjInst.ToString());
            Inst.Insertar(Inst);

            return true;
        }
    }
}
