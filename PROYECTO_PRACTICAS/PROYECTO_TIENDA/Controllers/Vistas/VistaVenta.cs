using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;

namespace PROYECTO_TIENDA.Controllers.Vistas
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VistaVenta : ControllerBase
    {
        [HttpPost]
        public object VerVentaProc()
        {

            VistaVentaDetalle Inst = new VistaVentaDetalle();
            return Inst.TraerVentaConProc(Inst);
        }
    }
}
