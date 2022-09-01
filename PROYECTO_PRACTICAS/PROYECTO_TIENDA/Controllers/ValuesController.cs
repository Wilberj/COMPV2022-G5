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
    public class ValuesController : ControllerBase
    {
        [HttpPost]

        public object SaveCategoria(object ObjInst)
        {
            NCategorias Inst = JsonConvert.DeserializeObject<NCategorias>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetCategoria()
        {
            NCategorias Inst = new NCategorias();
            return Inst.GetCategoria(Inst);
        }
    }
}
