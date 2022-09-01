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
    public class ValuesControllerTalla : ControllerBase
    {
        [HttpPost]
        public object SaveTalla(object ObjInst)
        {
            NTalla Inst = JsonConvert.DeserializeObject<NTalla>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }

        [HttpPost]
        public object GetTalla()
        {
            NTalla Inst = new NTalla();
            return Inst.GetTalla(Inst);
        }
    }
}
