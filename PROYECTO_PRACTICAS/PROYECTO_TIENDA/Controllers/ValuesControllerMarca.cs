using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

using CAPA_NEGOCIO;

namespace PROYECTO_TIENDA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesControllerMarca : ControllerBase
    {
        [HttpPost]
        public object SaveMarca(object ObjInst)
        {
            NMarca Inst = JsonConvert.DeserializeObject<NMarca>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }

        [HttpPost]
        public object GetMarca()
        {
            NMarca Inst = new NMarca();
            return Inst.GetMarca(Inst);
        }
    }
}
