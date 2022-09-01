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
    public class ValuesControllerProducto : ControllerBase
    {
        [HttpPost]
        public object SaveProducto(object ObjInst)
        {
            NProducto Inst = JsonConvert.DeserializeObject<NProducto>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetProducto()
        {
            NProducto Inst = new NProducto();
            return Inst.GetProducto(Inst);
        }
        //Añadi nuevo
        [HttpPost]
        public object TakeDataForCategoria()
        {
            List<object> Response = new List<object>();
            NProducto Pro = new NProducto();
            Response.Add(Pro.GetProducto(Pro));
            NCategorias Cat = new NCategorias();
            Response.Add(Cat.GetCategoria(Cat));
            return Response;
        }
    }
}
