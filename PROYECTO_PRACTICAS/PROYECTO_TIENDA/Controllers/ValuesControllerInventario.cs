using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;

namespace PROYECTO_TIENDA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesControllerInventario : ControllerBase
    {
        [HttpPost]

        public object SaveInventario(object ObjInst)
        {
            NInventario Inst = JsonConvert.DeserializeObject<NInventario>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetInventario()
        {
            NInventario Inst = new NInventario();
            return Inst.GetInventario(Inst);
        }
        [HttpPost]
        public object TakeDataForInventario()
        {
            List<object> Response = new List<object>();
            NInventario Inv = new NInventario();
            Response.Add(Inv.GetInventario(Inv));
            NProducto Pro = new NProducto();
            Response.Add(Pro.GetProducto(Pro));
            NMarca Mar = new NMarca();
            Response.Add(Mar.GetMarca(Mar));
            NTalla Tal = new NTalla();
            Response.Add(Tal.GetTalla(Tal));
            Bodega B = new Bodega();
            Response.Add(B.GetBodega(B));
            return Response;
        }

        public object TraerInforme(object Inventario)
        {
            NInventario InformI = JsonConvert.DeserializeObject<NInventario>(Inventario.ToString()); ;
            return InformI.TraerInformeInventario(InformI);
        }
    }
}
