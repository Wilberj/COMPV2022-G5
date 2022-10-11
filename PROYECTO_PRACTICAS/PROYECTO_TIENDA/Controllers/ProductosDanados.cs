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
    public class ProductosDanados : ControllerBase
    {
        [HttpPost]

        public object SaveDan(object ObjInst)
        {
            ProductosDan Inst = JsonConvert.DeserializeObject<ProductosDan>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object TraerProductosD()
        {

            List<Object> Response = new List<Object>();

            ProductosDan Inst = new ProductosDan();
            Response.Add(Inst.GetDañado(Inst));
            NUsuarios U = new NUsuarios();
            Response.Add(U.GetUsuarios(U));
            NMarca Mar = new NMarca();
            Response.Add(Mar.GetMarca(Mar));
            NTalla Tal = new NTalla();
            Response.Add(Tal.GetTalla(Tal));
            Bodega B = new Bodega();
            Response.Add(B.GetBodega(B));
            TransMedida TM = new TransMedida();
            Response.Add(TM.TraerTransMedida(TM));
            NInventario i = new NInventario();
            Response.Add(i.GetInventario(i));

            return Response;
        }
    }
}
