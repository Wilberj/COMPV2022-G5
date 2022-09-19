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
    public class ProveedorController : ControllerBase
    {
        [HttpPost]

        public object InsertarP(object ObjInst)
        {
            NProveedor Inst = JsonConvert.DeserializeObject<NProveedor>(ObjInst.ToString());
            Inst.Insertar(Inst);
            return true;
        }
        [HttpPost]
        public object GetProveedor()
        {
            NProveedor Inst = new NProveedor();
            return Inst.TraerProveedor(Inst);
        }
    }
}

