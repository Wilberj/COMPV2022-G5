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
    public class DanController : ControllerBase
    {
        [HttpPost]

        public object SaveDan(object ObjInst)
        {
            Dañados Inst = JsonConvert.DeserializeObject<Dañados>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetInventario()
        {
            Dañados Inst = new Dañados();
            return Inst.GetDañado(Inst);
        }
        [HttpPost]
        public object TakeDataForInventario()
        {
            List<object> Response = new List<object>();
            Dañados dan = new Dañados();
            Response.Add(dan.GetDañado(dan));
            NProducto Pro = new NProducto();
            Response.Add(Pro.GetProducto(Pro));
            NInventario Inv = new NInventario();
            Response.Add(Inv.GetInventario(Inv));
            UMedida m = new UMedida();
            Response.Add(m.SaveU(m));
            return Response;
        }


    }
}
