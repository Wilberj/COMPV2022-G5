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
    public class ReporteCController : ControllerBase
    {
        [HttpPost]
        public object TakeInformeCPV(object ObjInst)
        {
            InformeCompra Inst = JsonConvert.DeserializeObject<InformeCompra>(ObjInst.ToString());
            return Inst.TraerInforme(Inst);
        }

        [HttpPost]
        public object TakeInformeVenta(object ObjInst)
        {
            ReporteVenta Inst = JsonConvert.DeserializeObject<ReporteVenta>(ObjInst.ToString());
            return Inst.TraerInforme(Inst);
        }

        [HttpPost]
        public object ProdMV()
        {
            ReportePMV Inst = new ReportePMV();
            return Inst.TraerPMV(Inst);
        }


    }
}
