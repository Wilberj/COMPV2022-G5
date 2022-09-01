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
    public class ValuesControllerUsuarios : ControllerBase
    {
        [HttpPost]
        public object SaveUsuarios(object ObjInst)
        {
            NUsuarios Inst = JsonConvert.DeserializeObject<NUsuarios>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetUsuarios()
        {
            NUsuarios Inst = new NUsuarios();
            return Inst.GetUsuarios(Inst);
        }

        public object TakeDataForUsuario()
        {
            List<object> Response = new List<object>();
            RolUsuario Inv = new RolUsuario();
            Response.Add(Inv.GetRol(Inv));

            NUsuarios UR = new NUsuarios();
            Response.Add(UR.GetUsuarios(UR));

            return Response;
        }
    }
}
