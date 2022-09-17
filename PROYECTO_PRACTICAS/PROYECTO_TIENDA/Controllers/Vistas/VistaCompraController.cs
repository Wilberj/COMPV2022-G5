using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;

namespace PROYECTO_TIENDA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VistaCompraController : ControllerBase
    {
        [HttpPost]
        public object VerCompraProc()
        {
            
            VistaCmpraDetalle Inst = new VistaCmpraDetalle();
            return Inst.TraerCompraConProc(Inst);
        }
    }
}
