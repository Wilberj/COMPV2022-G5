using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CAPA_NEGOCIO;

namespace PROYECTO_TIENDA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        [HttpPost]

        public Object VerCompra()
        {
            List<Object> Response = new List<Object>();

            Compra Inst = new Compra();
            Response.Add(Inst.TraerCompra(Inst));

            NProveedor Prov = new NProveedor();
            Response.Add(Prov.TraerProveedor(Prov));

            DetalleCompra dt = new DetalleCompra();
            Response.Add(dt.TraerDetalleCompra(dt));

            NInventario i = new NInventario();
            Response.Add(i.GetInventario(i));

            MostrarInventario I = new MostrarInventario();
            Response.Add(I.TraerInvProc(I));

            VistaCmpraDetalle CD = new VistaCmpraDetalle();
            Response.Add(CD.TraerCompraConProc(CD));

            return Response;
        }

        [HttpPost]
        public object GuardarCompra(object ObjInst)
        {
            Compra Inst = JsonConvert.DeserializeObject<Compra>(ObjInst.ToString());
            Inst.Insertar(Inst);

            return true;
        }
    }
}
