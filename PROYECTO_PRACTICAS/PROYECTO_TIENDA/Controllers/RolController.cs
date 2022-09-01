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
    public class RolController : ControllerBase
    {
        [HttpPost]

        public object SaveRol(object ObjInst)
        {
            RolUsuario Inst = JsonConvert.DeserializeObject<RolUsuario>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetRol()
        {
            RolUsuario Inst = new RolUsuario();
            return Inst.GetRol(Inst);
        }
    }
}
