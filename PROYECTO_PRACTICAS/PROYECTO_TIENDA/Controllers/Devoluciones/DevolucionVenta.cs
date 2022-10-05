using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using Newtonsoft.Json;

namespace PROYECTO_TIENDA.Controllers.Devoluciones
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DevolucionVenta : ControllerBase
    {
        [HttpPost]

        public Object VerDevolucion()
        {
            List<Object> Response = new List<Object>();

            NProducto P = new NProducto();
            Response.Add(P.GetProducto(P));

            NInventario i = new NInventario();
            Response.Add(i.GetInventario(i));

            MostrarInventario I = new MostrarInventario();
            Response.Add(I.TraerInvProc(I));

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
