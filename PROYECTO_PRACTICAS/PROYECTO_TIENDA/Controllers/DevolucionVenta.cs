using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using Newtonsoft.Json;

namespace PROYECTO_TIENDA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DevolucionVenta : ControllerBase
    {
        [HttpPost]

        public Object VerDevolucion()
        {
            List<Object> Response = new List<Object>();

            Ventas V = new Ventas();
            Response.Add(V.TraerVenta(V));

            DetalleVenta DV = new DetalleVenta();
            Response.Add(DV.VerDetalles(DV));

            NInventario i = new NInventario();
            Response.Add(i.GetInventario(i));

            NUsuarios U = new NUsuarios();
            Response.Add(U.GetUsuarios(U));

            NClientes C = new NClientes();
            Response.Add(C. GetClientes(C));

            VistaInventario VI =new  VistaInventario();
            Response.Add(VI.TraerInventario(VI));

            UMedida UM = new UMedida();
            Response.Add(UM.GetMedida(UM));

            return Response;
        }

        [HttpPost]
        public object GuardarDevolucion(object ObjInst)
        {
            DevolucionesVenta Inst = JsonConvert.DeserializeObject<DevolucionesVenta>(ObjInst.ToString());
            Inst.Save(Inst);

            return true;
        }
    }
}
