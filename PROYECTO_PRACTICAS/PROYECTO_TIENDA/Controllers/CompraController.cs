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

            UMedida UM = new UMedida();
            Response.Add(UM.GetMedida(UM));

            NInventario i = new NInventario();
            Response.Add(i.GetInventario(i));

            MostrarInventario I = new MostrarInventario();
            Response.Add(I.TraerInvProc(I));

            return Response;
        }

        [HttpPost]
        public object GuardarCompra(object ObjInst)
        {
            Compra Inst = JsonConvert.DeserializeObject<Compra>(ObjInst.ToString());
            Inst.Insertar(Inst);

            return true;
        }

        //public object VerCompraProc(object ObjInst)
        //{
        //    Compra Inst = JsonConvert.DeserializeObject <Compra>(ObjInst.ToString());
        //    return Inst.TraerCompraConProc(Inst);
        //}


    }
}