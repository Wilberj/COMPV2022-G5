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
    public class ValuesControllerClientes : ControllerBase
    {
        [HttpPost]
        public object SaveClientes(object ObjInst)
        {
            NClientes Inst = JsonConvert.DeserializeObject<NClientes>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpPost]
        public object GetCliente()
        {
            NClientes Inst = new NClientes();
            return Inst.GetClientes(Inst);
        }
    }
}
